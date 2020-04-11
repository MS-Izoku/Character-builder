using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using testMVC.Data;

namespace testMVC.Controllers {
    public class DocumentsController : Controller {
        private readonly DocumentorContext _context;

        public DocumentsController (DocumentorContext context) {
            context = _context; // syntax from the docs
        }

        public string Index () {
            return "Allo";
        }

        public string Show () {
            return "Allo";
        }
    }
}