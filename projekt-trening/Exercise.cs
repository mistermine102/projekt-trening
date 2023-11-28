using Newtonsoft.Json;
using projekt_trening.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace projekt_trening
{
    internal class Exercise
    {
        public string _id;
        public string name;
        public string description;
        public string imgUrl;
        public int difficulty;
        public List<string> targetMuscles;

        public static List<Exercise> exercises = new List<Exercise>();
        public static async Task deleteExercise(string exerciseId)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var body = new { exerciseId = exerciseId };

                    string json = JsonConvert.SerializeObject(body);

                    HttpRequestMessage request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Delete,
                        RequestUri = new Uri(Global.apiUrl + "/exercise"),
                        Content = new StringContent(json, Encoding.UTF8, "application/json")

                    };
                    HttpResponseMessage response = await client.SendAsync(request);
                    response.EnsureSuccessStatusCode();
                }
            }
            catch (Exception ex)
            {

            }
        }
        public static async Task getExercises()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(Global.apiUrl + "/exercise");
                    response.EnsureSuccessStatusCode();
                    string json = await response.Content.ReadAsStringAsync();

                    GetExerciseResponse data = JsonConvert.DeserializeObject<GetExerciseResponse>(json);

                    exercises = data.exercises;
                }
            }
            catch (Exception ex)
            {
                //failed to read the exercises
            }
        }
        public static async Task createExercise(Exercise newExercise)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(newExercise);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    await client.PostAsync(Global.apiUrl + "/exercise", content);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
    class GetExerciseResponse
    {
        public string message;
        public List<Exercise> exercises;
    }
}
