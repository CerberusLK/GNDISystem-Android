using System;

using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;

namespace GNDISystemFinal.Adapter
{
    class memberAdapter : RecyclerView.Adapter
    {
        public event EventHandler<memberAdapterClickEventArgs> ItemClick;
        public event EventHandler<memberAdapterClickEventArgs> ItemLongClick;
        string[] items;

        public memberAdapter(string[] data)
        {
            items = data;
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
            var item = items[position];

            // Replace the contents of the view with that element
            var holder = viewHolder as memberAdapterViewHolder;
            //holder.TextView.Text = items[position];
        }

        public override int ItemCount => items.Length;

        void OnClick(memberAdapterClickEventArgs args) => ItemClick?.Invoke(this, args);
        void OnLongClick(memberAdapterClickEventArgs args) => ItemLongClick?.Invoke(this, args);

    }

    public class memberAdapterViewHolder : RecyclerView.ViewHolder
    {
        //public TextView TextView { get; set; }


        public memberAdapterViewHolder(View itemView, Action<memberAdapterClickEventArgs> clickListener,
                            Action<memberAdapterClickEventArgs> longClickListener) : base(itemView)
        {
            //TextView = v;
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