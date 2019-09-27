// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2018]  [AMANA consulting GmbH] 
// 
// Die Veröffentlichung dieses Programms erfolgt in der Hoffnung, dass es Ihnen von
// Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite
// Garantie der MARKTREIFE oder der VERWENDBARKEIT FÜR EINEN BESTIMMTEN ZWECK.
// Details finden Sie in der GNU General Public License.
// 
// Link zu den Lizenzbedingungen: https://www.gnu.org/licenses/gpl-3.0.txt
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Web;
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Common
{
    public class Attachment : INotifyPropertyChanged
    {
        private string _filePath;
        private string _mimetype;
        private string _attachmentId;
        private string _name;
        private string _description;
        private AttachmentIdTypes _attachmentType;

        public string FilePath
        {
            get { return _filePath; }

            set
            {
                _filePath = value;
                Mimetype = MimeMapping.GetMimeMapping(_filePath);
                Document = File.ReadAllBytes(_filePath);
            }
        }

        public string Mimetype
        {
            get { return _mimetype; }
            set
            {
                if (value == _mimetype) return;
                _mimetype = value;
                OnPropertyChanged();
            }
        }

        public string AttachmentId
        {
            get { return _attachmentId; }
            set
            {
                if (value == _attachmentId) return;
                _attachmentId = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (value == _description) return;
                _description = value;
                OnPropertyChanged();
            }
        }

        public AttachmentIdTypes AttachmentType
        {
            get { return _attachmentType; }
            set
            {
                if (value == _attachmentType) return;
                _attachmentType = value;
                UpdateAttachmentId();
                OnPropertyChanged();
            }
        }

        public byte[] Document { get; set; }

        public Attachment Copy()
        {
            return CopyTo(new Attachment());
        }

        public Attachment CopyTo(Attachment attachment)
        {
            attachment.Mimetype = Mimetype;
            attachment.AttachmentId = AttachmentId;
            attachment.Name = Name;
            attachment.Description = Description;
            attachment.Document = new byte[Document.Length];
            attachment.AttachmentType = AttachmentType;
            attachment.AttachmentId = AttachmentId;
            Document.CopyTo(attachment.Document, 0);

            return attachment;
        }

        public enum AttachmentIdTypes
        {
            Ohne,
            Japdf,
            Pruef,
            Ident,
            Sonst
        }

        public static string AttachmentIdTypeToElbaString(AttachmentIdTypes type)
        {
            switch (type)
            {
                case AttachmentIdTypes.Japdf:
                    return "JAPDF_";
                case AttachmentIdTypes.Pruef:
                    return "PRUEF_";
                case AttachmentIdTypes.Ident:
                    return "IDENT_";
                case AttachmentIdTypes.Sonst:
                    return "SONST_";
            }

            return string.Empty;
        }

        public ns3BinaerAnhangTyp ToElbaData(string attachmentTimeStamp)
        {
            ns3BinaerAnhangTyp anhang = new ns3BinaerAnhangTyp
            {
                Typ = Mimetype,
                AnhangID = GetAnhangId(attachmentTimeStamp),
                Name = Name,
                Beschreibung = Description,
                Dokument = Document
            };

            return anhang;
        }

        public static string GetAttachmentTimeStamp()
        {
            var time = DateTime.Now;
            var attachmentTimestamp =
                $"{time.Year.ToString("d4")}{time.Month.ToString("d2")}{time.Day.ToString("d2")}{time.Hour.ToString("d2")}{time.Minute.ToString("d2")}{time.Second.ToString("d2")}";

            return attachmentTimestamp;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string GetAnhangId(string attachmentTimeStamp)
        {
            if (AttachmentType == AttachmentIdTypes.Ohne)
                return null;

            if (!string.IsNullOrEmpty(AttachmentId))
                return AttachmentId;

            return $"{AttachmentIdTypeToElbaString(AttachmentType)}{attachmentTimeStamp}";
        }

        private void UpdateAttachmentId()
        {
            string timestamp;
            if (AttachmentId != null && AttachmentId.Length > 14)
                timestamp = AttachmentId.Substring(AttachmentId.Length - 14);
            else
                timestamp = GetAttachmentTimeStamp();

            AttachmentId = GetAnhangId(timestamp);
        }
    }
}