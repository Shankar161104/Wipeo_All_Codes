using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Collection_eg_4
{
    internal class Principal
    {
        public int PrincipalID { get; set; }
        public string PrincipalName { get; set; }

        public List<Student> lststudent { get; set; }
        public List<Teacher> lstteacher { get; set; }
    }
}
