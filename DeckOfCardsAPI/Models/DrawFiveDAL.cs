using System;
using Newtonsoft.Json;
using System.Net;

namespace DeckOfCardsAPI.Models
{
	public class DrawFiveDAL
	{
        public static DrawFiveModel UserDrawFive()//Adjust here
        {
            //adjust
            //setup
            string apiKey = "ulwht7tlym6x";
            string url = $"https://deckofcardsapi.com/api/deck/{apiKey}/draw/?count=5";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Converting to json
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string json = reader.ReadToEnd();

            //Adjust
            //Convert to C#
            //Install Newtonsoft.json
            DrawFiveModel result = JsonConvert.DeserializeObject<DrawFiveModel>(json);
            return result;
        }
    }
}

