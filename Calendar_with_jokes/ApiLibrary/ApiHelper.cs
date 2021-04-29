using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ApiLibrary
{
    /// <summary>
    /// Klasa uzywana do laczenia z Api
    /// </summary>
    public static class ApiHelper
    {
        /// <summary>
        /// Funkcja dostepu do zmiennej ApiClient, czyli zmiennej przechowującej adres
        /// </summary>
        public static HttpClient ApiClient { get; set; } = new HttpClient();
        /// <summary>
        /// Funkcja inicjujaca polaczenie z Api
        /// </summary>
        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
