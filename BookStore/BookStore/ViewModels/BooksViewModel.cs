using BookStore.Models;
using BookStore.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using Xamarin.Forms;

namespace BookStore.ViewModels
{
    public class BooksViewModel: BindableObject
    {
        public ObservableCollection<Book> Books { get; set; }

        public BooksViewModel()
        {
            Books = new ObservableCollection<Book>();
            LoadBooks();
        }

        public async void LoadBooks()
        {
            var books = await API.shared.GetBooks();
            Books.Clear();
            foreach (Book book in books)
            {
                Books.Add(book);
            }
            OnPropertyChanged(nameof(Books));
        }

        public void ToolbarItem_Clicked()
        {

        }
    }

}
