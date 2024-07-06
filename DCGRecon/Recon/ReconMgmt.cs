using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.Win32;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Xml.Linq;
using System.Security.Policy;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Reflection.Metadata;

namespace DCGRecon.Recon
{
    public static class ReconMgmt
    {
        public static string GenerateNewAppKey()
        {
            string newAppKey = DateTime.UtcNow.ToString("yyMMddHHmmssfffff");
            Random random = new Random(DateTime.Now.Millisecond);
            char ch;
            for (; newAppKey.Length < 25;)
            {
                ch = (char)(65U + (uint)random.Next(0, 26));
                newAppKey += ch;
            }
            return newAppKey;
        }

        public static int QueryReceiver(string strSoapAction, StringBuilder aStringBuilder, string ipaddress)
        {
            HttpWebRequest httpWebRequest;
            try
            {
                httpWebRequest = (HttpWebRequest)WebRequest.Create("http://" + ipaddress + ":49200/upnp/control/EchoSTB2");
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Status.ToString(), "WebRequest.Create : WebException");
                return -1;
            }
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "text/xml; charset=\"utf-8\"";
            httpWebRequest.Headers.Add("SOAPACTION", "\"urn:schemas-echostar-com:service:EchoSTB:2#" + strSoapAction + "\"");
            httpWebRequest.UserAgent = "Linux/2.6.33.6-147.fc13.i686.PAE, UPnP/1.0, Portable SDK for UPnP devices/1.6.6";
            httpWebRequest.Timeout = 3000;
            Stream requestStream;
            try
            {
                requestStream = httpWebRequest.GetRequestStream();
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Status.ToString(), "GetRequestStream : WebException");
                return -2;
            }
            StreamWriter streamWriter = new StreamWriter(requestStream);
            streamWriter.Write((object)aStringBuilder);
            streamWriter.Close();
            httpWebRequest.Timeout = 3000;
            WebResponse response;
            try
            {
                response = httpWebRequest.GetResponse();
            }
            catch (ProtocolViolationException ex)
            {
                MessageBox.Show(ex.Message, "GetResponse : ProtocolViolationException");
                return -3;
            }
            catch (WebException ex)
            {
                if (strSoapAction == "SetChannel" && ex.Status == WebExceptionStatus.ProtocolError)
                {
                    MessageBox.Show("Failed to set channel.  Channel does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return -4;
                }
                if (strSoapAction == "SetChannel" && ex.Status == WebExceptionStatus.Timeout)
                {
                    MessageBox.Show("Failed to set channel.  Most likely reason is not currently authorized for requested channel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return -4;
                }
                MessageBox.Show(ex.Status.ToString() + "\r" + ex.Message, "GetResponse : WebException");
                return -5;
            }
            Stream responseStream = response.GetResponseStream();
            Encoding encoding = Encoding.GetEncoding("utf-8");
            StreamReader streamReader = new StreamReader(responseStream, encoding);
            char[] buffer = new char[256];
            string str = "";
            for (int length = streamReader.Read(buffer, 0, 256); length > 0; length = streamReader.Read(buffer, 0, 256))
                str += new string(buffer, 0, length);
            Console.WriteLine("");
            streamReader.Close();
            responseStream.Close();
            response.Close();
            MessageBox.Show(str);
            return 0;
        }
    }
}
