using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        private string _empNo;
        private string _name;

        public Employee()
        {
            _empNo = String.Empty;
            _name = String.Empty;
        }

        // Another Constructor with different Signature
        public Employee(string empNo, string name)
        {
            this._empNo = empNo;
            this._name = name;
        }

        public string Empno
        {
            get
            {
                return _empNo;
            }
            set
            {
                if(value.Length == 0)
                {
                    _empNo = "-1";
                }
                else
                {
                    _empNo = value;
                }
            }
        }

        public string GetEmpInfo()
        {
            return $"emp-no:{_empNo}, name: {_name}";
        }

        public void ShowEmpInfo(bool isShowEmpno)
        {
            string msg = $"name: {_name}";

            if (isShowEmpno)
            {
                msg = $"emp-no: {_empNo}" + msg;
            }
            Console.WriteLine(msg);
        }
    }
}

