using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Data;
using System.Windows.Forms;


namespace ok
{
    public partial class Form2 : Form
    {
        DataTable dt = new DataTable();

        IFirebaseConfig config = new FirebaseConfig
        {

            AuthSecret = "twxP9wo2ngpBpu5yQzgWRCNT7BVCM4HH7jAoXbfz",
            BasePath = "https://gndi-system.firebaseio.com/"
        };
        IFirebaseClient client;
        private object pass;

        public Form2()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                //Getting the connection
                client = new FireSharp.FirebaseClient(config);

                if (client != null)
                {
                   // this.CenterToScreen();
                   // this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                   // this.WindowState = FormWindowState.Normal;

                }
            }
            catch
            {
                MessageBox.Show("Connection Fail");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Show password using checkbox
            /*   if (checkBox1.Checked)
               {
                   pass.UseSystemPasswordChar = false;
               }
               else {
                   pass.UseSystemPasswordChar = true ;
               }*/
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"Users/" + UsernameTbox.Text);
            MyUser ResUser = res.ResultAs<MyUser>();// database result

            MyUser CurUser = new MyUser() // USER GIVEN INFO
            {
                Username = UsernameTbox.Text,
                Password = passTbox.Text
            };

            if (MyUser.IsEqual(ResUser, CurUser))
            {
                Form1 real = new Form1();
                real.ShowDialog();
            }

            else
            {
                MyUser.ShowError();
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            
            Form3 reg = new Form3();
            reg.ShowDialog();
            
        }
    }
}