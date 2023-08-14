using System;
using Newtonsoft.Json;
using System.Net;

namespace DeckOfCardsAPI.Models
{
	public class ReshuffleDeckDAL
	{
        public static ReshuffleDeckModel Reshuffle()//Adjust here
        {
            //adjust
            //setup
            string apiKey = Secret.apiKey;
            string url = $"https://deckofcardsapi.com/api/deck/{apiKey}/shuffle/";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Converting to json
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string json = reader.ReadToEnd();

            //Adjust
            //Convert to C#
            //Install Newtonsoft.json
            ReshuffleDeckModel result = JsonConvert.DeserializeObject<ReshuffleDeckModel>(json);
            return result;
        }
    }
}

