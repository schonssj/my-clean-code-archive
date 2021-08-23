using System.Collections.Generic;

namespace CleanCode.Names.OneWordPerConcept
{
    public class Examples
    {
        #region Helper properties.
        public Customer customer = new Customer { };
        public SystemAdministrator systemAdministrator = new SystemAdministrator { };
        public Employee employee = new Employee { };
        public SystemAdministratorImproved systemAdministratorImproved = new SystemAdministratorImproved { };
        public EmployeeImproved employeeImproved = new EmployeeImproved { };
        #endregion

        /// <summary>
        /// In this example method, would you be able to easily understand that each method do the same thing – only return all registers of an entity – ?
        /// Probably, you'll need to worry some time verifying the headers of each method to discover it.
        /// </summary>
        public List<object> GetAllUsers()
        {
            var customers = customer.GetAll();
            var systemAdministrators = systemAdministrator.FetchAll(); /// Why not GetAll() too? It means that this method does something different from the one above?
            var employees = employee.RetrieveAll(); /// Same thing as above here.

            return new List<object> { customers, systemAdministrators, employees };
        }
        
        /// <summary>
        /// If we adopt standard nomenclatures to some repetitive actions in our system, we'll certainly optimize the reading experience.
        /// </summary>
        public List<object> GetAllUsersImproved()
        {
            var customers = customer.GetAll();
            var systemAdministrators = systemAdministratorImproved.GetAll();
            var employees = employeeImproved.GetAll();

            return new List<object> { customers, systemAdministrators, employees };
        }
    }

    #region Helper classes.
    public class Customer
    {
        /// <summary>
        /// Returns a list of customers.
        /// </summary>
        /// <returns>All registered customers.</returns>
        public List<Customer> GetAll() => new List<Customer> { };
    }

    public class SystemAdministrator
    {
        /// <summary>
        /// Returns a list of system administrators.
        /// </summary>
        /// <returns>All registered system administrators.</returns>
        public List<SystemAdministrator> FetchAll() => new List<SystemAdministrator> { };
    }

    public class Employee
    {
        /// <summary>
        /// Returns a list of employees.
        /// </summary>
        /// <returns>All registered employees.</returns>
        public List<Employee> RetrieveAll() => new List<Employee> { };
    }
    
    public class SystemAdministratorImproved
    {
        /// <summary>
        /// Returns a list of system administrators.
        /// </summary>
        /// <returns>All registered system administrators.</returns>
        public List<SystemAdministrator> GetAll() => new List<SystemAdministrator> { };
    }

    public class EmployeeImproved
    {
        /// <summary>
        /// Returns a list of employees.
        /// </summary>
        /// <returns>All registered employees.</returns>
        public List<Employee> GetAll() => new List<Employee> { };
    }
    #endregion
}