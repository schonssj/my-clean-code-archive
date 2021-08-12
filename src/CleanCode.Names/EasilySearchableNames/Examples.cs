namespace CleanCode.Names.EasilySearchableNames
{
    public class Examples
    {
        #region Helper properties.
        private const int NUMBER_OF_TASKS = 1;
        private readonly int[] taskEstimate;
        private readonly int realDays;
        private readonly int[] t;
        private int s;
        #endregion

        /// <summary>
        /// A bad practice as this name doesn't favor its own research.
        /// For example, if we search for 'e' in this solution, there'll be so many results that could difficult our search for this variable.
        /// </summary>
        public int e;

        /// <summary>
        /// Here's another bad practice.
        /// If we wanna find a "work days per week" rule, which is representated by 5 in this example, we'll get a big difficulty by this way.
        /// Another point to be aware is that unique-letter names are supposed to be used only inside loops or short functions.
        /// </summary>
        public void SomeFunction()
        {
            for (int j = 0; j < 34; j++)
                s += (t[j] * 4) / 5;
        }

        /// <summary>
        /// Instead of using the magical number 5, we are able to use a constant that represents this value, facilitating an eventual search by it.
        /// Also, instead of use unique-letter names, we can describe their names in a more expressive way.
        /// </summary>
        public void SomeFunctionImproved()
        {
            int realDaysPerIdealDay = 4;
            const int WORK_DAYS_PER_WEEK = 5;
            int sum = 0;
            for (int j = 0; j < NUMBER_OF_TASKS; j++)
            {
                int realTaskDays = taskEstimate[j] * realDaysPerIdealDay;
                int realTaskWeeks = realDays / WORK_DAYS_PER_WEEK;
                sum += realTaskWeeks;
            }
        }
    }
}