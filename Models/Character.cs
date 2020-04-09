using System;

namespace testMVC.Models{
    public class Character{
        public int Id {get; set;}
        public int ProjectId {get; set;}    // connects to the project it belongs to
    }
}