using KinoProjektNikolaTrogrlic.AdminAPP;
using KinoProjektNikolaTrogrlic.Classes;
using Microsoft.Win32;
using Movies;
using Newtonsoft.Json;
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace KinoProjektNikolaTrogrlic
{
    public partial class AdminManagement : TranslatableForm
    {
        /*SQL*/
        public DatabaseManager Db { get; set; }

        private SqlDataAdapter AdapterMovies;
        private SqlDataAdapter AdapterCategory;
        private SqlDataAdapter AdapterUsers;
        private string ConnectionString { get; set; }

        /*MULTITHREADING*/
        public int TaskNumber { get; set; }

        /*TCP HOST*/

        SimpleTcpServer Server { get; set; }
        public AdminManagement(string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString;
            Db = new DatabaseManager(ConnectionString);
            DisplayMovieData();
            TaskNumber = 3;
        }

        private void AdminManagement_Load(object sender, EventArgs e)
        {
            if (CheckIfSettingsKeyPresent("OMDBApiKey"))
            {
                textboxApiKey.Text = GetSettingsKey("OMDBApiKey");
            }
            Server = new SimpleTcpServer
            {
                Delimiter = 0x13,
                StringEncoder = Encoding.UTF8
            };
            Server.DataReceived += Server_DataReceived;
        }
        private void ManagmentTabs_SelectedIndexChanged(Object sender, EventArgs e)
        {

            int index = ManagmentTabs.SelectedIndex;
            switch (index)
            {
                case 0:
                    DisplayMovieData();
                    break;
                case 1:
                    List<string> categories = Db.LoadCategories();
                    if (categories.Count > 0)
                    {
                        if (categories[0] != "No categories found")
                        {
                            DisplayCategoryData();
                        }
                    }
                    break;
                case 2:
                    DisplayUserData();
                    break;
            }
        }


        /*MOVIE*/
        private void DisplayMovieData()
        {
            try
            {
                gridviewMovies.DataSource = new DataTable();
                Db.DisplayDataInGrid("Movies", "CREATE TABLE Movies(Id int NOT NULL IDENTITY(1,1) PRIMARY KEY,Title varchar(300),Category varchar(200),Description varchar(1000),Hours int,Minutes int,Seconds int);", ref AdapterMovies, ref gridviewMovies);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GridviewMovies_RowHeaderDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(gridviewMovies.Rows[e.RowIndex].Cells[0].Value);
                EditMovie dialog = new EditMovie(id, Db);
                dialog.FormClosed += delegate
                {
                    DisplayMovieData();
                };
                dialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonAddMovie_Click(object sender, EventArgs e)
        {
            AddMovie dialog = new AddMovie(Db);
            dialog.FormClosed += delegate
            {
                DisplayMovieData();
            };
            dialog.ShowDialog();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textboxSearch.Text.ToUpper();
            gridviewMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool found = false;
                foreach (DataGridViewRow row in gridviewMovies.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null &&
                            row.Cells[i].Value.ToString().ToUpper().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            gridviewMovies.Rows[rowIndex].Selected = true;
                            found = true;
                            break;
                        }
                    }

                }
                if (!found)
                {
                    MessageBox.Show(textboxSearch.Text + TranslatableString(" not found"," nije pronađen"));
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            List<int> removeRows = new List<int>();
            string searchValue = textboxSearch.Text.ToUpper();
            try
            {
                foreach (DataGridViewRow row in gridviewMovies.Rows)
                {
                    bool result = false;
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null &&
                            row.Cells[i].Value.ToString().ToUpper().Contains(searchValue))
                        {
                            int rowIndex = row.Index;
                            result = true;
                            break;
                        }
                    }
                    if (!result)
                    {
                        removeRows.Add(row.Index);
                    }

                }
                for (int i = removeRows.Count - 1; i >= 0; i--)
                {
                    gridviewMovies.Rows.RemoveAt(removeRows[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*CATEGORY*/
        private void DisplayCategoryData()
        {
            try
            {
                gridviewCategories.DataSource = new DataTable();
                Db.DisplayDataInGrid("Categories", "CREATE TABLE Categories(Id int NOT NULL IDENTITY(1,1) PRIMARY KEY,Name varchar(300) NOT NULL,Description varchar(300));", ref AdapterCategory, ref gridviewCategories);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GridviewCategories_RowHeaderDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(gridviewCategories.Rows[e.RowIndex].Cells[0].Value);
            EditCategory dialog = new EditCategory(id, Db);
            dialog.FormClosed += delegate
            {
                DisplayCategoryData();
            };
            dialog.ShowDialog();
        }

        private void ButtonCategory_Click(object sender, EventArgs e)
        {
            AddCategory dialog = new AddCategory(Db);
            dialog.FormClosed += delegate
            {
                DisplayCategoryData();
            };
            dialog.ShowDialog();
        }

        /*USER*/

        private void DisplayUserData()
        {
            try
            {
                gridviewUsers.DataSource = new DataTable();
                Db.DisplayDataInGrid("Users", "CREATE TABLE Users(Id int NOT NULL IDENTITY(1,1) PRIMARY KEY,Username varchar(300) NOT NULL,Password varchar(1000),FirstName varchar(500),LastName varchar(500),Gender varchar(8),ValidatedAccount varchar(6),LastLogin datetime,ProfilePhoto varbinary(MAX),Salt varchar(MAX));", ref AdapterUsers, ref gridviewUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonUser_Click(object sender, EventArgs e)
        {
            AddUser dialog = new AddUser(Db);
            dialog.FormClosed += delegate
            {
                DisplayUserData();
            };
            dialog.ShowDialog();
        }

        private void ButtonUnvalidated_Click(object sender, EventArgs e)
        {
            gridviewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in gridviewUsers.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null &&
                            gridviewUsers.Columns[i].Name == "ValidatedAccount" &&
                            row.Cells[i].Value.ToString().ToUpper().Equals("FALSE"))
                        {
                            int rowIndex = row.Index;
                            gridviewUsers.Rows[rowIndex].Selected = true;
                            break;
                        }
                    }

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void GridviewUsers_RowHeaderDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(gridviewUsers.Rows[e.RowIndex].Cells[0].Value);
                EditUser dialog = new EditUser(id,Db);
                dialog.FormClosed += delegate
                {
                    DisplayUserData();
                };
                dialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonValidate_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in gridviewUsers.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null &&
                            gridviewUsers.Columns[i].Name == "ValidatedAccount" &&
                            row.Cells[i].Value.ToString().ToUpper().Equals("FALSE"))
                        {
                            int rowIndex = row.Index;
                            gridviewUsers.Rows[rowIndex].Selected = true;
                            int id = Convert.ToInt32(gridviewUsers.Rows[rowIndex].Cells[0].Value);
                            Db.ValidateUser(id);
                            break;
                        }
                    }
                }
                DisplayUserData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonCalculateGender_Click(object sender, EventArgs e)
        {
            if (Db.TableExists("Users"))
            {
                var genderLock = new object();
                int male = -1;
                int female = -1;
                int other = -1;
                BackgroundWorker workerMale = new BackgroundWorker();
                BackgroundWorker workerFemale = new BackgroundWorker();
                BackgroundWorker workerOther = new BackgroundWorker();
                BackgroundWorker calculationWorker = new BackgroundWorker();

                calculationWorker.DoWork += (s, ev) =>
                {
                    int oldProgress = 4;
                    while (oldProgress > 0)
                    {
                        if (TaskNumber != oldProgress)
                        {
                            oldProgress = TaskNumber;
                            calculationWorker.ReportProgress(oldProgress);
                        }
                    }

                };

                calculationWorker.ProgressChanged += (s, ev) =>
                {
                    if (TaskNumber <= 0)
                    {
                        buttonCalculateGender.Enabled = true;

                    }
                    else
                    {
                        buttonCalculateGender.Enabled = false;
                    }
                };

                calculationWorker.RunWorkerCompleted += (s, ev) =>
                {
                    TaskNumber = 3;
                    int total = male + female + other;
                    double pMale = Math.Round(((double)male / total) * 100, 2);
                    double pFemale = Math.Round(((double)female / total) * 100, 2);
                    double pOther = Math.Round(((double)other / total) * 100, 2);
                    MessageBox.Show(TranslatableString("Gender Distribution| Male:" + pMale + "% ,Female:" + pFemale + "% ,Other:" + pOther + "%", "Distribucija Rodova| Muško:" + pMale + "% ,Žensko:" + pFemale + "% ,Ostalo:" + pOther + "%"));
                };

                calculationWorker.WorkerReportsProgress = true;

                workerMale.DoWork += (s, ev) =>
                {
                    var db = new DatabaseManager(ConnectionString);
                    ev.Result = db.GetGender("Male");
                };
                workerFemale.DoWork += (s, ev) =>
                {
                    var db = new DatabaseManager(ConnectionString);
                    ev.Result = db.GetGender("Female");
                };
                workerOther.DoWork += (s, ev) =>
                {
                    var db = new DatabaseManager(ConnectionString);
                    ev.Result = db.GetGender("Other");
                };

                workerMale.RunWorkerCompleted += (s, ev) =>
                {
                    lock (genderLock)
                    {
                        TaskNumber--;
                        male = Convert.ToInt32(ev.Result);
                    }
                };

                workerFemale.RunWorkerCompleted += (s, ev) =>
                {
                    lock (genderLock)
                    {
                        TaskNumber--;
                        female = Convert.ToInt32(ev.Result);
                    }
                };

                workerOther.RunWorkerCompleted += (s, ev) =>
                {
                    lock (genderLock)
                    {
                        TaskNumber--;
                        other = Convert.ToInt32(ev.Result);
                    }
                };

                calculationWorker.RunWorkerAsync();
                workerFemale.RunWorkerAsync();
                workerMale.RunWorkerAsync();
                workerOther.RunWorkerAsync();
            }
        }

        /*SETTINGS*/

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\CinemaControlSettings");
                String databaseToConnect = textboxServerDatabase.Text;
                if (checkboxEnter.Checked && !String.IsNullOrEmpty(textboxKey.Text))
                {
                    String connectionString = "";
                    try

                    {

                        if (String.IsNullOrEmpty(databaseToConnect))
                        {
                            databaseToConnect = "master";
                        }

                        connectionString = "server=" + textboxServerName.Text +
                            ";database=" + databaseToConnect +
                            ";UID=" + textboxServerUser.Text +
                            ";password=" + textboxServerPassword.Text;

                        SqlConnection myConnection = new SqlConnection(connectionString);

                        myConnection.Open();
                        key.SetValue("ServerName", textboxServerName.Text);
                        key.SetValue("ServerDatabase", databaseToConnect);
                        key.SetValue("ServerUID", textboxServerUser.Text);
                        var encryption = EncryptionManager.EncryptString(textboxServerPassword.Text, textboxKey.Text);
                        key.SetValue("ServerPassword", encryption);
                        MessageBox.Show("Database info sucessfully saved.");
                        textboxServerName.Clear();
                        textboxServerUser.Clear();
                        textboxServerPassword.Clear();
                        textboxKey.Clear();
                        myConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                key.SetValue("AutoEnter", checkboxEnter.Checked);
                if (!String.IsNullOrEmpty(textboxApiKey.Text))
                {
                    key.SetValue("OMDBApiKey", textboxApiKey.Text);
                }
                else
                {
                    if (CheckIfSettingsKeyPresent("OMDBApiKey"))
                    {
                        key.DeleteValue("OMDBApiKey");
                    }
                }
                key.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckboxEnter_CheckedChanged(object sender, EventArgs e)
        {
            textboxServerDatabase.Enabled = checkboxEnter.Checked;
            textboxServerName.Enabled = checkboxEnter.Checked;
            textboxServerPassword.Enabled = checkboxEnter.Checked;
            textboxServerUser.Enabled = checkboxEnter.Checked;
            textboxKey.Enabled = checkboxEnter.Checked;
        }

        public static bool CheckIfSettingsKeyPresent(string subkey)
        {
            RegistryKey key = RegistryHelpers.GetRegistryKey(@"SOFTWARE\CinemaControlSettings");
            if (key != null)
            {
                return (key.GetValueNames().Contains(subkey));
            }
            else
            {
                return false;
            }
        }

        public static string GetSettingsKey(string subkey)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\CinemaControlSettings", true);
            return key.GetValue(subkey).ToString();
        }

        public static byte[] GetSettingsKeyBytes(string subkey)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\CinemaControlSettings", true);
            return (byte[])key.GetValue(subkey);
        }



        /*SUPPORT ZA 64-BITNE SISTEME*/
        public class RegistryHelpers
        {

            public static RegistryKey GetRegistryKey()
            {
                return GetRegistryKey(null);
            }

            public static RegistryKey GetRegistryKey(string keyPath)
            {
                RegistryKey localMachineRegistry
                    = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser,
                                              Environment.Is64BitOperatingSystem
                                                  ? RegistryView.Registry64
                                                  : RegistryView.Registry32);

                return string.IsNullOrEmpty(keyPath)
                    ? localMachineRegistry
                    : localMachineRegistry.OpenSubKey(keyPath, true);
            }

            public static object GetRegistryValue(string keyPath, string keyName)
            {
                RegistryKey registry = GetRegistryKey(keyPath);
                return registry.GetValue(keyName);
            }
        }

        

        /*TCP HOST*/

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            try
            {
                if (!e.MessageString.StartsWith("REGISTER:"))
                {
                    if (e.MessageString == "SEND MOVIES")
                    {
                        textboxLog.Invoke((MethodInvoker)delegate ()
                        {
                            textboxLog.Text += "\nSending list of movies...";
                        });
                        List<Movie> movies = Db.GetMovies();
                        e.Reply(JsonConvert.SerializeObject(movies));
                    }
                    else
                    {
                        User u = JsonConvert.DeserializeObject<User>(e.MessageString);
                        string user = ServerSend(u);
                        if (user != "No user found")
                        {
                            e.Reply(user);
                        }
                        else
                        {
                            e.Reply("Connection Failure");
                        }
                        textboxLog.Invoke((MethodInvoker)delegate ()
                        {
                            textboxLog.Text += "\nLogin attempt to username:" + u.Username;
                        });
                    }
                }
                else
                {
                    string newString = e.MessageString.Substring(9);
                    User u = JsonConvert.DeserializeObject<User>(newString);
                    if (!Db.UserExists(u.Username))
                    {
                        using (var ms = new MemoryStream(u.ImageBytes))
                        {
                            using (var img = Image.FromStream(ms))
                            {
                                u.Image = img;
                                Db.AddUserToDB(u);
                                e.Reply("Added");
                                textboxLog.Invoke((MethodInvoker)delegate ()
                                {
                                    textboxLog.Text += "\nRegister suceedeed...";
                                });
                            }
                        }
                    }
                    else
                    {
                        e.Reply("Exists");
                        textboxLog.Invoke((MethodInvoker)delegate ()
                        {
                            textboxLog.Text += "\nRegistration failed: User already exists.";
                        });
                    }

                }
            }
            catch (Exception ex)
            {
                textboxLog.Invoke((MethodInvoker)delegate ()
                {
                    textboxLog.Text += "\nConnection Failed for:" + e.MessageString;
                    textboxLog.Text += "\nReason:" + ex.Message;
                });
                e.Reply("Connection Failure");
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Server.IsStarted)
                {
                    textboxLog.Text += "Server starting...\n";
                    IPAddress address = IPAddress.Parse(textboxAddress.Text);
                    int port = Convert.ToInt32(textboxPort.Text);
                    Server.Start(address, port);
                    buttonStart.Enabled = false;
                    buttonStop.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                buttonStop.Enabled = false;
                buttonStart.Enabled = true;
                textboxLog.Text += "\nServer Stopped due to error.";
            }
            Authentification auth = new Authentification();
            auth.Show();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            Server.Stop();
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
            textboxLog.Text += "\nServer Stopped...";
        }

        public string ServerSend(User user)
        {
            User newUser = Db.GetUser(user.Username, user.Password);
            if (newUser != null)
            {

                return newUser.ToJson();
            }
            return "No user found";
        }
    }
}
