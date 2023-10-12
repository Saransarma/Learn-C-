using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Manage
{
    class Employee
    {
        String empName;
        Int32 empId;
        Int32 empAge;

        void setData(String name,Int32 id,Int32 age)
        {
            empName = name;
            empId = id;
            empAge = age;
        }

        string GetData()
        {
            return "Employee Name :" + empName + "\nEmployee ID :" + empId + "\nEmployee Age :" + empAge;
        }
    }
}
