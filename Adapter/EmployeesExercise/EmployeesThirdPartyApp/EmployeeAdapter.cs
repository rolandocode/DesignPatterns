using EmployeesThirdPartyApp.TPD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesThirdPartyApp
{
    public class EmployeeAdapter : ITarget
	{
		ThirdPartyBillingSystem Tpbs = new ThirdPartyBillingSystem();
		public void ProcessCompanySalary(string[,] employeesArray)
		{
			string Id = null;
			string Name = null;
			string Designation = null;
			string Salary = null;

			List<Employee> listEmployee = new List<Employee>();

			//DATA SAMPLE
			//{ "101","John","SE","10000"},
   //         { "102","Smith","SE","20000"},
   //         { "103","Dev","SSE","30000"},
   //         { "104","Pam","SE","40000"},
   //         { "105","Sara","SSE","50000"}

			for (int i = 0; i < employeesArray.GetLength(0); i++)
			{
				for (int j = 0; j < employeesArray.GetLength(1); j++)
				{
					if (j == 0)
					{
						Id = employeesArray[i, j];
					}
					else if (j == 1){
						Name = employeesArray[i, j];	
					}
					else if (j == 2)
					{
						Designation = employeesArray[i, j];
					}
					else
                    {
                        Salary = employeesArray[i, j];
                    }
                }
				listEmployee.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
			}

			Console.WriteLine("Adapter converted Array of Employee to List of Employee");
			Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
			Tpbs.ProcessSalary(listEmployee);
			
		}
	}
}
