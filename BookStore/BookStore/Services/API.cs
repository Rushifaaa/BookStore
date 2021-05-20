using BookStore.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            APIClient = new HttpClient();
            APIClient.BaseAddress = new Uri("localhost:5000");
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            HttpResponseMessage booksResponse = await APIClient.GetAsync("/api/books");
            return JsonConvert.DeserializeObject<IEnumerable<Book>>(await booksResponse.Content.ReadAsStringAsync());
        }
    }
}
