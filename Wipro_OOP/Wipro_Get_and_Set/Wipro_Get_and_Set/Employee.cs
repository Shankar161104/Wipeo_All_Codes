using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Get_and_Set
{
    public class Employee
    {
        private int _empID;
        private string _empName;
        private string _empAddress;
        public int EmpID
        {
            get { return _empID; }
            set { _empID = value; }
        }

        public string EmpName
        {
            get { return _empName; }
            set { _empName = value; }
        }

        public string EmpAddress
        {
            get { return _empAddress; }
            set { _empAddress = value; }
        }
    }
}
