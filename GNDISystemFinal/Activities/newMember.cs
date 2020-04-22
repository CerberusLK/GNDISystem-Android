using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace GNDISystemFinal.Activities
{
    [Activity(Label = "@string/app_name", NoHistory =false, MainLauncher =false)]
    public class newMember : AppCompatActivity, Android.App.DatePickerDialog.IOnDateSetListener
    {
        TextInputLayout fullName;
        TextInputLayout nic;
        Button selectDate;
        TextView selectedDate;
        TextInputLayout email;
        TextInputLayout telephone;
        Button submitButton;
        Button cancelButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.newMember);
            fullName = (TextInputLayout)FindViewById(Resource.Id.fullNameText);
            nic = (TextInputLayout)FindViewById(Resource.Id.NICText);
            selectDate = (Button)FindViewById(Resource.Id.selectBirthdayButton);
            email = (TextInputLayout)FindViewById(Resource.Id.emailText);
            telephone = (TextInputLayout)FindViewById(Resource.Id.phoneNumberText);
            submitButton = (Button)FindViewById(Resource.Id.newMemberSubmitButton);
            cancelButton = (Button)FindViewById(Resource.Id.newMemberSubmitCancelButton);
            selectedDate = (TextView)FindViewById(Resource.Id.selectedDateLabel);

            selectDate.Click += SelectDate_Click;
            cancelButton.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };
            // Create your application here
        }

        private void SelectDate_Click(object sender, EventArgs e)
        {
            var dateTimeNow = DateTime.Now;
            DatePickerDialog datePicker = new DatePickerDialog(this, this, dateTimeNow.Year, dateTimeNow.Month, dateTimeNow.Day);
            datePicker.Show();
        }
        public void OnDateSet(DatePicker view, int year, int month, int dayOfMonth)
        {
            selectedDate.Text = new DateTime(year, month, dayOfMonth).ToShortDateString();
        }
    }
}