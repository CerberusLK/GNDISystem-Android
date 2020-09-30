using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace ok
{
    public partial class Form3 : Form
    {
        
        IFirebaseConfig ifc= new FirebaseConfig
        {

            AuthSecret = "twxP9wo2ngpBpu5yQzgWRCNT7BVCM4HH7jAoXbfz",
            BasePath = "https://gndi-system.firebaseio.com/"
        };
        IFirebaseClient client;
       

        public Form3()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(UsernameTbox.Text) &&
               string.IsNullOrWhiteSpace(passTbox.Text) &&
               string.IsNullOrWhiteSpace(GenderCbox.Text) &&
               string.IsNullOrWhiteSpace(nameTbox.Text) &&
               string.IsNullOrWhiteSpace(NicTbox.Text))
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }
            #endregion

            MyUser user = new MyUser()
            {
                Username = UsernameTbox.Text,
                Password = passTbox.Text,
                Gender = GenderCbox.Text,
                Fullname = nameTbox.Text,
                NICno = NicTbox.Text
            };

            SetResponse set = client.Set(@"Users/" + UsernameTbox.Text, user);

            MessageBox.Show("Successfully registered!");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("No Internet or Connection Problem");
            }
        }
    }
}
