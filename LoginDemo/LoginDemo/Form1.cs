using System.Data.SqlClient; // This library has been added for SQL operations.

namespace LoginDemo

{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("server=.; Initial Catalog=logindemodb;Integrated Security=SSPI");
        // SqlConnection object is created and connection information defined for SQL connection.   
        SqlCommand? cmd;
        // SQLCommand object was then created to write SQL commands.
        public Point mouseLocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        // Events to take place when the program is started.
        // The same events occur when loginLbl and registerLbl are clicked.
        private void Form1_Load(object sender, EventArgs e)
        {
            headerLbl.Visible = true;
            signinBtn.Visible = false;
            signupBtn.Visible = false;
            usernameLbl.Visible = false;
            passwordLbl.Visible = false;
            rePasswordLbl.Visible = false;
            usernameField.Visible = false;
            passwordField.Visible = false;
            rePasswordField.Visible = false;
            connection_status.Visible = false;
        }

        // When loginLbl is clicked, the login components are activated. 
        private void loginLbl_Click(object sender, EventArgs e)
        {
            loginLbl.Text = "> Login";
            registerLbl.Text = "Register";
            signupBtn.Visible = false;
            rePasswordField.Visible = false;
            rePasswordLbl.Visible = false;
            headerLbl.Visible = false;
            signinBtn.Visible = true;
            usernameLbl.Visible = true;
            passwordLbl.Visible = true;
            usernameField.Visible = true;
            passwordField.Visible = true;
            connection_status.Visible = true;
        }

        // When registerLbl is clicked, the register components are activated.
        private void registerLbl_Click(object sender, EventArgs e)
        {
            registerLbl.Text = "> Register";
            loginLbl.Text = "Login";
            signinBtn.Visible = false;
            headerLbl.Visible = false;
            rePasswordField.Visible = true;
            rePasswordLbl.Visible = true;
            signupBtn.Visible = true;
            usernameLbl.Visible = true;
            passwordLbl.Visible = true;
            usernameField.Visible = true;
            passwordField.Visible = true;
            connection_status.Visible = true;
        }

        // When pictureBox1 clicked closing form application.
        // If you want close the application, click to red x icon.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // When signupBtn is clicked the user is saved in the database.
        private void signupBtn_Click(object sender, EventArgs e)
        {

            if (usernameField.Text.Length != 0 && passwordField.Text.Length != 0 && usernameControl() == true && passwordControl() == true)
            {
                cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO account (username, password) VALUES (@username, @password)";
                cmd.Parameters.AddWithValue("@username", usernameField.Text);
                cmd.Parameters.AddWithValue("@password", passwordField.Text);
                
                cmd.ExecuteNonQuery();
                conn.Close();
                connection_status.Text = "Succesfull.";
            }
            else
            {
                connection_status.Text = "Error!";
            }
        }

        // If both password field text equals return true.
        bool passwordControl()
        {
            if (passwordField.Text == rePasswordField.Text) { return true; }
            return false;
        }

        // If username field text and username registered in the database equals return false, if else return true. 
        bool usernameControl()
        {
            string? usernameTemp = null;
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT username FROM account WHERE username = @username";
            cmd.Parameters.AddWithValue("@username", usernameField.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                usernameTemp = reader.GetValue(0).ToString();
            }
            conn.Close();

            if (usernameTemp == usernameField.Text) { return false; }
            return true;
        }

        // When the user wants to login to the system, clicks on signinBtn and the user information is checked from the database.
        private void signinBtn_Click(object sender, EventArgs e)
        {
            if (usernameField.Text.Length != 0 && passwordField.Text.Length != 0)
            {
                cmd = new SqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT username, password FROM account WHERE username = @username AND password = @password";
                cmd.Parameters.AddWithValue("@username", usernameField.Text);
                cmd.Parameters.AddWithValue("@password", passwordField.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader.GetValue(0).ToString() == usernameField.Text && reader.GetValue(1).ToString() == passwordField.Text)
                    {
                        connection_status.Text = "Loggged in by " + reader.GetValue(0).ToString();
                    }
                }
                else { connection_status.Text = "Not connected!"; }


                conn.Close();
            }
        }
    }
}
