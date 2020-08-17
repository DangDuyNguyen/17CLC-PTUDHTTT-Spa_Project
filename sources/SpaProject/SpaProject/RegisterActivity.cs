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

namespace SpaProject
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Register);

            TextView LoginTrans = FindViewById<TextView>(Resource.Id.registerTrans);

            LoginTrans.Click += LoginTrans_Click;
        }

        private void LoginTrans_Click(object sender, EventArgs e)
        {
            this.Finish();
        }
    }
}