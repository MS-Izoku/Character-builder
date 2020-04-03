using System;

namespace testMVC{
    public class Book{
        public string title {get; set;}
        public string description {get; set;} // used in the the thumbnail
        public string imgUrl {get; set;}
        // has many chapters
    }
}