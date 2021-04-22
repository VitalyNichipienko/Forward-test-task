namespace Forward_test_task
{
    public class Pair<T, U>
    {
        #region Ctor

        public Pair(T firstItem, U secondItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
        }

        #endregion



        #region Properties

        public T FirstItem { get; set; }

        public U SecondItem { get; set; }

        #endregion
    }
}