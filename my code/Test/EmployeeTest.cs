using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using my_code.Pages;
using my_code.Utilities;
using NUnit.Framework;

namespace my_code.Test
{
    [TestFixture]
    [Parallelizable]
    internal class EmployeeTest : CommonDriver
    {
         
        [Test, Order(1), Description("Check if user is able to create an employee with valid data")]
        public void CreateEmployee_Test()
        {
            // Home page object intialzation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            // TM page object intialzation and definition
            EmployeePage employPageObj = new EmployeePage();
            employPageObj.CreateEmployee(driver);
        }

        [Test, Order(2), Description("Check if user is able to edit an employee with valid data")]
        public void EditEmployee_Test()
        {
            // Home page object intialzation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            // Edit TM
            EmployeePage employPageObj = new EmployeePage();
            employPageObj.EditEmployee(driver);
        }

        [Test, Order(3), Description("Check if user is able to delete an existing employee")]
        public void DeleteEmployee_Test()
        {
            // Home page object intialzation and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            // Delete TM
            EmployeePage employPageObj = new EmployeePage();
            employPageObj.DeleteEmployee(driver);
        }
    }
}
    

