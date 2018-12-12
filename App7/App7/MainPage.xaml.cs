using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using App7.MyClasses;

namespace App7
{
    

    public partial class MainPage : ContentPage
    {
        
        public ObservableCollection<MyItem> Items { set; get; }

        private void AddItem(object sender, EventArgs e)
        {
            Items.Add(new MyItem
            {
                Shop = shopEntry.Text,
                Name = nameEntry.Text,
                Price = priceEntry.Text,
                Amount = amountEntry.Text,
                Description = descriptionEntry.Text
            });
            shopEntry.Text = "";
            nameEntry.Text = "";
            priceEntry.Text = "";
            amountEntry.Text = "";
            descriptionEntry.Text = "";
        }

        private void RemoveItem(object sender, EventArgs e)
        {
            MyItem myItem = listView.SelectedItem as MyItem;
            if (myItem != null)
            {
                string str = myItem.ToString()+" removed.";
                DisplayAlert("!",str, "ОK");
                Items.Remove(myItem);
                listView.SelectedItem = null;
            }
        }

        public MainPage()
        {
            InitializeComponent();
            Items = new ObservableCollection<MyItem>
            {
                new MyItem { Shop="Comfy", Name="Samsung", Price="12000", Amount="1", Description="smartfone"},
                new MyItem { Shop="Prom", Name="iPhone", Price="15000", Amount="2", Description="smartfone"},
                new MyItem { Shop="Eldorado", Name="LG", Price="10000", Amount="3", Description="smartfone"},
                new MyItem { Shop="Comfy", Name="Huawei", Price="8000", Amount="4", Description="smartfone"}
            };
            BindingContext = this;
        }
    }
}
