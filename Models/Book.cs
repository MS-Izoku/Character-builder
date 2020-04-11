using System;

// Has-many chapters
// belongs to a project
namespace testMVC.Models{
    public class Book{
        public int Id {get; set;}
        public int projectId {get; set;}    // connects to the Project that it belongs to
        public string title {get; set;}
        public string summary {get; set;}
    }
}