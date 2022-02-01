using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace OOP_Kursach
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Soup]", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            Soup_DGV.DataSource = dataSet.Tables[0];

            SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM [Vtoroe]", sqlConnection);
            DataSet dataSet1 = new DataSet();
            dataAdapter1.Fill(dataSet1);
            Vtoroe_DGV.DataSource = dataSet1.Tables[0];

            SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT * FROM [Dessert]", sqlConnection);
            DataSet dataSet2 = new DataSet();
            dataAdapter2.Fill(dataSet2);
            Dessert_DGV.DataSource = dataSet2.Tables[0];

            SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT * FROM [Drink]", sqlConnection);
            DataSet dataSet3 = new DataSet();
            dataAdapter3.Fill(dataSet3);
            Drink_DGV.DataSource = dataSet3.Tables[0];
        }

        private void добавитьБлюдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDish addDish = new AddDish();
            addDish.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void обновитьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tb_open = tabContol1.SelectedTab.Text;
            if (tb_open == "Первое")
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Soup]", sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                Soup_DGV.DataSource = dataSet.Tables[0];
            }
            if (tb_open == "Второе")
            {
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM [Vtoroe]", sqlConnection);
                DataSet dataSet1 = new DataSet();
                dataAdapter1.Fill(dataSet1);
                Vtoroe_DGV.DataSource = dataSet1.Tables[0];
            }
            if (tb_open == "Десерт")
            {
                SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT * FROM [Dessert]", sqlConnection);
                DataSet dataSet2 = new DataSet();
                dataAdapter2.Fill(dataSet2);
                Dessert_DGV.DataSource = dataSet2.Tables[0];
            }
            if (tb_open == "Напиток")
            {
                SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT * FROM [Drink]", sqlConnection);
                DataSet dataSet3 = new DataSet();
                dataAdapter3.Fill(dataSet3);
                Drink_DGV.DataSource = dataSet3.Tables[0];
            }
        }

        private void изменитьБлюдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditDish editDish = new EditDish();
            string tb_open = tabContol1.SelectedTab.Text;
            if (tb_open == "Первое")
            {
                int id_soup = Int32.Parse(Soup_DGV.CurrentRow.Cells[0].Value.ToString());
                editDish.id_dish = id_soup;
                editDish.dish_type = 0;
                editDish.Show();
            }
            if (tb_open == "Второе")
            {
                int id_vtoroe = Int32.Parse(Vtoroe_DGV.CurrentRow.Cells[0].Value.ToString());
                editDish.id_dish = id_vtoroe;
                editDish.dish_type = 1;
                editDish.Show();
            }
            if (tb_open == "Десерт")
            {
                int id_dessert = Int32.Parse(Dessert_DGV.CurrentRow.Cells[0].Value.ToString());
                editDish.id_dish = id_dessert;
                editDish.dish_type = 2;
                editDish.Show();
            }
            if (tb_open == "Напиток")
            {
                int id_drink = Int32.Parse(Drink_DGV.CurrentRow.Cells[0].Value.ToString());
                editDish.id_dish = id_drink;
                editDish.dish_type = 3;
                editDish.Show();
            }
        }

        private void удалитьБлюдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
