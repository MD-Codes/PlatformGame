using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace PlatformGame
{
    internal class JsonData : ScoreData
    {
        public static List<ScoreData> incoming = new List<ScoreData>();
        public static string filePath = "C:\\Users\\matda\\Desktop\\Projects_c#\\PlatformGame\\PlatformGame\\JsonData.json";

        public void AddScore(int score)
        {
            ScoreData newScore = new ScoreData
            {
                Score = score
            };
            incoming.Add(newScore);
            AddScoreToFile();
        }
        public void AddScoreToFile()
        {   
            string outcoming = JsonConvert.SerializeObject(incoming);
            StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine(outcoming);
            sw.Close();
        }
        public void ReadMyFile()
        {
            StreamReader r = new StreamReader(filePath);
            string jsonfile = r.ReadToEnd();
            if (jsonfile != "")
            {
                incoming = JsonConvert.DeserializeObject<List<ScoreData>>(jsonfile);
            }
            r.Close();
        }        
        public int ReturnValue(int index)
        {
            try
            {
            incoming.Sort((x, y) => y.Score.CompareTo(x.Score));
            return incoming[index].Score;

            }
            catch (Exception ex)
            {
                return 0;
            }
        }

    }
}
