using BookStore.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class API
    {
        static public API shared = new API();

        private HttpClient APIClient;

        private API()
        {
            var httpClientHandler = new HttpClientHandler();

            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };

            APIClient = new HttpClient(httpClientHandler);
            APIClient.BaseAddress = new Uri("http://10.3.35.108:5000/api/");
        }

        public async Task<ObservableCollection<Book>> GetBooks()
        {
            HttpResponseMessage booksResponse = await APIClient.GetAsync("books");
            return JsonConvert.DeserializeObject<ObservableCollection<Book>>(await booksResponse.Content.ReadAsStringAsync());
        }
    }
}
