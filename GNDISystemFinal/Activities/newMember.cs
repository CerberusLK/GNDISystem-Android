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
using Firebase.Database;
using GNDISystemFinal.Helpers;
using Java.Util;

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
        string birthday;

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
            submitButton.Click += delegate
            {
                string fullNameText = fullName.EditText.Text;
                string nicText = nic.EditText.Text;
                string emailText = email.EditText.Text;
                string telephoneText = telephone.EditText.Text;
                string selectedDateText = selectDate.Text;

                HashMap memberInfo = new HashMap();
                memberInfo.Put("fullName", fullNameText);
                memberInfo.Put("NIC", nicText);
                memberInfo.Put("Email", emailText);
                memberInfo.Put("telephone Number", telephoneText);
                memberInfo.Put("Birthday", birthday);

                Android.App.AlertDialog.Builder saveMemberAlert = new Android.App.AlertDialog.Builder(this);
                saveMemberAlert.SetTitle("Save Alumni Info");
                saveMemberAlert.SetMessage("Are you sure?");
                saveMemberAlert.SetPositiveButton("Continue", (senderAlert, args) =>
                {
                    DatabaseReference newMemberRef = AppDataHelper.GetDatabase().GetReference("Member").Push();
                    newMemberRef.SetValue(memberInfo);
                    StartActivity(typeof(MainActivity));
                    this.Dispose();

                });
                saveMemberAlert.SetNegativeButton("Cancel", (senderAlert, args) =>
                {
                    saveMemberAlert.Dispose();
                });

                saveMemberAlert.Show();
            };

            //submitButton.Click += SubmitButton_Click;
            // Create your application here
        }

        /*private void SubmitButton_Click(object sender, EventArgs e)
        {
            string fullNameText = fullName.EditText.Text;
            string nicText = nic.EditText.Text;
            string emailText = email.EditText.Text;
            string telephoneText = telephone.EditText.Text;
            string selectedDateText = selectDate.Text;

            HashMap memberInfo = new HashMap();
            memberInfo.Put("fullName", fullNameText);
            memberInfo.Put("NIC", nicText);
            memberInfo.Put("Email", emailText);
            memberInfo.Put("telephone Number", telephoneText);
            memberInfo.Put("Birthday", birthday);

            Android.App.AlertDialog.Builder saveMemberAlert = new Android.App.AlertDialog.Builder(this);
            saveMemberAlert.SetTitle("Save Alumni Info");
            saveMemberAlert.SetMessage("Are you sure?");
            saveMemberAlert.SetPositiveButton("Continue", (senderAlert, args) =>
            {
                DatabaseReference newMemberRef = AppDataHelper.GetDatabase().GetReference("Member").Push();
                newMemberRef.SetValue(memberInfo);
                this.Dispose();
            });
            saveMemberAlert.SetNegativeButton("Cancel", (senderAlert, args) =>
            {
                saveMemberAlert.Dispose();
            });

            saveMemberAlert.Show();
        }*/

        private void SelectDate_Click(object sender, EventArgs e)
        {
            var dateTimeNow = DateTime.Now;
            DatePickerDialog datePicker = new DatePickerDialog(this, this, dateTimeNow.Year, dateTimeNow.Month, dateTimeNow.Day);
            datePicker.Show();
        }
        public void OnDateSet(DatePicker view, int year, int month, int dayOfMonth)
        {
            birthday = new DateTime(year, month+1, dayOfMonth).ToShortDateString();
            selectedDate.Text= new DateTime(year, month + 1, dayOfMonth).ToShortDateString();
        }
    }
}