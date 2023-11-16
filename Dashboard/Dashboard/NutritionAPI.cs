using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Dashboard
{
    public static class NutritionAPI
    {
        public static string url = "https://api.nal.usda.gov/fdc/v1/";
        public static List<string> searchIngredient(string query)
        {
            string jsonBody = "{" +
                $" \"query\": \"{query}\", " +
                $" \"dataType\": [\"Foundation\"], " +
                $" \"pageSize\": 5 " +
                "}";

            RestClient client = new RestClient(url + "foods/search");
            RestRequest request = new RestRequest(Method.POST);

            request.AddHeader("Content-Type", "application/json");
            request.AddQueryParameter("api_key", GlobalVariable.nutritionAPIKey);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);
                JArray foodsArray = jsonResponse["foods"] as JArray;

                List<string> formattedStrings = new List<string>();
                if (foodsArray != null)
                {
                    foreach (var food in foodsArray)
                    {
                        string description = food["description"].ToString();
                        int fdcId = (int)food["fdcId"];
                        formattedStrings.Add($"{description};{fdcId}");
                    }
                }
                return formattedStrings;
            }
            else
            {
                Console.WriteLine($"API Call failed with status code: {response.StatusCode}, Message: {response.ErrorMessage}");
            }
            return new List<string>();
        }
    }
}
