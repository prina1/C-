// using System;
// using System.Dynamic;
// using System.Security.Cryptography.X509Certificates;

// namespace Employee
// {
//     public class Employee 
//     {
//         public string FirstName;
//         public string LastName;
//         public int EmployeeId;
//         public int salary;



//     }
//     public void DisplayDetails(string FirstName , string LastName , int EmployeeId , int salary)
//     {
//         Console.WriteLine("Employee First Name is :" +FirstName);
//         Console.WriteLine("Employee Last Name is :" +LastName);
//         Console.WriteLine("Employee Id is : " +EmployeeId);
//         Console.WriteLine("Employee Salary is :" +salary);



//     }
//     //derive class Manager
//     class Manager : Employee 
//     {
//         public string Department;
//         public int ManagerId;
//         public int ManagerSalary;
//         public void DisplayDetails(string FirstName , string LastName , int EmployeeId , int salary , string Department , int ManagerId , int ManagerSalary)
//         {
//             Console.WriteLine("Employee First Name is :" +FirstName);
//             Console.WriteLine("Employee Last Name is :" +LastName);
//             Console.WriteLine("Employee Id is : " +EmployeeId);
//             Console.WriteLine("Employee Salary is :" +salary);
//             Console.WriteLine("Employee Department is :" +Department);
//             Console.WriteLine("Employee Manager Id is :" +ManagerId);
//             Console.WriteLine("Employee Manager Salary is :" +ManagerSalary);

//         }


//     }
//     static void Main ()
//     {

//     }
// }