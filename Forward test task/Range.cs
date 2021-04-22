namespace Forward_test_task
{
    class Range<T>
    {
        #region Fields

        public readonly float from;
        public readonly float to;
        public readonly T value;

        #endregion



        #region Ctor

        public Range(float from, float to, T value)
        {
            this.from = from;
            this.to = to;
            this.value = value;
        }

        #endregion



        #region Methods

        public bool InRange(float source) =>
            source >= from && source < to;

        #endregion
    }
}
