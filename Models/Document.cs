using System;

namespace testMVC.Models{
    public class Document{
        [Key]
        public int Id {get; set;}
        public string title {get; set;}
        public string content {get; set;}
    }
}