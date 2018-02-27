using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_System.Bussiness_Layer
{
    class EmpAttendanceQ
    {
        public static List<object> DispalyAll()
        {
            List<object> list = new List<object>();
            var emps = (from e in Program.context.Employees
                        select e).ToList();
            foreach (var item in emps)
            {
                var empAttend = (from a in Program.context.Employee_Attendance
                                 where a.Employee_Id == item.Id &&
                                 DbFunctions.TruncateTime(a.Date) == DbFunctions.TruncateTime(DateTime.Now)
                                 select a).FirstOrDefault();

                if (empAttend == null)
                {
                    list.Add(new { Id = item.Id, National_Id = item.N_Id, Name = item.Name, Time_In = "", Time_Out = "" });
                    Employee_Attendance empAttendance = new Employee_Attendance()
                    {
                        Date = DateTime.Now.Date,
                        Employee_Id = item.Id,
                    };
                    Program.context.Employee_Attendance.Add(empAttendance);
                    Program.context.SaveChanges();

                }
                else
                {
                    list.Add(new { Id = item.Id, National_Id = item.N_Id, Name = item.Name, Time_In = empAttend.ArrivedTime.ToString(), Time_Out = empAttend.LeftTime.ToString() });
                }

            }
            return list;
        }
       
        public static void TimeRegisteration(TimeSpan t,int id, string type)
        {
            var empA = (from e in Program.context.Employee_Attendance
                        where e.Employee_Id == id &&
                         DbFunctions.TruncateTime(e.Date) == DbFunctions.TruncateTime(DateTime.Now)
                        select e).FirstOrDefault();
            if (type == "login")
                empA.ArrivedTime = new TimeSpan(t.Hours, t.Minutes, t.Seconds);
            else
                empA.LeftTime = new TimeSpan(t.Hours, t.Minutes, t.Seconds);
            Program.context.SaveChanges();
        }
       
        public static string EmpName(int id)
        {
            Employee emp = Program.context.Employees.Find(id);
            return emp.Name;
        }
    }
}
