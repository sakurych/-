using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using static OOP_Kursach.Dish;
using static OOP_Kursach.Drink;
using static OOP_Kursach.Soup;
using static OOP_Kursach.Second;
using static OOP_Kursach.Dessert;


namespace OOP_Kursach
{
    class DB_commands
    {
        private SqlConnection sqlConnection = null;

        public  void AddDishSoup(string name_, string ingreed_, string kitchen_, string proc_, string tempr_, string veg_)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
             sqlConnection.Open();

            Soup soup = new Soup( name_, ingreed_, kitchen_, proc_, tempr_, veg_);

            SqlCommand command = new SqlCommand("INSERT INTO [Soup] (Title, Ingreeds," +
                "Kitchen, Process, ColdHot, VeganMeat )" +
                "VALUES (@Title, @Ingreeds, @Kitchen, @Process, @ColdHot, @VeganMeat)", sqlConnection);

            command.Parameters.AddWithValue("Title", soup.getName());
            command.Parameters.AddWithValue("Ingreeds", soup.getIngreed());
            command.Parameters.AddWithValue("Kitchen", soup.getKitchen());
            command.Parameters.AddWithValue("Process", soup.getProc());
            command.Parameters.AddWithValue("ColdHot", soup.getTempr());
            command.Parameters.AddWithValue("VeganMeat", soup.getVeg());

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public List<string> getDishByIdSoup(int id_Dish)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Soup WHERE id=@id", sqlConnection);

            command.Parameters.AddWithValue("id", id_Dish);
            SqlDataReader res = command.ExecuteReader();

            List<string> dish = new List<string>();

            while (res.Read())
            {
                dish.Add(res["Title"].ToString());
                dish.Add(res["Ingreeds"].ToString());
                dish.Add(res["Kitchen"].ToString());
                dish.Add(res["Process"].ToString());
                dish.Add(res["ColdHot"].ToString());
                dish.Add(res["VeganMeat"].ToString());
            }
            return dish;
        }

        public void UpdateDishSoup (int id, string name_, string ingreed_, string kitchen_, string proc_, string tempr_, string veg_)
        {
            Soup soup = new Soup(name_, ingreed_, kitchen_, proc_, tempr_, veg_);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("UPDATE [Soup] SET Title = @Title, Ingreeds = @Ingreeds," +
                "Kitchen = @Kitchen, Process = @Process, ColdHot = @ColdHot, VeganMeat = @VeganMeat " +
                "WHERE Id = @Id", sqlConnection);

            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("Title", soup.getName());
            command.Parameters.AddWithValue("Ingreeds", soup.getIngreed());
            command.Parameters.AddWithValue("Kitchen", soup.getKitchen());
            command.Parameters.AddWithValue("Process", soup.getProc());
            command.Parameters.AddWithValue("ColdHot", soup.getTempr());
            command.Parameters.AddWithValue("VeganMeat", soup.getVeg());

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void AddDishVtoroe(string name_, string ingreed_, string kitchen_, string proc_, string method_)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

            Second second = new Second(name_, ingreed_, kitchen_, proc_, method_);

            SqlCommand command = new SqlCommand("INSERT INTO [Vtoroe] (Title, Ingreeds," +
                "Kitchen, Process, Method )" +
                "VALUES (@Title, @Ingreeds, @Kitchen, @Process, @Method)", sqlConnection);

            command.Parameters.AddWithValue("Title", second.getName());
            command.Parameters.AddWithValue("Ingreeds", second.getIngreed());
            command.Parameters.AddWithValue("Kitchen", second.getKitchen());
            command.Parameters.AddWithValue("Process", second.getProc());
            command.Parameters.AddWithValue("Method", second.getMethod());

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }


        public List<string> getDishByIdVtoroe(int id_Dish)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Vtoroe WHERE id=@id", sqlConnection);

            command.Parameters.AddWithValue("id", id_Dish);
            SqlDataReader res = command.ExecuteReader();

            List<string> dish = new List<string>();

