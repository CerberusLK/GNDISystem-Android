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

namespace GNDISystemFinal.Data_Models
{
    class member
    {
        public String name { get; set; }
        public String birthday { get; set; }
        public int age { get; set; }
        public bool voteEligibility { get; set; }
        public String citizenNumber { get; set; }
    }
}