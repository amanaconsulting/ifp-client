// AMANA DiFin Client zum Erstellen und Versenden von XBRL-Abschlussdaten via DiFin
// Copyright (C) [2016]  [AMANA consulting GmbH] 
// 
// Die Veröffentlichung dieses Programms erfolgt in der Hoffnung, dass es Ihnen von
// Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite
// Garantie der MARKTREIFE oder der VERWENDBARKEIT FÜR EINEN BESTIMMTEN ZWECK.
// Details finden Sie in der GNU General Public License.
// 
// Link zu den Lizenzbedingungen: https://www.gnu.org/licenses/gpl-3.0.txt
using System;
using System.Windows.Forms;

namespace AMANA.IFP
{
    public static class Extensions
    {
        public static void ToMessageBox(this Exception ex)
        {
            MessageBox.Show($"{ex.Message}:\n{ex.StackTrace}");
        }

        public static ComboBox SetSelectedItemDataBinding(this ComboBox comboBox, object dataSource, string dataMember,
            DataSourceUpdateMode updateMode = DataSourceUpdateMode.OnPropertyChanged)
        {
            comboBox.SetDataBinding(nameof(comboBox.SelectedItem), dataSource, dataMember, updateMode);
            return comboBox; 
        }

        public static CheckBox SetCheckedDataBinding(this CheckBox checkBox, object dataSource, string dataMember,
            DataSourceUpdateMode updateMode = DataSourceUpdateMode.OnPropertyChanged)
        {
            checkBox.SetDataBinding(nameof(checkBox.Checked), dataSource, dataMember, updateMode);
            return checkBox;
        }

        public static Control SetTextDataBinding(this Control control, object dataSource, string dataMember,
            DataSourceUpdateMode updateMode = DataSourceUpdateMode.OnPropertyChanged)
        {
            control.SetDataBinding(nameof(control.Text), dataSource, dataMember, updateMode);
            return control;
        }

        public static Control SetEnabledDataBinding(this Control control, object dataSource, string dataMember,
            DataSourceUpdateMode updateMode = DataSourceUpdateMode.OnPropertyChanged)
        {
            control.SetDataBinding(nameof(control.Enabled), dataSource, dataMember, updateMode);
            return control;
        }

        public static Control SetVisibleDataBinding(this Control control, object dataSource, string dataMember,
            DataSourceUpdateMode updateMode = DataSourceUpdateMode.OnPropertyChanged)
        {
            control.SetDataBinding(nameof(control.Visible), dataSource, dataMember, updateMode);
            return control;
        }

        public static Control SetDataBinding(this Control control, string propertyName, object dataSource,
            string dataMember, DataSourceUpdateMode updateMode = DataSourceUpdateMode.OnPropertyChanged)
        {
            control.DataBindings.Add(propertyName, dataSource, dataMember, false, updateMode);
            return control;
        }
    }
}