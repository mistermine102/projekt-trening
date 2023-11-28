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
    internal class ExercisesGroup
    {
        public string _id;
        public string name;
        public List<ExercisesGroupItem> exercises;
        public static List<ExercisesGroup> ExercisesGroups = new List<ExercisesGroup>();
        public static async Task getExcercisesGroups()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(Global.apiUrl + "/exercise/group");
                    response.EnsureSuccessStatusCode();
                    string json = await response.Content.ReadAsStringAsync();

                    GetExcersisesGroupsResponse data = JsonConvert.DeserializeObject<GetExcersisesGroupsResponse>(json);

                    ExercisesGroups = data.exercisesGroups;
                }
            }
            catch (Exception ex)
            {
                //failed to read the exercises
            }
        }
        public static async Task createExercisesGroup(ExercisesGroup newExercisesGroup)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(newExercisesGroup);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    await client.PostAsync(Global.apiUrl + "/exercise/group", content);
                }
            }
            catch (Exception ex)
            {

            }
        }
        public static async Task deleteExercisesGroup(string exercisesGroupId)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var body = new { exercisesGroupId = exercisesGroupId };

                    string json = JsonConvert.SerializeObject(body);

                    HttpRequestMessage request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Delete,
                        RequestUri = new Uri(Global.apiUrl + "/exercise/group"),
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

    }

    class GetExcersisesGroupsResponse
    {
        public string message;
        public List<ExercisesGroup> exercisesGroups;
    }
}
