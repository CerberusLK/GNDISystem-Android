using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Firebase;
using Firebase.Database;
using GNDISystemFinal.Fragment;

namespace GNDISystemFinal.Activities
{
    [Activity(Label = "LoginFormActivity", MainLauncher =true, NoHistory =true)]
    public class LoginFormActivity : AppCompatActivity
    {
        Button connectionTest;
        FirebaseDatabase database;
        RecyclerView MyRecyclerView;
        ImageView addMember;
        addMemberFragment addmemberfragment;
        Button selectDate;
        Button submitNewMember;
        TextView selectBirthday;
        Button cancelNewMemberSubmit;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetContentView(Resource.Layout.LoginForm);
            base.OnCreate(savedInstanceState);
            Button btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnLogin.Click += delegate
            {
                StartActivity(typeof(MainActivity));

            };

            //connection test purpose only
            connectionTest = FindViewById<Button>(Resource.Id.btnTestConnection);
            connectionTest.Click += ConnectionTest_Click;
        }
        private void ConnectionTest_Click(object sender, EventArgs e)
        {
            Initializedatabase();
        }

        void Initializedatabase()
        {
            var app = FirebaseApp.InitializeApp(this);
            if (app == null)
            {
                var option = new FirebaseOptions.Builder()
                    .SetApplicationId("gndisystem-faf8d")
                    .SetApiKey("AIzaSyClyXwKkJLudsnvwcdkybFGNbXxKZlvCTs")
                    .SetDatabaseUrl("https://gndisystem-faf8d.firebaseio.com")
                    .SetStorageBucket("gndisystem-faf8d.appspot.com")
                    .Build();
                app = FirebaseApp.InitializeApp(this, option);
                database = FirebaseDatabase.GetInstance(app);
            }
            else
            {
                database = FirebaseDatabase.GetInstance(app);
            }
            database = FirebaseDatabase.GetInstance(app);
            DatabaseReference dbref = database.GetReference("UserSupport");
            dbref.SetValue("Ticket2");
            Toast.MakeText(this, "Completed", ToastLength.Short).Show();
        }
    }
}