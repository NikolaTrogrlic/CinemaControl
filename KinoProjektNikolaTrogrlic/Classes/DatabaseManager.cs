using Movies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic.Classes
{
    public class DatabaseManager
    {
        private string ConnectionString { get; set; }
        public DatabaseManager(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public void DisplayDataInGrid(string queryTable, string creationString, ref SqlDataAdapter adapter, ref DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    myConnection.Open();
                    if (!TableExists(queryTable))
                    {
                        SqlCommand cmd = new SqlCommand(creationString, myConnection);
                        cmd.ExecuteNonQuery();
                    }
                    string command = "select * from " + queryTable;
                    DataTable dt = new DataTable();
                    adapter = new SqlDataAdapter(command, myConnection);
                    adapter.Fill(dt);
                    /*CALCULATED FIELD*/
                    if (queryTable == "Movies")
                    {
                        DataColumn column = new DataColumn
                        {
                            DataType = Type.GetType("System.TimeSpan"),
                            AllowDBNull = false,
                            Caption = "Duration",
                            ColumnName = "Duration"
                        };
                        dt.Columns.Add(column);
                        foreach (DataRow row in dt.Rows)
                        {
                            row["Duration"] = new TimeSpan(
                                Convert.ToInt32(row["Hours"]),
                                Convert.ToInt32(row["Minutes"]),
                                Convert.ToInt32(row["Seconds"]));
                        }
                        dt.Columns.Remove("Hours");
                        dt.Columns.Remove("Minutes");
                        dt.Columns.Remove("Seconds");
                    }
                    if (queryTable == "Users")
                    {
                        dt.Columns.Remove("ProfilePhoto");
                        dt.Columns.Remove("Password");
                        dt.Columns.Remove("Salt");
                    }
                    dataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool TableExists(string table)
        {
            using (SqlConnection SC = new SqlConnection(ConnectionString))
            {
                // Sql command with parameter 
                string cmdText = @"IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
                           WHERE TABLE_NAME=@name) SELECT 1 ELSE SELECT 0";
                SC.Open();
                SqlCommand checkExist = new SqlCommand(cmdText, SC);

                checkExist.Parameters.Add("@name", SqlDbType.NVarChar).Value = table;

                int x = Convert.ToInt32(checkExist.ExecuteScalar());
                if (x == 1)
                    return true;
                else
                    return false;
            }
        }


        /*MOVIE*/

        public string AddMovieToDB(Movie movie)
        {
            if (movie.Title.Length < 0 || movie.Title.Length > 300)
            {
                return "Movie title length too long or too short";
            }
            else if (movie.Description.Length > 1000 || movie.Description.Length < 0)
            {
                return "Movie description length too long or too short";
            }
            else if (movie.MovieDuration().TotalSeconds <= 0)
            {
                return "Movie duration too short";
            }
            else if (String.IsNullOrEmpty(movie.Category))
            {
                return "Movie must have a category";
            }
            else
            {
                try
                {
                    using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                    {
                        myConnection.Open();
                        string commandString = "insert into Movies(Title,Category,Description,Hours,Minutes,Seconds) values(@title,@category,@description,@hours,@minutes,@seconds)";
                        var command = new SqlCommand(commandString, myConnection);
                        command.Parameters.AddWithValue("@title", movie.Title);
                        command.Parameters.AddWithValue("@category", movie.Category);
                        command.Parameters.AddWithValue("@description", movie.Description);
                        command.Parameters.AddWithValue("@hours", movie.MovieDuration().Hours);
                        command.Parameters.AddWithValue("@minutes", movie.MovieDuration().Minutes);
                        command.Parameters.AddWithValue("@seconds", movie.MovieDuration().Seconds);
                        command.ExecuteNonQuery();

                        return "Sucessfully added.";

                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public string UpdateMovie(int id, Movie movie)
        {
            if (movie.Title.Length <= 0 || movie.Title.Length > 300)
            {
                return "Movie title length too long or too short";
            }
            else if (movie.Description.Length > 1000 || movie.Description.Length <= 0)
            {
                return "Movie description length too long or too short";
            }
            else if (movie.MovieDuration().TotalSeconds <= 0)
            {
                return "Movie duration too short";
            }
            else if (String.IsNullOrEmpty(movie.Category))
            {
                return "Movie must have a category";
            }
            else
            {
                try
                {
                    using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                    {
                        myConnection.Open();
                        string commandString = "update Movies set Title=@title,Category=@category,Description=@description,Hours=@hours,Minutes=@minutes,Seconds=@seconds where Id=@id";
                        var command = new SqlCommand(commandString, myConnection);
                        command.Parameters.AddWithValue("@title", movie.Title);
                        command.Parameters.AddWithValue("@category", movie.Category);
                        command.Parameters.AddWithValue("@description", movie.Description);
                        command.Parameters.AddWithValue("@hours", movie.MovieDuration().Hours);
                        command.Parameters.AddWithValue("@minutes", movie.MovieDuration().Minutes);
                        command.Parameters.AddWithValue("@seconds", movie.MovieDuration().Seconds);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();

                        return "Sucessfully edited";

                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public string DeleteFromDB(int id, string table)
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    myConnection.Open();
                    string commandString = "DELETE FROM " + table + " WHERE Id=@id";
                    var command = new SqlCommand(commandString, myConnection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    return "Deleted";

                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public List<Movie> GetMovies()
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    myConnection.Open();
                    string commandString = "SELECT * FROM Movies;";
                    var command = new SqlCommand(commandString, myConnection);
                    List<Movie> movies = new List<Movie>();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movies.Add(new Movie(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6)));
                        }
                    }
                    return movies;
                }
            }
            catch
            {
                return null;
            }
        }

        public Movie GetMovieById(int id)
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    myConnection.Open();
                    string commandString = "SELECT * FROM Movies WHERE Id=@id;";
                    var command = new SqlCommand(commandString, myConnection);
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new Movie(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6));
                        }
                    }
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
        /*CATEGORY*/
        public List<string> LoadCategories()
        {
            List<string> categories = new List<string>();
            if (TableExists("Categories"))
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    string oString = "Select * from Categories";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);

                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            categories.Add(oReader["Name"].ToString());
                        }

                    }
                }
            }
            else
            {
                categories.Add("No categories found");
            }
            return categories;
        }

        public string AddCategoryToDB(MovieCategory category)
        {
            if (category.Name.Length <= 0 || category.Name.Length > 200)
            {
                return "Category name too short or too long";
            }
            else if (category.Description.Length > 500 || category.Description.Length <= 0)
            {
                return "Category description too short or too long.";
            }
            else
            {
                try
                {
                    using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                    {
                        myConnection.Open();
                        string commandString = "insert into Categories(Name,Description) values(@name,@description)";
                        var command = new SqlCommand(commandString, myConnection);
                        command.Parameters.AddWithValue("@name", category.Name);
                        command.Parameters.AddWithValue("@description", category.Description);
                        command.ExecuteNonQuery();

                        return "Sucessfully added.";

                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public string UpdateCategory(int id, MovieCategory category)
        {
            if (category.Name.Length <= 0 || category.Name.Length > 200)
            {
                return "Category name too short or too long";
            }
            else if (category.Description.Length > 500 || category.Description.Length <= 0)
            {
                return "Category description too short or too long.";
            }
            else
            {
                try
                {
                    using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                    {
                        myConnection.Open();
                        string commandString = "update Categories set Name=@name,Description=@description where Id=@id";
                        var command = new SqlCommand(commandString, myConnection);
                        command.Parameters.AddWithValue("@name", category.Name);
                        command.Parameters.AddWithValue("@description", category.Description);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();

                        return "Sucessfully added.";

                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public MovieCategory GetCategoryById(int id)
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    myConnection.Open();
                    string commandString = "SELECT * FROM Categories WHERE Id=@id;";
                    var command = new SqlCommand(commandString, myConnection);
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new MovieCategory()
                            {
                                Name = reader.GetString(1), 
                                Description = reader.GetString(2)
                            };
                        }
                    }
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
        /*USER*/

        public string AddUserToDB(User user)
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    byte[] pic;
                    using (MemoryStream stream = new MemoryStream())
                    {
                        user.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        pic = stream.ToArray();
                    }
                    myConnection.Open();
                    string commandString = "insert into Users(Username,Password,FirstName,LastName,Gender,ValidatedAccount,LastLogin,ProfilePhoto,Salt) " +
                        "values(@username,@password,@firstname,@lastname,@gender,@validated,@lastlogin,@image,@salt)";
                    SqlCommand command = new SqlCommand(commandString, myConnection);
                    byte[] salt = EncryptionManager.CreateSalt(33);
                    string password = Convert.ToBase64String(EncryptionManager.GenerateSaltedHash(user.Password, salt));
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@firstname", user.FirstName);
                    command.Parameters.AddWithValue("@lastname", user.LastName);
                    command.Parameters.AddWithValue("@gender", user.Gender);
                    command.Parameters.AddWithValue("@validated", user.ValidatedAccount.ToString());
                    command.Parameters.AddWithValue("@lastlogin", DateTime.Now);
                    command.Parameters.AddWithValue("@image", pic);
                    command.Parameters.AddWithValue("@salt", Convert.ToBase64String(salt));
                    command.ExecuteNonQuery();

                    return "Sucessfully added.";

                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ChangeUserPassword(int id,string newpassword)
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    myConnection.Open();
                    string commandString = "update Users set Password=@password, Salt=@salt WHERE Id=@id";
                    byte[] salt = EncryptionManager.CreateSalt(33);
                    newpassword = Convert.ToBase64String(EncryptionManager.GenerateSaltedHash(newpassword, salt));
                    var command = new SqlCommand(commandString, myConnection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@password", newpassword);
                    command.Parameters.AddWithValue("@salt", Convert.ToBase64String(salt));
                    command.ExecuteNonQuery();

                    return "Sucessfully added.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void SetLatestLogin(int id)
        {
            using (SqlConnection myConnection = new SqlConnection(ConnectionString))
            {
                myConnection.Open();
                string commandString = "update Users set LastLogin=@lastlogin where Id=@id";
                var command = new SqlCommand(commandString, myConnection);
                command.Parameters.AddWithValue("@lastlogin", DateTime.Now);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

            }
        }

        public string UpdateUserPicture(int id,Image image)
        {
            byte[] pic;
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                pic = stream.ToArray();
            }
            try
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    myConnection.Open();
                    string commandString = "update Users set ProfilePhoto=@profilepic where Id=@id";
                    var command = new SqlCommand(commandString, myConnection);
                    command.Parameters.AddWithValue("@profilepic", pic);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                    return "Sucessfully updated.";

                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdateUserInfo(int id, User user)
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    myConnection.Open();
                    string commandString = "update Users set Username=@username," +
                        "FirstName=@firstname," +
                        "LastName=@lastname," +
                        "Gender=@gender," +
                        "ValidatedAccount=@validated " +
                        "where Id=@id";
                    var command = new SqlCommand(commandString, myConnection);
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@firstname", user.FirstName);
                    command.Parameters.AddWithValue("@lastname", user.LastName);
                    command.Parameters.AddWithValue("@gender", user.Gender);
                    command.Parameters.AddWithValue("@validated", user.ValidatedAccount.ToString());
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                    return "Sucessfully added.";

                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void ValidateUser(int id)
        {
            using (SqlConnection myConnection = new SqlConnection(ConnectionString))
            {
                myConnection.Open();
                string commandString = "update Users set ValidatedAccount=@validated where Id=@id";
                var command = new SqlCommand(commandString, myConnection);
                command.Parameters.AddWithValue("@validated", "True");
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

            }
        }
        public User GetUser(string username, string password)
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    myConnection.Open();
                    string commandString = "SELECT Salt FROM Users WHERE Username=@username";
                    var command = new SqlCommand(commandString, myConnection);
                    command.Parameters.AddWithValue("@username", username);

                    byte[] salt = null;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            salt = Convert.FromBase64String(reader.GetString(0));
                        }
                    }
                    if (salt != null)
                    {
                        commandString = "SELECT * FROM Users WHERE Username=@username AND Password=@password";
                        command = new SqlCommand(commandString, myConnection);
                        string hashedPass = Convert.ToBase64String(EncryptionManager.GenerateSaltedHash(password, salt));
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", hashedPass);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int userId = reader.GetInt32(0);
                                User user = new User(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), (byte[])reader[8]);
                                SetLatestLogin(userId);
                                return user;
                            }
                        }
                        return null;
                    }
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public User GetUserById(int id)
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    myConnection.Open();
                    string commandString = "SELECT * FROM Users WHERE Id=@id";
                    var command = new SqlCommand(commandString, myConnection);
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            User user = new User(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), (byte[])reader[8]);
                            return user;
                        }
                    }
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public bool UserExists(string username)
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    myConnection.Open();
                    string commandString = "SELECT Id FROM Users WHERE Username=@username;";
                    var command = new SqlCommand(commandString, myConnection);
                    command.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public int GetGender(string gender)
        {
            string genderHR = "none";
            switch (gender)
            {
                case "Male":
                    genderHR = "Muško";
                    break;
                case "Female":
                    genderHR = "Žensko";
                    break;
                case "Other":
                    genderHR = "Drugi";
                    break;
            }
            int counter = 0;
            try
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    myConnection.Open();
                    string commandString = "SELECT * FROM Users;";
                    var command = new SqlCommand(commandString, myConnection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(5) == gender || reader.GetString(5) == genderHR)
                            {
                                counter++;
                            }

                        }
                    }
                    return counter;
                }
            }
            catch
            {
                return -1;
            }
        }
    }

}
