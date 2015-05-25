using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;





namespace AutoWashingProject
{
    class WorkingWithDatabase
    {

        public bool SaveUser(User user)
        {
            bool isSaved = false;
            SqlConnection con = new SqlConnection("Data Source=MASTER\\SQLSERVER;Initial Catalog=auto_washing_database;Integrated Security=True");
            try
            {
                con.Open();
                //label1.Text = "Sikerult";

                var sql = @"INSERT INTO Users (Name, Email, Password, Phone) VALUES (@Name, @Password, @Email, @Phone)";

                using (var cmd = new SqlCommand(sql, con))
                {

                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Phone", user.Phone);
                    System.Diagnostics.Debug.WriteLine(user.Phone);
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (0 < rowsAffected) isSaved = true;
                    }
                    catch (SqlException ex)
                    {
                        // It is almost prefered to let the exception be thrown freely
                        // so that you may have its full stack trace and have more 
                        // details on your error.
                        //MessageBox.Show(ex.Message);
                        Debug.WriteLine("Send to debug output." + ex.Message);
                    }

                    finally
                    {
                        if (con.State == ConnectionState.Open) con.Close();
                    }

                }


            }
            catch (Exception)
            {
                // "Nem sikerult";

                Debug.WriteLine("Sikertelen");

            }
            return isSaved;

        }


        public User getUserByEmailAndPass(User user)
        {
            //bool isRegistered = false;


            SqlConnection con = new SqlConnection("Data Source=MASTER\\SQLSERVER;Initial Catalog=auto_washing_database;Integrated Security=True");
            try
            {
                string oString = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";
                SqlCommand oCmd = new SqlCommand(oString, con);
                oCmd.Parameters.AddWithValue("@Email", user.Email);
                oCmd.Parameters.AddWithValue("@Password", user.Password);
                con.Open();

                System.Diagnostics.Debug.WriteLine("VALAMI" + user.Email);

                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        int i=0;
                        
                        int.TryParse(oReader["Id"].ToString(), out i);
                        user.Id = i;
                        user.Name = oReader["Name"].ToString();
                        user.Phone = oReader["Phone"].ToString();
                    }

                    con.Close();
                }


            }
            catch (Exception)
            {
            }

            return user;
        }

       public bool saveAuto(Auto auto){

           bool isSaved = false;

           SqlConnection con = new SqlConnection("Data Source=MASTER\\SQLSERVER;Initial Catalog=auto_washing_database;Integrated Security=True");
           try
           {
               con.Open();
               //label1.Text = "Sikerult";

               var sql = @"INSERT INTO Auto (UserId, Plate, Brand, Type) VALUES (@UserId, @Plate, @Brand, @Type)";

               using (var cmd = new SqlCommand(sql, con))
               {

                   cmd.Parameters.AddWithValue("@UserId", auto.UserId);
                   cmd.Parameters.AddWithValue("@Plate", auto.Plate);
                   cmd.Parameters.AddWithValue("@Brand", auto.Brand);
                   cmd.Parameters.AddWithValue("@Type", auto.Type);
                   //System.Diagnostics.Debug.WriteLine(user.Phone);

                   try
                   {
                       int rowsAffected = cmd.ExecuteNonQuery();
                       if (0 < rowsAffected) isSaved = true;
                   }
                   catch (SqlException ex)
                   {
                       // It is almost prefered to let the exception be thrown freely
                       // so that you may have its full stack trace and have more 
                       // details on your error.
                       //MessageBox.Show(ex.Message);
                   }

                   finally
                   {
                       if (con.State == ConnectionState.Open) con.Close();
                   }

               }

           }
           catch (Exception)
           {
           }
           return isSaved;
        }

       public bool isPlateRegistered(string plate) {

           bool isRegistered = false;

           SqlConnection con = new SqlConnection("Data Source=MASTER\\SQLSERVER;Initial Catalog=auto_washing_database;Integrated Security=True");
           try
           {
               string oString = "SELECT * FROM Auto WHERE Plate = @Plate";
               SqlCommand oCmd = new SqlCommand(oString, con);
               oCmd.Parameters.AddWithValue("@Plate", plate);
               con.Open();
               //label1.Text = "Sikerult";

               using (SqlDataReader oReader = oCmd.ExecuteReader())
               {
                   while (oReader.Read())
                   {
                       isRegistered = true;
                   }

                   con.Close();
               }


           }
           catch (Exception)
           {
           }

           return isRegistered;
       }
    }
}
