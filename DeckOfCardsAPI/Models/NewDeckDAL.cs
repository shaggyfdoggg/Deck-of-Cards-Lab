using System;
using Newtonsoft.Json;
using System.Net;

namespace DeckOfCardsAPI.Models
{
	public class NewDeckDAL
	{
        public static NewDeckModel GetNewDeck()//Adjust here
        {
            //adjust
            //setup
            string url = "https://deckofcardsapi.com/api/deck/ulwht7tlym6x/";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Converting to json
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string json = reader.ReadToEnd();

            //Adjust
            //Convert to C#
            //Install Newtonsoft.json
            NewDeckModel result = JsonConvert.DeserializeObject<NewDeckModel>(json);
            return result;
        }
    }
}

