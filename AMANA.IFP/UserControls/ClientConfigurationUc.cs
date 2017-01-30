using System.Windows.Forms;
using AMANA.IFP.Client;

namespace AMANA.IFP.UserControls
{
    public partial class ClientConfigurationUc : UserControl
    {
        private IfpDataContainer _dataContainer;

        public ClientConfigurationUc()
        {
            InitializeComponent();
        }

        public IfpDataContainer IfpDataContainer
        {
            get { return _dataContainer; }
            set
            {
                _dataContainer = value;
                InitializeControlBindings();

                if (_dataContainer != null)
                    HeaderIdentityUc.HeaderIdentity = _dataContainer.HeaderIdentity;
            }
        }

        private void InitializeControlBindings()
        {
            VersionTextBox.DataBindings.Clear();
            if (_dataContainer == null)
                return;

            VersionTextBox.SetTextDataBinding(_dataContainer, nameof(_dataContainer.Version));
        }
    }
}
