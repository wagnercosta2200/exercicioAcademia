using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWordController : Controller
    {
        // get HelloWord
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome(string nome, int vezes = 1, int ID = 1)
        {

            return HtmlEncoder.Default.Encode($"oi {nome}, vezes: {vezes}, ID: {ID}");

            //metodo teste
        }
            public string teste()
            {
                return " aqui é so mostrar como funcina a relação rota x metodo dentro da controller";
            }
        }
    }


