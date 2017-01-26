// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2016]  [AMANA consulting GmbH] 
// 
// Die Veröffentlichung dieses Programms erfolgt in der Hoffnung, dass es Ihnen von
// Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite
// Garantie der MARKTREIFE oder der VERWENDBARKEIT FÜR EINEN BESTIMMTEN ZWECK.
// Details finden Sie in der GNU General Public License.
// 
// Link zu den Lizenzbedingungen: https://www.gnu.org/licenses/gpl-3.0.txt
using System.Windows.Forms;
using AMANA.IFP.Common;

namespace AMANA.IFP.UserControls
{
    public partial class ContactUc : UserControl
    {
        private ContactData _contactData;

        public ContactUc()
        {
            InitializeComponent();
        }

        public ContactData ContactData
        {
            get { return _contactData; }
            set
            {
                _contactData = value;
                ContactPersonUc.ContactPerson = _contactData?.ContactPerson;
                InitializeControlBindings();
            }
        }

        private void InitializeControlBindings()
        {
            ContactPhoneNumberTextBox.DataBindings.Clear();
            ContactEmailTextBox.DataBindings.Clear();

            if (_contactData == null)
                return;

            ContactPhoneNumberTextBox.SetTextDataBinding(_contactData, nameof(_contactData.PhoneNumber));
            ContactEmailTextBox.SetTextDataBinding(_contactData, nameof(_contactData.Email));
        }
    }
}
