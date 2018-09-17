// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2018]  [AMANA consulting GmbH] 
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
    public partial class NameUc : UserControl
    {
        private Name _name;

        public NameUc()
        {
            InitializeComponent();
        }

        public Name IfpName
        {
            get { return _name; }
            set
            {
                _name = value;
                UpdateDataBindings();
            }
        }

        private void UpdateDataBindings()
        {
            NameTextBox.DataBindings.Clear();
            NameAffixTextBox.DataBindings.Clear();
            NameAdditionTextBox.DataBindings.Clear();

            if (_name == null)
                return;

            NameTextBox.SetTextDataBinding(_name, nameof(_name.FullName));
            NameAffixTextBox.SetTextDataBinding(_name, nameof(_name.NameAffix));
            NameAdditionTextBox.SetTextDataBinding(_name, nameof(_name.NameAddition));
        }
    }
}
