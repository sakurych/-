using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kursach
{
    class Dessert: Dish
    {
        public int kall;

        public Dessert()
        {
            kall = 0;
        }

        public Dessert(string name_, string ingreed_, string kitchen_, string proc_, int kall_):
            base(name_, ingreed_, kitchen_, proc_)
        {
            kall = kall_;
        }

        public int getKall()
        {
            return kall;
        }

        public void setKall(int kall_)
        {
            kall = kall_;
        }
    }
}
