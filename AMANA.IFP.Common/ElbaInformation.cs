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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AMANA.IFP.Common.Helpers;
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Common
{
    [Serializable]
    public class ElbaInformation
    {        
        public Sender SenderInformation { get; set; }
        public Receiver RecieverInformation { get; set; }
        public Customer CustomerInformation { get; set; }
        public List<BalanceInformation> BalanceInformationList { get; set; }
        private readonly string _serializedObjectFilePath;

        public BalanceInformation PrimaryBalanceInformation
        {
            get { return BalanceInformationList.LastOrDefault(); }            
        }

        private ElbaInformation()
        {
            SenderInformation = new Sender();
            RecieverInformation = new Receiver();
            CustomerInformation = new Customer();            
        }

        public ElbaInformation(string serializedObjectFilePath):this()
        {
            _serializedObjectFilePath = serializedObjectFilePath;
            BalanceInformationList = new List<BalanceInformation>();
            BalanceInformationList.Add(new BalanceInformation());
        }

        public ElbaInformation Load()
        {
            var desializedElbaInformation = GenericXmlSerializerHelper.DeserializeFromFile<ElbaInformation>(_serializedObjectFilePath);
            if (desializedElbaInformation != null)
            {
                this.SenderInformation = desializedElbaInformation.SenderInformation;
                this.RecieverInformation = desializedElbaInformation.RecieverInformation;
                this.CustomerInformation = desializedElbaInformation.CustomerInformation;
                this.BalanceInformationList = desializedElbaInformation.BalanceInformationList;
            }

            return this;
        }

        public void Save()
        {
            GenericXmlSerializerHelper.SerializeToFile(_serializedObjectFilePath, this);
        }

        public bool IsStoredAsFile()
        {
            return File.Exists(_serializedObjectFilePath);
        }

        public void DeleteStoredFile()
        {
            File.Delete(_serializedObjectFilePath);
        }

        public ns2BilanzdatenTyp ToElbaData()
        {
            ns2BilanzdatenTyp balanceData = new ns2BilanzdatenTyp
            {
                Absender = SenderInformation.ToElbaData(),
                Empfaenger = RecieverInformation.ToElbaData(),
                Kunde = CustomerInformation.ToElbaData(),
                Abschluss = new ns2AbschlussTyp[BalanceInformationList.Count]
            };

            for (int i = 0; i < BalanceInformationList.Count; i++)
                balanceData.Abschluss[i] = BalanceInformationList[i].ToElbaData();

            return balanceData;
        }
    }
}
