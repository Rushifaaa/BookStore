﻿using BookStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookStore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BooksPage : ContentPage
    {
        public BooksPage()
        {
            InitializeComponent();
            BindingContext = new BooksViewModel();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}