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
    public class member
    {
        public String name { get; set; }
        public String birthday { get; set; }
        public String age { get; set; }
        public String voteEligibility { get; set; }
        public String citizenNumber { get; set; }
    }
}