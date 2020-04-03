using System;

namespace testMVC{
    public class DocumentSection{
        public string title {get; set;} // displayed as an h element
        public string content {get; set;} // richtext
        // has many document-sections (many of itself)
    }
}