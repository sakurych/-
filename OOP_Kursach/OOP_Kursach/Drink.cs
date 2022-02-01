using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kursach
{
    class Drink: Dish
    {
        public float alc;

        public Drink()
        {
            alc = 0;
        }

        public Drink(string name_, string ingreed_, string kitchen_, string proc_, float alc_):
            base(name_, ingreed_, kitchen_, proc_)
        {
            alc = alc_;
        }

        public float getAlc()
        {
            return alc;
        }

        public void setAlc(float alc_)
        {
            alc = alc_;
        }
    }
}
