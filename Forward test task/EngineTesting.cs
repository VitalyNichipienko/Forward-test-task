using System;

namespace Forward_test_task
{
    class EngineTesting
    {
        #region Fields

        private int time = 0; 
        private float currentVelocity;

        private Range<int>[] ranges = new[]
        {
            new Range<int>(0, 75, 0),
            new Range<int>(75, 150, 1),
            new Range<int>(150, 200, 2),
            new Range<int>(200, 250, 3),
            new Range<int>(250, 300, 4),
            new Range<int>(30, Int32.MaxValue, 5)
        };

        #endregion



        #region Methods

        public int EngineOn(EngineSimulation engine)
        {
            engine.TempEngine = engine.TempAmbient;

            TemperatureTracking(engine);

            return time;
        }


        public void TemperatureTracking(EngineSimulation engine)
        {
            while(true)
            {
                if (engine.TempEngine >= engine.T)
                {
                    break;
                }

                time++;

                currentVelocity += engine.a;

                foreach (var currentRange in ranges)
                {
                    if(currentRange.InRange(currentVelocity))
                    {
                        engine.gear = currentRange.value;
                        break;
                    }
                }

                engine.TempEngine += engine.Vh;
                engine.TempEngine -= engine.Vc;
            }
        }

        #endregion
    }
}
