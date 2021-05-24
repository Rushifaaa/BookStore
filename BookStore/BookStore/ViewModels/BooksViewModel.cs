using BookStore.Models;
using BookStore.Services;
using BookStore.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookStore.ViewModels
{
    public class BooksViewModel: BindableObject
    {
        public ObservableCollection<Book> Books { get; set; }

        public bool IsBusy { get; set; }

        #region Commands
        public Command RefreshCommand { get; }
        public Command AddBookCommand { get; }
        #endregion

        public BooksViewModel()
        {
            Books = new ObservableCollection<Book>();
            _ = LoadBooks();

            RefreshCommand = new Command(Refresh);

        }

        public async Task LoadBooks()
        {
            
            
            var books = await API.shared.GetBooks();
            
            foreach (Book book in books)
            {
                Books.Add(book);
            }
            
            OnPropertyChanged(nameof(Books));
            
        }

        public async void Refresh()
        {
            IsBusy = true;
            OnPropertyChanged(nameof(IsBusy));
            Books.Clear();
            await LoadBooks();
            IsBusy = false;
            OnPropertyChanged(nameof(IsBusy));
        }

        public async void DeleteBook()
        {

        }
    }

}
