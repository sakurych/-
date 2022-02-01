using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Kursach
{
    class Dish 
    {
        private string name;
        private string ingreed;
        private string kitchen;
        private string proc;

        public Dish()
        {
            name = "";
            ingreed = "";
            kitchen = "";
            proc = "";
        }

        public Dish(string name_, string ingreed_, string kitchen_, string proc_)
        {
            name = name_;
            ingreed = ingreed_;
            kitchen = kitchen_;
            proc = proc_;
        }

        public string getName()
        {
            return name;
        }

        public string getIngreed()
        {
            return ingreed;
        }

        public string getKitchen()
        {
            return kitchen;
        }

        public string getProc()
        {
            return proc;
        }

        public void setName(string name_)
        {
            name = name_;
        }

        public void setIngreed(string ingreed_)
        {
            ingreed = ingreed_;
        }

        public void setkitchen(string kitchen_)
        {
            kitchen = kitchen_;
        }

        public void setProc(string proc_)
        {
            proc = proc_;
        }
    }
}
