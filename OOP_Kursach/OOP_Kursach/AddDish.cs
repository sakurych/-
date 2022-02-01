using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_Kursach.DB_commands;

namespace OOP_Kursach
{
    public partial class AddDish : Form
    {
        public AddDish()
        {
            InitializeComponent();
        }

        private void AddDish_Load(object sender, EventArgs e)
        {
            Tempr_Label.Visible = false;
            Tempr_CB.Visible = false;
            Veg_CB.Visible = false;
            Veg_Label.Visible = false;

            Method_CB.Visible = false;
            Method_Label.Visible = false;

            Kall_Label.Visible = false;
            Kall_TB.Visible = false;

            Alc_Label.Visible = false;
            Alc_TB.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Tempr_Label.Visible = false;
            Tempr_CB.Visible = false;
            Veg_CB.Visible = false;
            Veg_Label.Visible = false;

            Method_CB.Visible = true;
            Method_Label.Visible = true;

            Kall_Label.Visible = false;
            Kall_TB.Visible = false;

            Alc_Label.Visible = false;
            Alc_TB.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Soup_RB_CheckedChanged(object sender, EventArgs e)
        {
            Tempr_Label.Visible = true;
            Tempr_CB.Visible = true;
            Veg_CB.Visible = true;
            Veg_Label.Visible = true;

            Method_CB.Visible = false;
            Method_Label.Visible = false;

            Kall_Label.Visible = false;
            Kall_TB.Visible = false;

            Alc_Label.Visible = false;
            Alc_TB.Visible = false;
        }

        private void Dessert_RB_CheckedChanged(object sender, EventArgs e)
        {
            Tempr_Label.Visible = false;
            Tempr_CB.Visible = false;
            Veg_CB.Visible = false;
            Veg_Label.Visible = false;

            Method_CB.Visible = false;
            Method_Label.Visible = false;

            Kall_Label.Visible = true;
            Kall_TB.Visible = true;

            Alc_Label.Visible = false;
            Alc_TB.Visible = false;
        }

        private void Drink_RB_CheckedChanged(object sender, EventArgs e)
        {
            Tempr_Label.Visible = false;
            Tempr_CB.Visible = false;
            Veg_CB.Visible = false;
            Veg_Label.Visible = false;

            Method_CB.Visible = false;
            Method_Label.Visible = false;

            Kall_Label.Visible = false;
            Kall_TB.Visible = false;

            Alc_Label.Visible = true;
            Alc_TB.Visible = true;
        }

        private void AddDish_Buttton_Click(object sender, EventArgs e)
        {
            if(Name_TB.TextLength == 0 || Kitchen_TB.TextLength == 0 || Ingreeds_TB.TextLength == 0 || Proc_TB.TextLength == 0 ||
                (Soup_RB.Checked || Vtoroe_RB.Checked || Drink_RB.Checked || Dessert_RB.Checked) == false)
            {
                MessageBox.Show("Вы заполнили не все данные!!!");
            }
            else
            {
                string name = Name_TB.Text;
                string kitchen = Kitchen_TB.Text;
                string ingreed = Ingreeds_TB.Text;
                string proc = Proc_TB.Text;

                if(Soup_RB.Checked)
                {
                  if (Tempr_CB.Text == "")
                    {
                        MessageBox.Show("Вы заполнили не все данные или заполнили их неверно");
                    }
                  else
                    {
                        if (Veg_CB.Text == "" )
                        {
                            MessageBox.Show("Вы заполнили не все данные или заполнили их неверно");
                        }
                        else
                        {
                            string veg = Veg_CB.Text;
                            string tempr = Tempr_CB.Text;
                            DB_commands db_comands = new DB_commands();
                            db_comands.AddDishSoup(name, ingreed, kitchen, proc, tempr, veg);
                            Close();
                        }
                    }
                }
                if (Vtoroe_RB.Checked)
                {
                    if(Method_CB.Text == "")
                    {
                        MessageBox.Show("Вы заполнили не все данные!!!");
                    }
                    else
                    {
                        string method = Method_CB.Text;
                        DB_commands db_comands = new DB_commands();
                        db_comands.AddDishVtoroe(name, ingreed, kitchen, proc, method);
                        Close();
                    }
                }
                if (Dessert_RB.Checked)
                {
                    try
                    {
                        int kall = Int32.Parse(Kall_TB.Text);
                        DB_commands db_comands = new DB_commands();
                        db_comands.AddDishDessert(name, ingreed, kitchen, proc, kall);
                        Close();
                    }
                    catch
                    {
                        MessageBox.Show("Вы заполнили не все данные или заполнили их неверно");
                    }
                    if(Drink_RB.Checked)
                    {
                        try
                        {
                            float alc = float.Parse(Alc_TB.Text);
                            DB_commands db_comands = new DB_commands();
                            db_comands.AddDishDrink(name, ingreed, kitchen, proc, alc);
                            Close();
                        }
                        catch
                        {
                            MessageBox.Show("Вы заполнили не все данные или заполнили их неверно");
                        }
                    }
                }
            }
        }
    }
}