            while (res.Read())
            {
                dish.Add(res["Title"].ToString());
                dish.Add(res["Ingreeds"].ToString());
                dish.Add(res["Kitchen"].ToString());
                dish.Add(res["Process"].ToString());
                dish.Add(res["Method"].ToString());
            }
            return dish;
        }

        public void UpdateDishVtoroe(int id, string name_, string ingreed_, string kitchen_, string proc_, string method_)
        {
            Second second = new Second(name_, ingreed_, kitchen_, proc_, method_);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("UPDATE [Vtoroe] SET Title = @Title, Ingreeds = @Ingreeds," +
                "Kitchen = @Kitchen, Process = @Process, Method = @Method " +
                "WHERE Id = @Id", sqlConnection);

            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("Title", second.getName());
            command.Parameters.AddWithValue("Ingreeds", second.getIngreed());
            command.Parameters.AddWithValue("Kitchen", second.getKitchen());
            command.Parameters.AddWithValue("Process", second.getProc());
            command.Parameters.AddWithValue("Method", second.getMethod());

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void AddDishDrink(string name_, string ingreed_, string kitchen_, string proc_, float alc_)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

            Drink drink = new Drink(name_, ingreed_, kitchen_, proc_, alc_);

            SqlCommand command = new SqlCommand("INSERT INTO [Drink] (Title, Ingreeds," +
                "Kitchen, Process, Alcohol )" +
                "VALUES (@Title, @Ingreeds, @Kitchen, @Process, @Alcohol)", sqlConnection);

            command.Parameters.AddWithValue("Title", drink.getName());
            command.Parameters.AddWithValue("Ingreeds", drink.getIngreed());
            command.Parameters.AddWithValue("Kitchen", drink.getKitchen());
            command.Parameters.AddWithValue("Process", drink.getProc());
            command.Parameters.AddWithValue("Alcohol", drink.getAlc());

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public List<string> getDishByIdDrink(int id_Dish)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Drink WHERE id=@id", sqlConnection);

            command.Parameters.AddWithValue("id", id_Dish);
            SqlDataReader res = command.ExecuteReader();

            List<string> dish = new List<string>();

            while (res.Read())
            {
                dish.Add(res["Title"].ToString());
                dish.Add(res["Ingreeds"].ToString());
                dish.Add(res["Kitchen"].ToString());
                dish.Add(res["Process"].ToString());
                dish.Add(res["Alcohol"].ToString());
            }
            return dish;
        }

        public void UpdateDishDrink(int id, string name_, string ingreed_, string kitchen_, string proc_, float alc_)
        {
            Drink drink = new Drink(name_, ingreed_, kitchen_, proc_, alc_);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("UPDATE [Drink] SET Title = @Title, Ingreeds = @Ingreeds," +
                "Kitchen = @Kitchen, Process = @Process, Alcohol = @Alcohol " +
                "WHERE Id = @Id", sqlConnection);

            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("Title", drink.getName());
            command.Parameters.AddWithValue("Ingreeds", drink.getIngreed());
            command.Parameters.AddWithValue("Kitchen", drink.getKitchen());
            command.Parameters.AddWithValue("Process", drink.getProc());
            command.Parameters.AddWithValue("Alcohol", drink.getAlc());

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void AddDishDessert(string name_, string ingreed_, string kitchen_, string proc_, int kall_)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

            Dessert dessert = new Dessert(name_, ingreed_, kitchen_, proc_, kall_);

            SqlCommand command = new SqlCommand("INSERT INTO [Dessert] (Title, Ingreeds," +
                "Kitchen, Process, Calories )" +
                "VALUES (@Title, @Ingreeds, @Kitchen, @Process, @Calories)", sqlConnection);

            command.Parameters.AddWithValue("Title", dessert.getName());
            command.Parameters.AddWithValue("Ingreeds", dessert.getIngreed());
            command.Parameters.AddWithValue("Kitchen", dessert.getKitchen());
            command.Parameters.AddWithValue("Process", dessert.getProc());
            command.Parameters.AddWithValue("Calories", dessert.getKall());

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public List<string> getDishByIdDessert(int id_Dish)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Dessert WHERE id=@id", sqlConnection);

            command.Parameters.AddWithValue("id", id_Dish);
            SqlDataReader res = command.ExecuteReader();

            List<string> dish = new List<string>();

            while (res.Read())
            {
                dish.Add(res["Title"].ToString());
                dish.Add(res["Ingreeds"].ToString());
                dish.Add(res["Kitchen"].ToString());
                dish.Add(res["Process"].ToString());
                dish.Add(res["Calories"].ToString());
            }
            return dish;
        }

        public void UpdateDishDessert(int id, string name_, string ingreed_, string kitchen_, string proc_, int kall_)
        {
            Dessert dessert = new Dessert(name_, ingreed_, kitchen_, proc_, kall_);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("UPDATE [Dessert] SET Title = @Title, Ingreeds = @Ingreeds," +
                "Kitchen = @Kitchen, Process = @Process, Calories = @Calories " +
                "WHERE Id = @Id", sqlConnection);

            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("Title", dessert.getName());
            command.Parameters.AddWithValue("Ingreeds", dessert.getIngreed());
            command.Parameters.AddWithValue("Kitchen", dessert.getKitchen());
            command.Parameters.AddWithValue("Process", dessert.getProc());
            command.Parameters.AddWithValue("Calories", dessert.getKall());

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void DeleteDishById(string dishType_, string id_)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            sqlConnection.Open(); 

            string query = "DELETE FROM [" + dishType_ + "] WHERE id = @id";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            command.Parameters.AddWithValue("id", id_);

            command.ExecuteNonQueryAsync();
            sqlConnection.Close();
        }
       
    }
}
