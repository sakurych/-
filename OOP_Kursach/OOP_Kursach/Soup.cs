using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kursach
{
    class Soup : Dish
    {
        private string tempr;
        private string veg;

        public Soup()
        {
            tempr = "";
            veg = "";
        }

        public Soup(string name_, string ingreed_, string kitchen_, string proc_, string tempr_, string veg_):
            base(name_, ingreed_, kitchen_, proc_)
        {
            tempr = tempr_;
            veg = veg_;
        }

        public string getTempr() 
        {
            return tempr;
        }

        public string getVeg()
        {
            return veg;
        }

         public bool setTempr(string tempr_)
        {
            if (tempr_ == "Горячий" | tempr_ == "Холодный")
            {
                tempr = tempr_;
                return true;
            }    
            else
            {
                return false;
            }
        }

        public bool setVeg(string veg_)
        {
            if(veg_ == "Вегетерианский" | veg_ == "С мясом")
            {
                veg = veg_;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
