using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiLibrary
{
    /// <summary>
    /// Klasa odpowiedzialna za laczenie z JokeAPI
    /// </summary>
    public class JokeProcessor
    {
        /// <summary>
        /// Funkcja odpowiedzialna za polaczenie z API i zwroceniem zartu
        /// </summary>
        /// <returns></returns>
        public static async Task<JokeModel> LoadJoke()
        {
            string url = "https://v2.jokeapi.dev/joke/Any";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JokeModel joke = await response.Content.ReadAsAsync<JokeModel>();
                    if (joke.error == "true")
                        throw new Exception("Internal Server Error");
                    else return joke;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
             
        }
    }
}
