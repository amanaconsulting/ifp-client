using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AMANA.IFP.Data
{
    public class CustomTextMessageEncoder : System.ServiceModel.Channels.MessageEncoder
    {
        private CustomTextMessageEncoderFactory _factory;
        private XmlWriterSettings _writerSettings;
        private string _contentType;

        public CustomTextMessageEncoder(CustomTextMessageEncoderFactory factory)
        {
            _factory = factory;

            _writerSettings = new XmlWriterSettings();
            _writerSettings.Encoding = Encoding.GetEncoding(factory.CharSet);
            _contentType = string.Format("{0}; charset={1}",
                _factory.MediaType, _writerSettings.Encoding.WebName);
        }

        public override string ContentType
        {
            get
            {
                return _contentType;
            }
        }

        public override string MediaType
        {
            get
            {
                return _factory.MediaType;
            }
        }

        public override MessageVersion MessageVersion
        {
            get
            {
                return _factory.MessageVersion;
            }
        }

        public override bool IsContentTypeSupported(string contentType)
        {
            return true;
        }

        public override Message ReadMessage(Stream stream, int maxSizeOfHeaders, string contentType)
        {
            stream.Position = 0;
            XmlReader reader = XmlReader.Create(stream);
   
            XmlDocument xd1 = new XmlDocument();
            xd1.Load(reader);            

            string securityXPath = @"//wsse:Security";

            XmlNamespaceManager ns = new XmlNamespaceManager(xd1.NameTable);
            ns.AddNamespace("wsse", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");

            var securityNode = xd1.SelectSingleNode(securityXPath, ns);

            securityNode?.ParentNode?.RemoveChild(securityNode);

            MemoryStream xmlStream = new MemoryStream();
            xd1.Save(xmlStream);

            xmlStream.Position = 0;
            var reader2 = XmlReader.Create(xmlStream);

            return Message.CreateMessage(reader2, maxSizeOfHeaders, MessageVersion);
        }

        public override Message ReadMessage(ArraySegment<byte> buffer, BufferManager bufferManager, string contentType)
        {
            byte[] msgContents = new byte[buffer.Count];
            Array.Copy(buffer.Array, buffer.Offset, msgContents, 0, msgContents.Length);
            bufferManager.ReturnBuffer(buffer.Array);

            MemoryStream stream = new MemoryStream(msgContents);
            return ReadMessage(stream, int.MaxValue);
        }

        public override void WriteMessage(Message message, Stream stream)
        {
            using (XmlWriter writer = XmlWriter.Create(stream, _writerSettings))
            {
                message.WriteMessage(writer);
            }
        }

        public override ArraySegment<byte> WriteMessage(Message message, int maxMessageSize, BufferManager bufferManager, int messageOffset)
        {
            ArraySegment<byte> messageBuffer;
            byte[] writeBuffer = null;

            int messageLength;
            using (MemoryStream stream = new MemoryStream())
            {
                using (XmlWriter writer = XmlWriter.Create(stream, _writerSettings))
                {
                    message.WriteMessage(writer);
                }

                // TryGetBuffer is the preferred path but requires 4.6
                //stream.TryGetBuffer(out messageBuffer);
                writeBuffer = stream.ToArray();
                messageBuffer = new ArraySegment<byte>(writeBuffer);

                messageLength = (int)stream.Position;
            }

            int totalLength = messageLength + messageOffset;
            byte[] totalBytes = bufferManager.TakeBuffer(totalLength);
            Array.Copy(messageBuffer.Array, 0, totalBytes, messageOffset, messageLength);

            ArraySegment<byte> byteArray = new ArraySegment<byte>(totalBytes, messageOffset, messageLength);
            return byteArray;
        }
    }
}