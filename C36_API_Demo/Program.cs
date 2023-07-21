
using Newtonsoft.Json.Linq;

var client = new HttpClient(); // object that allows us to make requests

#region RON SWANSON

//var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes"; //endpoint

//string ronResponse = client.GetStringAsync(ronURL).Result; //send response and receive back as a string

//var ronObject = JArray.Parse(ronResponse); //parse into JArray

//Console.WriteLine(ronObject[0]); //see value

#endregion

#region Chuck Norris

//var chuckURL = "https://api.chucknorris.io/jokes/random"; //endpoint

//string chuckReponse = client.GetStringAsync(chuckURL).Result; //send response

//var chuckObject = JObject.Parse(chuckReponse); //parse into JObject

//Console.WriteLine(chuckObject["value"]);

#endregion

string makeupURL = "https://makeup-api.herokuapp.com/api/v1/products.json?brand=maybelline";

string makeupResponse = client.GetStringAsync(makeupURL).Result;

JArray makeupObject = JArray.Parse(makeupResponse);

Console.WriteLine(makeupObject[0]["description"]);