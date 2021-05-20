using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BookStore.ViewModels
{
    public class AboutViewModel
    {
        public ICommand OpenWebCommand { get; }

        public AboutViewModel()
        {
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }
    }
}