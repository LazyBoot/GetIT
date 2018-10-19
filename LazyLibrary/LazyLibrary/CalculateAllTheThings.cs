using System;
using System.IO;
using System.Net;
using System.Net.Http;

namespace LazyLibrary
{
    public class CalculateAllTheThings
    {
        private static readonly HttpClient Client = new HttpClient();

        private static readonly string _appid = System.Text.Encoding.UTF8.GetString(Resource.appid);

        public static string Calculate(string input)
        {
            var baseUrl = @"http://api.wolframalpha.com/v1/result?appid=";
            var url = $"{baseUrl}{_appid}&i={WebUtility.UrlEncode(input)}";

            var request = (HttpWebRequest) WebRequest.Create(url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
