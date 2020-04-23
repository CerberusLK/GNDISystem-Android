using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase.Database;
using GNDISystemFinal.Data_Models;
using GNDISystemFinal.Helpers;

namespace GNDISystemFinal.EventListners
{
    public class memberListner : Java.Lang.Object, IValueEventListener
    {
        List<member> memberList = new List<member>();

        public event EventHandler<MemberDataEventArgs> memberRetrived;

        public class MemberDataEventArgs : EventArgs
        {
            public List<member> Member { get; set; }
        }

        public new void Dispose()
        {
            //throw new NotImplementedException();
        }

        public void OnCancelled(DatabaseError error)
        {
            //throw new NotImplementedException();

        }

        public void OnDataChange(DataSnapshot snapshot)
        {
            if(snapshot.Value != null)
            {
                var child = snapshot.Children.ToEnumerable<DataSnapshot>();
                memberList.Clear();
                foreach(DataSnapshot memberData in child)
                {
                    member member = new member();
                    member.birthday = memberData.Child("Birthday").Value.ToString();
                    member.name = memberData.Child("fullName").Value.ToString();
                    memberList.Add(member);
                }
                memberRetrived.Invoke(this, new MemberDataEventArgs { Member = memberList });
            }
        }

        public void create()
        {
            DatabaseReference memberRef = AppDataHelper.GetDatabase().GetReference("Member");
            memberRef.AddValueEventListener(this);
        }
    }
}