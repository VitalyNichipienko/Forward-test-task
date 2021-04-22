using Newtonsoft.Json;
using System;
using System.Globalization;
using System.IO;

namespace Forward_test_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int time;

            string jsonString = File.ReadAllText("Test.config");
            SourceData data = JsonConvert.DeserializeObject<SourceData>(jsonString);

            EngineSimulation engine = new EngineSimulation(data);
            EngineTesting testing = new EngineTesting();                        

            Console.WriteLine("Please, enter the ambient temperature. Input format \"en-Gb\", 00.00°C");

            while(true)
            {
                if (float.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.CreateSpecificCulture("en-GB"), out float result))
                {
                    engine.TempAmbient = result;
                    break;
                }
                else
                {
                    Console.WriteLine("Please, enter the ambient temperature. Input format \"en-Gb\", 00.00°C");
                }
            }

            time = testing.EngineOn(engine);
            Console.WriteLine($"Time = {time}sec");
        }
    }
}
