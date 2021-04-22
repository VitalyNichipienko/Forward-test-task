using System;

namespace Forward_test_task
{
    [Serializable]
    public class SourceData
    {
        public float I;
        public Pair<float, float>[] MV;
        public float T;
        public float Hm;
        public float Hv;
        public float C;
    }
}
