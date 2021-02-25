using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace CatLedgerWinForm
{
    class RestApiInterface
    {
        private static readonly string rootURL = "http://ec2-3-36-131-223.ap-northeast-2.compute.amazonaws.com";

        public static string RequestURL(string url, string param = null)
        {
            string response = "";
            StringBuilder RequestURL = new StringBuilder(rootURL);
            RequestURL.Append("/");
            RequestURL.Append(url);
            if (null != param)
            {
                RequestURL.Append("?");
                RequestURL.Append(param);
            }

            try
            {
                WebRequest webRequest = WebRequest.Create(RequestURL.ToString());
                if(null != Program.commonData.authToken)
                    webRequest.Headers.Add("authorization", Program.commonData.authToken);
                HttpWebRequest SignUpRequest = (HttpWebRequest)webRequest;
                SignUpRequest.Method = "GET";

                HttpWebResponse SignUpResponse = (HttpWebResponse)SignUpRequest.GetResponse();
                Stream respGetStream = SignUpResponse.GetResponseStream();
                StreamReader readerGet = new StreamReader(respGetStream, Encoding.UTF8);
                response = readerGet.ReadToEnd();
            }
            catch(Exception ex)
            {
                response = "Error Message : " + ex.ToString();
            }

            return response;
        }
    }
}
