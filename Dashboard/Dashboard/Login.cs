using Dashboard;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login
{
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection(GlobalVariable.connectionString);
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool isValid()
        {
            if (tbUsername.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("gabole kosong blok", "error");
                return false;
            }
            else if (tbPassword.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("gabole kosong ple", "error");
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Console.WriteLine("cao ni ma leehh");
            if (!isValid()) return;
            try
            {
                using (SqlConnection connection = new SqlConnection(GlobalVariable.connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM dbo.\"User\" WHERE username = @Username AND password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@Username", tbUsername.Text);
                        command.Parameters.AddWithValue("@Password", tbPassword.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Login Berhasil");
                                reader.Read();
                                User currentUser = new User(
                                    (int)reader["user_id"],
                                    reader["name"].ToString(),
                                    reader["username"].ToString(),
                                    reader["password"].ToString()
                                    );
                                Dashboard.Dashboard dashboard = new Dashboard.Dashboard(currentUser);
                                GlobalVariable.currentUser = currentUser;
                                dashboard.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Username/Password salah");
                            }
                            // while (reader.Read())
                            // {
                            //     // Process data from the query result
                            //     Console.WriteLine($"UserID: {reader["UserID"]}, Username: {reader["Username"]}, ...");
                            // }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
