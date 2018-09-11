using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace AMANA.IFP.Data
{
    public class CustomTextMessageBindingElementExtension : BindingElementExtensionElement
    {       

        //Called by the WCF to create the binding element
        public CustomTextMessageBindingElementExtension()
        {
        }

        protected override BindingElement CreateBindingElement()
        {
            var bindingElement = new CustomTextMessageBindingElement("utf-8", "application/soap+xml");
            ApplyConfiguration(bindingElement);
            return bindingElement;
        }

        public override Type BindingElementType
        {
            get
            {
                return typeof(CustomTextMessageBindingElementExtension);  
            }
        }
    }

}
