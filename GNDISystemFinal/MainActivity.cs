using System;
using Android;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Firebase;
using Firebase.Database;
using GNDISystemFinal.Fragment;

namespace GNDISystemFinal
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = false)]

    public class MainActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener, Android.App.DatePickerDialog.IOnDateSetListener
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
            SetContentView(Resource.Layout.activity_main);
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            //SetContentView(Resource.Layout.LoginForm);
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();

            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.SetNavigationItemSelectedListener(this);

            //content page items
            MyRecyclerView = (RecyclerView)FindViewById(Resource.Id.myRecyclerView);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            
            addMember = (ImageView)FindViewById(Resource.Id.btnAddMember);
            addMember.Click += AddMember_Click;
        }

        private void AddMember_Click(object sender, EventArgs e)
        {
            /*addmemberfragment = new addMemberFragment();
            var trans = SupportFragmentManager.BeginTransaction();
            addmemberfragment.Show(trans,"new member");*/
            selectDate = (Button)FindViewById(Resource.Id.selectBirthdayButton);
            cancelNewMemberSubmit= (Button)FindViewById(Resource.Id.newMemberSubmitCancelButton);
            selectBirthday = (TextView)FindViewById(Resource.Id.selectedDateLabel);
            SetContentView(Resource.Layout.newMember);
            selectDate.Click += SelectDate_Click;
            cancelNewMemberSubmit.Click += CancelNewMemberSubmit_Click;
        }

        private void CancelNewMemberSubmit_Click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.activity_main);
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();

            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.SetNavigationItemSelectedListener(this);

            //content page items
            MyRecyclerView = (RecyclerView)FindViewById(Resource.Id.myRecyclerView);
            addMember = (ImageView)FindViewById(Resource.Id.btnAddMember);
            addMember.Click += AddMember_Click;
        }

        private void SelectDate_Click(object sender, EventArgs e)
        {
            var dateTimeNow = DateTime.Now;
            DatePickerDialog datePicker = new DatePickerDialog(this, this, dateTimeNow.Year, dateTimeNow.Month, dateTimeNow.Day);
            datePicker.Show();
        }

        public void OnDateSet(DatePicker view, int year, int month, int dayOfMonth)
        {
            selectBirthday.Text = new DateTime(year, month, dayOfMonth).ToShortDateString();
        }

        public override void OnBackPressed()
        {
            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            if(drawer.IsDrawerOpen(GravityCompat.Start))
            {
                drawer.CloseDrawer(GravityCompat.Start);
                SetContentView(Resource.Layout.activity_main);
            }
            else
            {
                base.OnBackPressed();
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            int id = item.ItemId;

            if (id == Resource.Id.nav_camera)
            {
                // Handle the camera action
            }
            else if (id == Resource.Id.nav_gallery)
            {

            }
            else if (id == Resource.Id.nav_slideshow)
            {

            }
            else if (id == Resource.Id.nav_manage)
            {

            }
            else if (id == Resource.Id.nav_share)
            {

            }
            else if (id == Resource.Id.nav_send)
            {

            }

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawer.CloseDrawer(GravityCompat.Start);
            return true;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }


    }
}

