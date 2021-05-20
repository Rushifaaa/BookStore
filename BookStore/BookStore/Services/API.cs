using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace BookStore.Services
{
    public class API
    {
        static public API shared = new API();

        private HttpClient APIClient;

        private API()
        {
            APIClient = new HttpClient();
            APIClient.BaseAddress = new Uri("localhost:");
        }
    }
}
