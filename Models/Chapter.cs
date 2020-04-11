using System;

// belongs to a book
// books have many chapters
namespace testMVC.Models {
    public class Chapter {
        public int Id { get; set; }
        public string title { get; set; }
        public string text { get; set; }

        public int BookId {get; set;}   // connects to the book it belongs to 
        public int ChapterIndex {get; set;} // the local index of the chapter in the book context (ie: ch.1 , ch.2)
    }
}