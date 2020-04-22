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
using Firebase;
using Firebase.Database;

namespace GNDISystemFinal.Helpers
{
    public static class AppDataHelper
    {
        public static FirebaseDatabase GetDatabase()
        {
            var app = FirebaseApp.InitializeApp(Application.Context);
            FirebaseDatabase database;
            if (app == null)
            {
                var option = new FirebaseOptions.Builder()
                    .SetApplicationId("gndisystem-faf8d")
                    .SetApiKey("AIzaSyClyXwKkJLudsnvwcdkybFGNbXxKZlvCTs")
                    .SetDatabaseUrl("https://gndisystem-faf8d.firebaseio.com")
                    .SetStorageBucket("gndisystem-faf8d.appspot.com")
                    .Build();
                app = FirebaseApp.InitializeApp(Application.Context, option);
                database = FirebaseDatabase.GetInstance(app);
            }
            else
            {
                database = FirebaseDatabase.GetInstance(app);
            }
            return database;
        }
    }
}