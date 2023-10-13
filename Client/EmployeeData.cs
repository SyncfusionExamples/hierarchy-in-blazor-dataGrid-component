using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchyGridSample
{
    public class EmployeeData
    {
        public EmployeeData()
        {

        }
        public EmployeeData(int EmployeeID, string FirstName, string LastName, string Title, DateTime BirthDate, DateTime HireDate, int ReportsTo, string Address, string PostalCode, string Phone, string City, string Country, string mail, bool Discontinued)
        {
            this.EmployeeID = EmployeeID;
            this.FirstName = FirstName;
            this.Title = Title;
            this.City = City;
            this.Country = Country;
        }
        public int? EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public static List<EmployeeData> GetAllRecords()
        {
            List<EmployeeData> Emp = new List<EmployeeData>();
            Emp.Add(new EmployeeData() { EmployeeID = 1, FirstName = "Nancy", Title = "Sales Representative", City = "Texas", Country = "USA" });
            Emp.Add(new EmployeeData() { EmployeeID = 2, FirstName = "Andrew", Title = "Vice President", City = "London", Country = "UK" });
            Emp.Add(new EmployeeData() { EmployeeID = 3, FirstName = "Janet", Title = "Sales", City = "London", Country = "UK" });
            Emp.Add(new EmployeeData() { EmployeeID = 4, FirstName = "Margaret", Title = "Sales Manager", City = "London", Country = "UK" });
            Emp.Add(new EmployeeData() { EmployeeID = 5, FirstName = "Steven", Title = "Inside Sales Coordinator", City = "Vegas", Country = "USA" });
            Emp.Add(new EmployeeData() { EmployeeID = 6, FirstName = "Smith", Title = "HR Manager", City = "Dubai", Country = "UAE" });
            Emp.Add(new EmployeeData() { EmployeeID = 7, FirstName = "Steven", Title = "Inside Sales Coordinator", City = "Paris", Country = "France" });
            Emp.Add(new EmployeeData() { EmployeeID = 8, FirstName = "Smith", Title = "HR Manager", City = "Mumbai", Country = "India" });
            Emp.Add(new EmployeeData() { EmployeeID = 9, FirstName = "Smith", Title = "HR Manager", City = "Chennai", Country = "India" });
            return Emp;
        }
    }
}
