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
using Java.Lang;

namespace ListviewExamp
{
    public class VehicleAdapter : BaseAdapter
    {
        Activity act;
        List<Vehicle>  vehiclesList;
        public VehicleAdapter(Activity act, List<Vehicle>  vehiclesList)
        {
            this.act = act;
            this.vehiclesList = vehiclesList;
        }

        public override int Count
        {
            get
            {
                return vehiclesList.Count;
            }
        }
           

        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View rootView = LayoutInflater.FromContext(act).Inflate(Resource.Layout.vehicleItem, parent, false);
            var item = vehiclesList[position];


            var vName = rootView.FindViewById<TextView>(Resource.Id.tvName);
            var vNumber = rootView.FindViewById<TextView>(Resource.Id.tvNumber);
            var vPrice = rootView.FindViewById<TextView>(Resource.Id.tvPrice);

            vName.Text = item.VehicleName;
            vNumber.Text = item.VehicleNumber;
            vPrice.Text = item.VehiclePrice;




            return rootView;
        }
    }
}