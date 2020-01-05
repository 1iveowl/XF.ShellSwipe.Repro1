using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using ShellSwipeRepro1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellSwipeRepro1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private int _left;
        private int _right;

        public ObservableCollection<Item> ObservableCollection { get; set; }

        public Page1()
        {
            ObservableCollection = new ObservableCollection<Item>();

            InitializeComponent();

            MyCollectionView.ItemsSource = ObservableCollection;

            SingleSwipeItem.LeftItems.FirstOrDefault().Command = new Command(() => {});

            SingleSwipeItem.RightItems.FirstOrDefault().Command = new Command(() => { });

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

        private void SwipeGestureRecognizer_OnSwipedLeft(object sender, SwipedEventArgs e)
        {
            _left++;

            LeftSwipeLabel.Text = $"Left swipes on green box: {_left}";
        }

        private void SwipeGestureRecognizer_OnSwipedRight(object sender, SwipedEventArgs e)
        {
            _right++;

            RightSwipeLabel.Text = $"Right swipes on green box: {_right}";
        }
    }
}