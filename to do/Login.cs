namespace to_do
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string admin, pass;
            admin = AdminBox.Text;
            pass = PassBox.Text;
            if (admin == "Admin" && pass == "1234")
            {
                Home home= new Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("ERROR!!!!!");
            }

        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            AdminBox.Text = "";
            PassBox.Text = "";
        }
    }
}