using System;

namespace testMVC.Models{
    public class Project{
        public string name {get; set;}
        public string description {get; set;}
        public int authorID {get; set;}
        // has many books, documents
    }
}