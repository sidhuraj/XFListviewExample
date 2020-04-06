using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;

namespace ListviewExamp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            
            getEmployeeData();

        }

        private async void getEmployeeData()
        {
            List<Vehicle> objVehiclesList = new List<Vehicle>();

            objVehiclesList.Add(new Vehicle { VehicleName = "Honda Active", VehicleNumber = "3065", VehiclePrice = "70000" });
            objVehiclesList.Add(new Vehicle { VehicleName = "Gixer", VehicleNumber = "3065", VehiclePrice = "70000" });
            objVehiclesList.Add(new Vehicle { VehicleName = "Dominor", VehicleNumber = "3065", VehiclePrice = "70000" });
            objVehiclesList.Add(new Vehicle { VehicleName = "Himalaya", VehicleNumber = "3065", VehiclePrice = "70000" });
            objVehiclesList.Add(new Vehicle { VehicleName = "Tiger", VehicleNumber = "3065", VehiclePrice = "70000" });
            objVehiclesList.Add(new Vehicle { VehicleName = "Hero Honda", VehicleNumber = "3065", VehiclePrice = "70000" });


            var lstVehicle = FindViewById<Gallery>(Resource.Id.lvVehicleListView);

            VehicleAdapter vehicleAdapter = new VehicleAdapter(this, objVehiclesList);

            lstVehicle.Adapter = vehicleAdapter;
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}