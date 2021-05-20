using BookStore.Models;
using BookStore.Services;
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
            IsBusy = false;
            Books = new ObservableCollection<Book>();
            LoadBooks();

            RefreshCommand = new Command(Refresh);

        }

        public async Task LoadBooks()
        {
            IsBusy = true;
            OnPropertyChanged(nameof(IsBusy));
            var books = await API.shared.GetBooks();
            Books.Clear();
            foreach (Book book in books)
            {
                Books.Add(book);
            }
            IsBusy = false;
            OnPropertyChanged(nameof(Books));
            OnPropertyChanged(nameof(IsBusy));
            
        }

        public async void Refresh()
        {
            await LoadBooks();
        }

        public async void AddBook()
        {

        }

        public async void DeleteBook()
        {

        }
    }

}
