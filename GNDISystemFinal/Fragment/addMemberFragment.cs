using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace GNDISystemFinal.Fragment
{
    public class addMemberFragment : Android.Support.V4.App.DialogFragment
    {
        TextInputLayout fullName;
        TextInputLayout NIC;
        DatePicker birthday;
        TextInputLayout email;
        TextInputLayout phoneNumber;
        Button newMemberSubmit;
        Button selectBirthday;
        TextView selectedDate;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            View view = inflater.Inflate(Resource.Layout.newMember, container, false);
            fullName = (TextInputLayout)view.FindViewById(Resource.Id.fullNameText);
            NIC = (TextInputLayout)view.FindViewById(Resource.Id.NICText);
            birthday = (DatePicker)view.FindViewById(Resource.Id.birthdayDatePicker);
            email = (TextInputLayout)view.FindViewById(Resource.Id.emailText);
            phoneNumber = (TextInputLayout)view.FindViewById(Resource.Id.phoneNumberText);
            newMemberSubmit = (Button)view.FindViewById(Resource.Id.newMemberSubmitButton);
            selectBirthday = (Button)view.FindViewById(Resource.Id.selectBirthdayButton);

            selectBirthday.Click += SelectBirthday_Click;
            return view;
        }

        private void SelectBirthday_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}