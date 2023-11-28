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
    internal class Calendar
    {
        public static CalendarDay selectedDay;
        public static List<CalendarDay> days;
        public static async Task getCalendarDays()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(Global.apiUrl + "/calendar");
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();

                getCalendarDaysResponse data = JsonConvert.DeserializeObject<getCalendarDaysResponse>(json);
                days = data.days;
            }
        }
        public static async Task selectExerciseGroupForTheDay(ExercisesGroup exercisesGroup, CalendarDay day)
        {
            using (HttpClient client = new HttpClient())
            {
                var body = new { exercisesGroupId = exercisesGroup._id, dayId = day._id };
                string json = JsonConvert.SerializeObject(body);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PostAsync(Global.apiUrl + "/calendar/select-group", content);
            }
        }
    }

    class getCalendarDaysResponse 
    {
        public string message;
        public List<CalendarDay> days;
    }
    class CalendarDay
    {
        public string _id;
        public string dayName;
        public int dayIndex;
        public ExercisesGroup exercisesGroup;
    }
}
