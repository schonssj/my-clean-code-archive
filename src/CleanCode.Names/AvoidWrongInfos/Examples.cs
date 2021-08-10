using System;
using System.Collections.Generic;

namespace CleanCode.Names.AvoidWrongInfos
{
    public class Examples
    {
        /// <summary>
        /// A bad practice. Even if you would work in an hypotenuse context, this approach has a chance to create some mental confusion.
        /// </summary>
        public double HP;

        /// <summary>
        /// Another bad practice. The "List" word means something specific when talking about software dev. It has a chance to create some mental confusion.
        /// </summary>
        public Array AccountsList;

        /// <summary>
        /// Still a bad practice as it's redundant.
        /// </summary>
        public List<object> AnotherAccountsList;

        /// <summary>
        /// Now it's fine.
        /// </summary>
        public List<object> Accounts;
        public List<object> AccountGroup;
        public List<object> BunchOfAccounts;
    }

    /// <summary>
    /// Preferentially avoid using identical names as this destroys fast reading.
    /// </summary>
    public class XYZControllerForEfficientHandlingOfStrings { }
    public class XYZControllerForEfficientStorageOfStrings { }
}