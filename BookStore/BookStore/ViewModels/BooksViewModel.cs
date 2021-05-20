using BookStore.Models;
using BookStore.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using Xamarin.Forms;

namespace BookStore.ViewModels
{
    class BooksViewModel: BindableObject
    {
        public ObservableCollection<Book> Books { get; set; }

        public BooksViewModel()
        {
            Books = new ObservableCollection<Book>();
            LoadBooks();
        }

        public async void LoadBooks()
        {
            Books = await API.shared.GetBooks();
        }
    }

}
