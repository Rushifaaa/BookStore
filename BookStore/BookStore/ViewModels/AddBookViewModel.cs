using BookStore.Models;
using BookStore.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BookStore.ViewModels
{
    public class AddBookViewModel: BindableObject
    {
        public Book NewBook { get; set; } = new Book();
        public Command AddCommand { get; set; }

        public AddBookViewModel()
        {
            AddCommand = new Command(AddBook);
        }

        public async void AddBook()
        {
            await API.shared.AddBook(NewBook);
        }
    }
}
