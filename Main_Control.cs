using Npgsql;
using System.Text;

namespace FlightCrane
{
    public partial class Main_Control : Form
    {
        public Main_Control()
        {
            InitializeComponent();
            textBox_login.MaxLength = 30;
            textBox_password.MaxLength = 30;

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            // „P„p„‚„p„}„u„„„‚„ „„€„t„{„|„„‰„u„~„y„‘
            string host = "217.71.129.139";
            string database = "aero";
            string user = "air";
            string password = "Malidivi6";
            int port = 4671; // „R„„„p„~„t„p„‚„„„~„„z „„€„‚„„ PostgreSQL

            // „R„„„‚„€„{„p „„€„t„{„|„„‰„u„~„y„‘
            string connectionString = $"Host={host};Database={database};Username={user};Port={port}";

            string login = textBox_login.Text.Trim();
            string pass = textBox_password.Text.Trim();


            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT password_hash FROM Users WHERE login = @login";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string passwordHashFromDB = reader.GetString(reader.GetOrdinal("password_hash"));

                                // „P„‚„€„r„u„‚„{„p „r„r„u„t„u„~„~„€„s„€ „„p„‚„€„|„‘ „ƒ „‡„„Š„u„} „y„x „A„D
                                if (BCrypt.Net.BCrypt.Verify(pass, passwordHashFromDB))
                                {
                                    this.Visible = false;
                                    Work work = new Work();
                                    work.Show();                                    
                                }
                                else
                                {
                                    MessageBox.Show("„N„u„„‚„p„r„y„|„„~„„z „„p„‚„€„|„", "„O„Š„y„q„{„p", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("„P„€„|„„x„€„r„p„„„u„|„ „~„u „~„p„z„t„u„~", "„O„Š„y„q„{„p", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"„O„Š„y„q„{„p „„‚„y „r„„„€„|„~„u„~„y„y „x„p„„‚„€„ƒ„p: {ex.Message}", "„O„Š„y„q„{„p", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.Show();
        }

        private void fogot_password_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }
    }
}