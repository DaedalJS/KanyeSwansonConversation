using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace RonyeWestsonConversation
{
    public class QuoteGrabber
    {

        public static string KanyeQuote()
        {
            var client = new HttpClient();
            var kanyeResponse = client.GetStringAsync("https://api.kanye.rest").Result;
            string kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            return kanyeQuote;
        }
        
        
        public static string SwansonQuote()
        {
            var client = new HttpClient();
            var swansonResponse = client.GetStringAsync("https://ron-swanson-quotes.herokuapp.com/v2/quotes").Result;
            var swansonQuote = JArray.Parse(swansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            return swansonQuote;

        }






    }
}
