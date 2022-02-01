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
    public partial class EditDish : Form
    {
        public int id_dish;
        public int dish_type;

        public EditDish()
        {
            InitializeComponent();
        }

        private void EditDish_Shown(object sender, EventArgs e)
        {
            if (dish_type == 0)
            {
                Soup_RB.Checked = true;
                Full_TB_Soup();
            }
            else
            {
                if (dish_type == 1)
                {
                    Vtoroe_RB.Checked = true;
                    Full_TB_Vtoroe();
                }
                else
                {
                    if (dish_type == 2)
                    {
                        Dessert_RB.Checked = true;
                        Full_TB_Dessert();
                    }
                    else
                    {
                        if (dish_type == 3)
                        {
                            Drink_RB.Checked = true;
                            Full_TB_Drink();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка");
                        }
                    }
                }
            }
        }

        private void Full_TB_Soup()
        {
            DB_commands db_commands = new DB_commands();
            List<string> dish = db_commands.getDishByIdSoup(id_dish);
            Name_TB.Text = dish[0];
            Ingreeds_TB.Text = dish[1];
            Kitchen_TB.Text = dish[2];
            Proc_TB.Text = dish[3];
            Tempr_CB.Text = dish[4];
            Veg_CB.Text = dish[5];
        }

        private void Full_TB_Vtoroe()
        {
            DB_commands db_commands = new DB_commands();
            List<string> dish = db_commands.getDishByIdVtoroe(id_dish);
            Name_TB.Text = dish[0];
            Ingreeds_TB.Text = dish[1];
            Kitchen_TB.Text = dish[2];
            Proc_TB.Text = dish[3];
            Method_CB.Text = dish[4];
        }

        private void Full_TB_Dessert()
        {
            DB_commands db_commands = new DB_commands();
            List<string> dish = db_commands.getDishByIdDessert(id_dish);
            Name_TB.Text = dish[0];
            Ingreeds_TB.Text = dish[1];
            Kitchen_TB.Text = dish[2];
            Proc_TB.Text = dish[3];
            Kall_TB.Text = dish[4];
        }

        private void Full_TB_Drink()
        {
            DB_commands db_commands = new DB_commands();
            List<string> dish = db_commands.getDishByIdDrink(id_dish);
            Name_TB.Text = dish[0];
            Ingreeds_TB.Text = dish[1];
            Kitchen_TB.Text = dish[2];
            Proc_TB.Text = dish[3];
            Alc_TB.Text = dish[4];
        }

        private void Soup_RB_CheckedChanged(object sender, EventArgs e)
        {

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

        private void Vtoroe_RB_CheckedChanged(object sender, EventArgs e)
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

        private void EditDish_Buttton_Click(object sender, EventArgs e)
        {
            
        }

        private void EditDish_Load(object sender, EventArgs e)
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

        private void Soup_RB_CheckedChanged_1(object sender, EventArgs e)
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

        private void Dessert_RB_CheckedChanged_1(object sender, EventArgs e)
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

        private void Drink_RB_CheckedChanged_1(object sender, EventArgs e)
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

        private void EditDish_Buttton_Click_1(object sender, EventArgs e)
        {
            if (Name_TB.TextLength == 0 || Kitchen_TB.TextLength == 0 || Ingreeds_TB.TextLength == 0 || Proc_TB.TextLength == 0 ||
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

                if (Soup_RB.Checked)
                {
                    if (Tempr_CB.Text == "")
                    {
                        MessageBox.Show("Вы заполнили не все данные или заполнили их неверно");
                    }
                    else
                    {
                        if (Veg_CB.Text == "")
                        {
                            MessageBox.Show("Вы заполнили не все данные или заполнили их неверно");
                        }
                        else
                        {
                            string veg = Veg_CB.Text;
                            string tempr = Tempr_CB.Text;
                            DB_commands db_comands = new DB_commands();
                            db_comands.UpdateDishSoup(id_dish, name, ingreed, kitchen, proc, tempr, veg);
                            Close();
                        }
                    }
                }
                if (Vtoroe_RB.Checked)
                {
                    if (Method_CB.Text == "")
                    {
                        MessageBox.Show("Вы заполнили не все данные!!!");
                    }
                    else
                    {
                        string method = Method_CB.Text;
                        DB_commands db_comands = new DB_commands();
                        db_comands.UpdateDishVtoroe(id_dish, name, ingreed, kitchen, proc, method);
                        Close();
                    }
                }
                if (Dessert_RB.Checked)
                {
                    try
                    {
                        int kall = Int32.Parse(Kall_TB.Text);
                        DB_commands db_comands = new DB_commands();
                        db_comands.UpdateDishDessert(id_dish, name, ingreed, kitchen, proc, kall);
                        Close();
                    }
                    catch
                    {
                        MessageBox.Show("Вы заполнили не все данные или заполнили их неверно");
                    }
                    if (Drink_RB.Checked)
                    {
                        try
                        {
                            float alc = float.Parse(Alc_TB.Text);
                            DB_commands db_comands = new DB_commands();
                            db_comands.UpdateDishDrink(id_dish, name, ingreed, kitchen, proc, alc);
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

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (dish_type == 0)
            {
                DB_commands db_commands = new DB_commands();
                db_commands.DeleteDishById("Soup", id_dish.ToString());
                Close();
            }
            else
            {
                if (dish_type == 1)
                {
                    DB_commands db_commands = new DB_commands();
                    db_commands.DeleteDishById("Vtoroe", id_dish.ToString());
                    Close();
                }
                else
                {
                    if (dish_type == 2)
                    {
                        DB_commands db_commands = new DB_commands();
                        db_commands.DeleteDishById("Dessert", id_dish.ToString());
                        Close();
                    }
                    else
                    {
                        if (dish_type == 3)
                        {
                            DB_commands db_commands = new DB_commands();
                            db_commands.DeleteDishById("Drink", id_dish.ToString());
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка");
                        }
                    }
                }
            }
        }
    }
}
