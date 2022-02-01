using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kursach
{
    class Second : Dish
    {
        public string method;

        public Second()
        {
            method = "";
        }

        public Second(string name_, string ingreed_, string kitchen_, string proc_, string method_):
            base(name_, ingreed_, kitchen_, proc_)
        {
            method = method_;
        }

        public string getMethod()
        {
            return method;
        }

        public bool setmethod(string method_)
        {
            if(method_ == "На пару" | method_ == "Жаренное" | method_ == "Запеченное")
            {
                method = method_;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
