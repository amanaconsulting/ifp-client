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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AMANA.IFP.Client;
using AMANA.IFP.Common;
using AMANA.IFP.Common.Helpers;

namespace AMANA.IFP.UserControls
{
    public partial class AddressUc : UserControl, INotifyPropertyChanged
    {
        public bool DisplayGcdButton
        {
            get { return _displayGcdButton; }
            set
            {
                if (value == _displayGcdButton) return;
                _displayGcdButton = value;
                UpdateGcdButtonVisibility();
                OnPropertyChanged();
            }
        }

        private Address _address;

        private IfpDataContainer _dataContainer;
        private bool _displayGcdButton;

        private BalanceInformation PrimaryBalanceInformation => _dataContainer.ElbaInformation.PrimaryBalanceInformation;

        public AddressUc()
        {
            InitializeComponent();
            InitializeControls();
        }

        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
                InitializeDataBindings();
            }
        }

        public void SetIfpDataContainer(IfpDataContainer dataContainer)
        {
            _dataContainer = dataContainer;
        }

        private void InitializeControls()
        {
            GcdDataTooltip.SetToolTip(ApplyGcdDataStreetButton, GuiHelper.GetGcdValueTooltipText("Adresse"));
            GcdDataTooltip.SetToolTip(ApplyGcdDataZipCodeButton, GuiHelper.GetGcdValueTooltipText("PLZ"));
            GcdDataTooltip.SetToolTip(ApplyGcdDataCityButton, GuiHelper.GetGcdValueTooltipText("Stadt"));
            GcdDataTooltip.SetToolTip(ApplyGcdDataCountryButton, GuiHelper.GetGcdValueTooltipText("Land"));
        }

        private void InitializeDataBindings()
        {
            ChkSendHomeAddress.DataBindings.Clear();
            HomeAddressStreetTextBox.DataBindings.Clear();
            HomeAddressZipCodeTextBox.DataBindings.Clear();
            HomeAddressCityTextBox.DataBindings.Clear();
            HomeAddressSubCityTextBox.DataBindings.Clear();

            ChkSendBoxAddress.DataBindings.Clear();
            BoxZipCodeTextBox.DataBindings.Clear();
            BoxCityTextBox.DataBindings.Clear();
            BoxNumberTextBox.DataBindings.Clear();

            CountryTextBox.DataBindings.Clear();
            StateTextBox.DataBindings.Clear();

            ApplyGcdDataStreetButton.DataBindings.Clear();
            ApplyGcdDataZipCodeButton.DataBindings.Clear();
            ApplyGcdDataCityButton.DataBindings.Clear();
            ApplyGcdDataCountryButton.DataBindings.Clear();


            if (_address?.HomeAddress == null)
                return;

            HomeAddress homeAddress = _address.HomeAddress;
            PostOfficeBox box = _address.PostOfficeBox;

            ChkSendHomeAddress.SetCheckedDataBinding(_address, nameof(_address.HasHomeAddress));

            SetHasHomeAddressEnabledBinding(HomeAddressStreetTextBox)
                .SetTextDataBinding(homeAddress, nameof(homeAddress.Street));

            SetHasHomeAddressEnabledBinding(HomeAddressZipCodeTextBox)
                .SetTextDataBinding(homeAddress, nameof(homeAddress.ZipCode));

            SetHasHomeAddressEnabledBinding(HomeAddressCityTextBox)
                .SetTextDataBinding(homeAddress, nameof(homeAddress.City));

            SetHasHomeAddressEnabledBinding(HomeAddressSubCityTextBox)
                .SetTextDataBinding(homeAddress, nameof(homeAddress.SubCity));

            ChkSendBoxAddress.SetCheckedDataBinding(_address, nameof(_address.HasPostOfficeBox));

            SetHasPostOfficeBoxEnabledBinding(BoxZipCodeTextBox)
                .SetTextDataBinding(box, nameof(box.ZipCode));

            SetHasPostOfficeBoxEnabledBinding(BoxCityTextBox)
                .SetTextDataBinding(box, nameof(box.City));

            SetHasPostOfficeBoxEnabledBinding(BoxNumberTextBox)
                .SetTextDataBinding(box, nameof(box.Number));

            CountryTextBox.SetTextDataBinding(_address, nameof(_address.Country));
            StateTextBox.SetTextDataBinding(_address, nameof(_address.State));

            SetHasHomeAddressEnabledBinding(ApplyGcdDataStreetButton);
            SetHasHomeAddressEnabledBinding(ApplyGcdDataZipCodeButton);
            SetHasHomeAddressEnabledBinding(ApplyGcdDataCityButton);
        }

        private void UpdateGcdButtonVisibility()
        {
            ApplyGcdDataStreetButton.Visible = DisplayGcdButton;
            ApplyGcdDataZipCodeButton.Visible = DisplayGcdButton;
            ApplyGcdDataCityButton.Visible = DisplayGcdButton;
            ApplyGcdDataCountryButton.Visible = DisplayGcdButton;
        }

        private Control SetHasHomeAddressEnabledBinding(Control control)
        {
            control.SetEnabledDataBinding(_address, nameof(_address.HasHomeAddress));
            return control;
        }

        private Control SetHasPostOfficeBoxEnabledBinding(Control control)
        {
            control.SetEnabledDataBinding(_address, nameof(_address.HasPostOfficeBox));
            return control;
        }

        private void ApplyGcdDataStreetButton_Click(object sender, EventArgs e)
        {
            try
            {
                SetStreetFromGcd();
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void ApplyGcdDataZipCodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                SetZipCodeFromGcd();
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void ApplyGcdDataCityButton_Click(object sender, EventArgs e)
        {
            try
            {
                SetCityFromGcd();
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void ApplyGcdDataCountryButton_Click(object sender, EventArgs e)
        {
            try
            {
                SetCountryFromGcd();
            }
            catch (Exception ex)
            {
                ex.ToMessageBox();
            }
        }

        private void SetStreetFromGcd()
        {
            string streetValue = PrimaryBalanceInformation.GetGcdNodeValue(GcdDataValidator.CompanyStreetConcept);
            if (string.IsNullOrEmpty(streetValue))
                return;

            string houseNoValue = PrimaryBalanceInformation.GetGcdNodeValue(GcdDataValidator.CompanyHouseNoConcept);
            if (!string.IsNullOrEmpty(houseNoValue))
                streetValue += $" {houseNoValue}";

            _address.HomeAddress.Street = streetValue;
        }

        private void SetZipCodeFromGcd()
        {
            string value = PrimaryBalanceInformation.GetGcdNodeValue(GcdDataValidator.CompanyZipCodeConcept);
            if (string.IsNullOrEmpty(value))
                return;

            _address.HomeAddress.ZipCode = value;
        }

        private void SetCityFromGcd()
        {
            string value = PrimaryBalanceInformation.GetGcdNodeValue(GcdDataValidator.CompanyCityConcept);
            if (string.IsNullOrEmpty(value))
                return;

            _address.HomeAddress.City = value;
        }

        private void SetCountryFromGcd()
        {
            string value = PrimaryBalanceInformation.GetGcdNodeValue(GcdDataValidator.CompanyCountryConcept);
            if (string.IsNullOrEmpty(value))
                return;

            _address.Country = value;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
