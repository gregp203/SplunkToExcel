using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Web;

namespace WindowsFormsApp1
{
    public class SplunkToExcel
    {
        //public String sid{ get; private set; } = "";
        public String dispatchState { get; private set; } = "";
        public String doneProgress { get; private set; } = "";        

        public SplunkToExcel()
        {
            ServicePointManager.ServerCertificateValidationCallback = MyCertHandler;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            //sid = "";
            dispatchState = "";
            doneProgress = "";
        }

        public async Task<String> CreateSplunkJobAsync(String server,String user, String password,String search, CancellationToken cancelToken = new CancellationToken())
        {
            string returnValue="";
           
            await Task.Run(() =>
            {
                //each item in the list a row and the row is a string array 

                String URL = "https://" + server + ":8089/services/search/jobs";
                //System.Windows.Forms.MessageBox.Show(HttpUtility.UrlEncode("search=search " + search));
                Byte[] byteArray = Encoding.UTF8.GetBytes("search=search " + search.Replace("%", "%25").Replace("+", "%2B"));
                try
                {
                    WebRequest request;
                    request = WebRequest.Create(URL);
                    cancelToken.Register(() => request.Abort());
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.ContentLength = byteArray.Length;
                    NetworkCredential authInfo;
                    authInfo = new NetworkCredential(user, password);
                    request.Credentials = authInfo;
                    Stream dataStream = request.GetRequestStream();
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    dataStream.Close();
                    WebResponse response = request.GetResponse();
                    Stream stream = response.GetResponseStream();
                    XmlTextReader xmlReader = new XmlTextReader(stream);
                    while (xmlReader.Read())
                    {
                        if (xmlReader.IsStartElement())
                        {
                            if (xmlReader.Name == "sid")
                            {
                                returnValue = xmlReader.ReadElementContentAsString();
                            }
                            if (xmlReader.Name == "msg")
                            {
                                throw new Exception(xmlReader.ReadElementContentAsString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            });
            return returnValue;
        }

        public async Task<String[]> GetSplunkJobStatusAsync(
            String server, 
            String user, 
            String password,
            String sid,
            CancellationToken cancelToken = new CancellationToken())
        {
            String[] output = new String[2];
            await Task.Run(() =>
            {
                output[0] = "";
                output[1] = "";
                String URL;
                URL = "https://" + server + ":8089/services/search/jobs/" + sid;
                try
                {
                    WebRequest request;
                    request = WebRequest.Create(URL);
                    cancelToken.Register(() => request.Abort());
                    request.Method = "GET";
                    request.ContentType = "application/x-www-form-urlencoded";
                    //set credentals
                    NetworkCredential authInfo;
                    authInfo = new NetworkCredential(user, password);
                    request.Credentials = authInfo;
                    WebResponse response = request.GetResponse();
                    Stream stream = response.GetResponseStream();
                    XmlTextReader xmlReader = new XmlTextReader(stream);
                    while (xmlReader.Read())
                    {
                        if (xmlReader.IsStartElement())
                        {
                            if (xmlReader.GetAttribute("name") == "dispatchState")
                            {
                                xmlReader.Read();
                                output[0] = xmlReader.Value;
                            }
                            if (xmlReader.GetAttribute("name") == "doneProgress")
                            {
                                xmlReader.Read();
                                output[1] = xmlReader.Value;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            });
            return output;
        }

        public Task<Stream> GetSplunkJobResultsAsync(
            String server, 
            String user, 
            String password ,
            Int32 count, 
            String sid,
            CancellationToken cancelToken = new CancellationToken())
        {
            try
            {
                String URL;
                URL = "https://" + server + ":8089/services/search/jobs/" + sid + "/results/?output_mode=csv&count=" + count.ToString();
                WebRequest request;
                request = WebRequest.Create(URL);
                cancelToken.Register(() => request.Abort());
                request.Method = "GET";
                request.ContentType = "application/x-www-form-urlencoded";
                NetworkCredential authInfo;
                authInfo = new NetworkCredential(user, password);
                request.Credentials = authInfo;
                WebResponse response = request.GetResponse();
                return Task.FromResult<Stream>(response.GetResponseStream());
            }
            catch (Exception ex)
            {

                throw ex;
            }            
        }

        static bool MyCertHandler(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors error)
        {
            // Ignore errors
            return true;
        }
    }

}
