using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ShellSwipeRepro1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellSwipeRepro1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public ObservableCollection<Item> ObservableCollection { get; set; }

        public Page1()
        {
            ObservableCollection = new ObservableCollection<Item>();

            InitializeComponent();

            MyCollectionView.ItemsSource = ObservableCollection;

            ObservableCollection.Add(new Item
            {
                Description = "Item 1",
                Id = "1",
                Text = "Item text 1"
            });

            ObservableCollection.Add(new Item
            {
                Description = "Item  2",
                Id = "2",
                Text = "Text 2"
            });
        }
    }
}