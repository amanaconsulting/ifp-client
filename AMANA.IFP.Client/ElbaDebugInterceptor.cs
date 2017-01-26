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
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace AMANA.IFP.Client
{
    public class ElbaDebugInterceptor : ElbaProductionInterceptor
    {
        public override object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            return null;
        }
    }

    public class ElbaProductionInterceptor : IClientMessageInspector
    {
        private static string IfpHeaderNamespace = "http://www.ifpev.de/Protocol";

        private static string WsseHeaderNamespace =
            "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd";

        public virtual object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            return null;
        }

        public virtual void AfterReceiveReply(ref Message reply, object correlationState)
        {
        }
    }

    public class ElbaEndpointBehavior : IEndpointBehavior
    {
        public bool IsDebugMode { get; set; }

        public void Validate(ServiceEndpoint endpoint)
        {
        }

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            if (IsDebugMode)
                clientRuntime.MessageInspectors.Add(new ElbaDebugInterceptor());
        }
    }
}