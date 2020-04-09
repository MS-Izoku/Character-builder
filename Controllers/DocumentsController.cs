using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace testMVC.Controllers
{
    public class DocumentsController : Controller
    {

        public string Index()
        {
            return "Allo";
        }

        
        public string Show()
        {
            return "Allo";
        }
    }
}