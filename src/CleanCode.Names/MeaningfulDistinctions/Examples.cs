namespace CleanCode.Names.MeaningfulDistinctions
{
    public class Examples
    {
        /// <summary>
        /// A bad practice as it's redundant.
        /// </summary>
        public string NameVariable;
        public string NameString;
        
        /// <summary>
        /// Some bad practices. We aren't able to understand their differences easily.
        /// </summary>
        public double MoneyAmount;
        public double Money;

        public object CustomerInfo;
        public object Customer;
        
        public string TheMessage;
        public string Message;
        
        public object AccountData;
        public object Account;
    }

    /// <summary>
    /// Some bad practices. Are you able to understand what is the difference between these classes only by their names?
    /// </summary>
    public class Product { }
    public class ProductInfo { }
    public class ProductData { }
    
    /// <summary>
    /// Another bad practices. How do we'll know which one is better to have a payment history of a customer?
    /// </summary>
    public class Customer { }
    public class CustomerObject { }

    #region Helper classes.
    public class Account { }
    public class AccountInfo { }
    #endregion

    public class CustomerAccount
    {
        /// <summary>
        /// Some bad practices. Which one do we should call to get data of an active account?
        /// </summary>
        public Account GetActiveAccount()
        {
            // Some database logic happens here...
            return new Account();
        }
        public AccountInfo GetActiveAccountInfo()
        {
            // Some database logic happens here...
            return new AccountInfo();
        }
    }
}