using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models
{

    [Serializable]
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public bool IsAvailable { get; set; }
        public string ISBN { get; set; }
    }
}
