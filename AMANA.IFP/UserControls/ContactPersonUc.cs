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
    public partial class ContactPersonUc : UserControl
    {
        private ContactPerson _contactPerson;

        public ContactPersonUc()
        {
            InitializeComponent();
        }

        public ContactPerson ContactPerson
        {
            get { return _contactPerson; }
            set
            {
                _contactPerson = value;
                InitializeDataBindings();
            }
        }

        private void InitializeDataBindings()
        {
            ContactPersonNameAddressTextBox.DataBindings.Clear();
            ContactNameAdditionTextBox.DataBindings.Clear();
            ContactFirstNameTextBox.DataBindings.Clear();
            ContactLastNameTextBox.DataBindings.Clear();

            if (_contactPerson == null)
                return;

            ContactPersonNameAddressTextBox.SetTextDataBinding(_contactPerson, nameof(_contactPerson.Address));
            ContactNameAdditionTextBox.SetTextDataBinding(_contactPerson, nameof(_contactPerson.NameAddition));
            ContactFirstNameTextBox.SetTextDataBinding(_contactPerson, nameof(_contactPerson.FirstName));
            ContactLastNameTextBox.SetTextDataBinding(_contactPerson, nameof(_contactPerson.LastName));
        }
    }
}
