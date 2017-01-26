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
using AMANA.IFP.Data.Elba;

namespace AMANA.IFP.Common
{
    public class RequestResult
    {
        public bool IsLocalResult { get; }
        public bool RequestProcessed { get; set; }
        public List<RequestResultMessage> ResultMessages { get; }
        public DateTime CreationTime { get; }

        public RequestResult(bool isLocalResult = false)
        {
            IsLocalResult = isLocalResult;
            ResultMessages = new List<RequestResultMessage>();
        }

        public RequestResult(List<RequestResultMessage> messages, bool isLocalResult = false)
        {
            IsLocalResult = isLocalResult;
            ResultMessages = messages;
        }

        public RequestResult(ns3QuittungTyp quittung, bool isLocalResult = false)
            : this (isLocalResult)
        {
            RequestProcessed = quittung.AnfrageBearbeitet;
            foreach (ns3QuittungTypHinweis hinweis in quittung.Hinweise)
                ResultMessages.Add(new RequestResultMessage(hinweis));

            CreationTime = DateTime.Now;
        }

        public string CreationTimeAsDisplayString => $"{CreationTime.ToLongDateString()}, {CreationTime.ToLongTimeString()}";

        public string IsLocalResultAsDisplayString
        {
            get
            {
                string wasSentString = IsLocalResult ? " nicht" : string.Empty;
                return $"Die Daten wurden{wasSentString} versendet.";
            }
        }
    }

    public class RequestResultMessage
    {
        public string Message { get; }
        public string MessageId { get; }

        public RequestResultMessage(ns3QuittungTypHinweis hinweis)
        {
            Message = hinweis.Beschreibung;
            MessageId = hinweis.ID;
        }

        public RequestResultMessage(string message, string messageId)
        {
            Message = message;
            MessageId = messageId;
        }
    }
}