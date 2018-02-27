using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_System.Bussiness_Layer
{
    class EmployeeQ
    {
        public static List<Employee> DisplayAll()
        {
           return (from e in Program.context.Employees
                        select e).ToList();
        }
        public static List<Employee> filter(Func<Employee, bool> del)
        {
            return Program.context.Employees.Where(del).Select(c => c).ToList();
        }
        
        public static void Add(string nId, string name, string phone, string address, string jobTltle, DateTime hireDate, string gender,double salary,string isActive, string username=null,string password=null)
        {
            
            if (username!=null && password !=null)
            {
                Program.context.Insert_User(
                      nId,
                        name,
                        phone,
                        address,
                        jobTltle,
                        hireDate,
                         gender,
                        username,
                       password,
                       salary,
                       isActive
                        );
                Program.context.SaveChanges();
            }
            else
            {
                Employee emp = new Employee
                {
                    N_Id = nId,
                    Name = name,
                    phone = phone,
                    Address = address,
                    JobTitle = jobTltle,
                    HireDate = hireDate,
                    Gender = gender,
                    Salary=salary,
                    Active = isActive
                };
                Program.context.Employees.Add(emp);
                Program.context.SaveChanges();
            }
            
        }
        public static void Update(int id, string nId, string name, string phone, string address, string jobTltle, DateTime hireDate, string gender,double salary,string isActive)
        {
            Employee emp = Program.context.Employees.Find(id);
            if (emp == null)
            {
                return;
            }
            emp.N_Id = nId;
            emp.Name = name;
            emp.phone = phone;
            emp.Address = address;
            emp.JobTitle = jobTltle;
            emp.HireDate = hireDate;
            emp.Gender = gender;
            emp.Salary = salary;
            emp.Active = isActive;
            Program.context.SaveChanges();
        }
        public static void AccountUpdate(int empId,string username,string password)
        {
            Employee emp = Program.context.Employees.Where(e=>e.Id==empId).FirstOrDefault();
            if (emp == null)
                return;
            var account = (from a in Program.context.Logins
                           where a.Employee_Id == empId
                           select a).FirstOrDefault();
            if(account==null)
            {
                Login login = new Login() {
                    UserName=username,
                    Password=password,
                    Employee_Id=empId
                };
                Program.context.Logins.Add(login);
                Program.context.SaveChanges();
            }
            else
            {
                account.UserName = username;
                account.Password = password;
                Program.context.SaveChanges();
            }

        }
        public static void RemoveAccount(int empId)
        {
            var account = (from a in Program.context.Logins
                           where a.Employee_Id == empId
                           select a).FirstOrDefault();
            if (account == null)
            {
                return;
            }
            Program.context.Logins.Remove(account);
            Program.context.SaveChanges();
        }
        public static bool checkUsername(string username)
        {
            var usernameAccount = (from u in Program.context.Logins
                                   where u.UserName == username
                                   select u).FirstOrDefault();
            if (usernameAccount == null)
                return false;
            else
                return true;
        }
        public static Login IsUser(int empId)
        {
            var user = (from u in Program.context.Logins
                                   where u.Employee_Id == empId
                                   select u).FirstOrDefault();
            return user;
        }
        //check if employee make order before.
        public static bool CheckPreDeal(int empID)
        {
            var order = (from o in Program.context.Orders
                         where o.Emp_Id == empID
                         select o).FirstOrDefault();
            if (order == null)
                return false;
            else
                return true;
        }

    }
   
}

