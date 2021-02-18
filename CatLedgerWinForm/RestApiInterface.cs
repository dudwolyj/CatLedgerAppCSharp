using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace CatLedgerWinForm
{
    class RestApiInterface
    {
        private static readonly string rootURL = "http://ec2-52-78-166-177.ap-northeast-2.compute.amazonaws.com";
        public static string RequestURL(string url, string param)
        {
            string response = "";
            StringBuilder RequestURL = new StringBuilder(rootURL);
            RequestURL.Append("/");
            RequestURL.Append(url);
            RequestURL.Append("?");
            RequestURL.Append(param);

            try
            {
                HttpWebRequest SignUpRequest = (HttpWebRequest)WebRequest.Create(RequestURL.ToString());
                SignUpRequest.Method = "GET";

                HttpWebResponse SignUpResponse = (HttpWebResponse)SignUpRequest.GetResponse();
                Stream respGetStream = SignUpResponse.GetResponseStream();
                StreamReader readerGet = new StreamReader(respGetStream, Encoding.UTF8);
                response = readerGet.ReadToEnd();
            }
            catch(Exception e)
            {
                response = "Error Message : " + e.InnerException.Message;
            }

            return response;
        }
    }
}
