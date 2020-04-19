using System;

using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using System.Collections.Generic;
using GNDISystemFinal.Data_Models;

namespace GNDISystemFinal.Adapter
{
    class memberAdapter : RecyclerView.Adapter
    {
        public event EventHandler<memberAdapterClickEventArgs> ItemClick;
        public event EventHandler<memberAdapterClickEventArgs> ItemLongClick;
        List<member> Items;

        public memberAdapter(List<member> data)
        {
            Items = data;
        }

        // Create new views (invoked by the layout manager)
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            //Setup your layout here
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.memberRow, parent, false);//added member row to the recycyler view
            var vh = new memberAdapterViewHolder(itemView, OnClick, OnLongClick);
            return vh;
        }

        // Replace the contents of a view (invoked by the layout manager)
        public override void OnBindViewHolder(RecyclerView.ViewHolder viewHolder, int position)
        {
            var item = Items[position];

            // Replace the contents of the view with that element
            var holder = viewHolder as memberAdapterViewHolder;
            //holder.TextView.Text = items[position];
            holder.lblName.Text = Items[position].name;
            holder.lblBirthday.Text = Items[position].birthday;
            holder.lblAge.Text = Items[position].age;
            holder.lblVStatus.Text = Items[position].voteEligibility;
        }

        public override int ItemCount => Items.Count;

        void OnClick(memberAdapterClickEventArgs args) => ItemClick?.Invoke(this, args);
        void OnLongClick(memberAdapterClickEventArgs args) => ItemLongClick?.Invoke(this, args);

    }

    public class memberAdapterViewHolder : RecyclerView.ViewHolder
    {
        //public TextView TextView { get; set; }
        public TextView lblName { get; set; }
        public TextView lblBirthday { get; set; }
        public TextView lblAge { get; set; }
        public TextView lblVStatus { get; set; }
        public ImageView btnEditMember { get; set; }


        public memberAdapterViewHolder(View itemView, Action<memberAdapterClickEventArgs> clickListener,
                            Action<memberAdapterClickEventArgs> longClickListener) : base(itemView)
        {
            //TextView = v;

            //Bind the xml controllers to the c# variables
            lblName = (TextView)itemView.FindViewById(Resource.Id.lblName);
            lblBirthday = (TextView)itemView.FindViewById(Resource.Id.lblBirthday);
            lblAge = (TextView)itemView.FindViewById(Resource.Id.lblAge);
            lblVStatus = (TextView)itemView.FindViewById(Resource.Id.lblVStatus);
            btnEditMember = (ImageView)itemView.FindViewById(Resource.Id.btnEditMember);

            itemView.Click += (sender, e) => clickListener(new memberAdapterClickEventArgs { View = itemView, Position = AdapterPosition });
            itemView.LongClick += (sender, e) => longClickListener(new memberAdapterClickEventArgs { View = itemView, Position = AdapterPosition });
        }
    }

    public class memberAdapterClickEventArgs : EventArgs
    {
        public View View { get; set; }
        public int Position { get; set; }
    }
}