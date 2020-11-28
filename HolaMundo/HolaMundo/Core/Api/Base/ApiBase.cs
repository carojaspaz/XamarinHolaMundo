using HolaMundo.Core.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HolaMundo.Core.Api.Base
{
    public class ApiBase
    {
        public bool StatusNetwork { get; set; } = false;
        internal HttpClient Client { get; set; }

        internal string UrlBase { get; set; }

        public ApiBase(string urlBase)
        {
            Client = new HttpClient();
            Client.Timeout = new System.TimeSpan(0, Constants.ApiConstants.SetTimeOut, 0);            
            UrlBase = urlBase;
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                StatusNetwork = true;
            }
        }

        public string GetUrlApi(string method)
        {
            return $"{UrlBase}{method}";
        }

        public string PostPasswordResetUrlApi(string mail)
        {
            return $"{UrlBase}users/{mail}/requestPasswordReset";
        }

        public HttpContent GetContent(object model)
        {
            var json = JsonConvert.SerializeObject(model);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            return content;
        }

        public HttpContent GetContent()
        {
            HttpContent content = new StringContent(string.Empty);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            content.Headers.Add("Autorization", Settings.SecurityToken);
            return content;
        }

        public void SetToken()
        {
            Client.DefaultRequestHeaders.Remove("Authorization");
            Client.DefaultRequestHeaders.Add("Authorization", Settings.SecurityToken);
        }        
    }
}
