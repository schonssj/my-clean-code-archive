namespace CleanCode.Names.MethodNames
{
    public class Examples
    {
        /// <summary>
        /// Access methods should be named with verbs which represents their actions.
        /// </summary>
        public int GetAge()
        {
            return 1;
        }
        
        public void SetAge()
        {
            /// Some logic happens here...
        }

        /// <summary>
        /// Boolean methods should be named like a question, where we can use a verb as a prefix followed by purpose of the verification.
        /// </summary>
        public bool HasLegalAge()
        {
            return false;
        }
        
        public bool IsPhysicalPerson()
        {
            return true;
        }
    }
}