using System;

// this class will need to be compatable with multiple other text-holding classes
// It should have polymorphic relationships (ie: this is textarea-able, can have a text area)
// should also have recursive reltaionships to sub-text-areas (text areas can have other text areas)
namespace testMVC.Models{
    public class TextArea{
        public int Id {get; set;}
        public string title {get; set;}     // optional title for a section of a doc
        public string content {get; set;}   // store as Richtext
    }
}