using eProdaja.WinForm.UI.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using eProdaja.Model;

namespace eProdaja.WinForm.UI
{
    public class APIService
    {
        private string _resource;
        public string _apiUrl = Settings.Default.APIUrl;

        public APIService(string resource)
        {
            _resource = resource;
            
        }

        public async Task<T> GetAll<T>(object queryString = null)
        {
            var query = "";
            if (queryString != null)
            {
                query = await queryString.ToQueryString();
            }

            var list = await $"{_apiUrl}{_resource}?{query}".GetJsonAsync<T>();

            return list;
        }

        public async Task<T> GetById<T>(int id)
        {
            return await $"{_apiUrl}{_resource}/{id}".GetJsonAsync<T>();
        }
    }
}
