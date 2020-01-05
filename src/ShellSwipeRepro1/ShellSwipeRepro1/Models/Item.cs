using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShellSwipeRepro1.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        public ICommand Right => new Command(() => {});
        public ICommand Left => new Command(() => { });
    }
}