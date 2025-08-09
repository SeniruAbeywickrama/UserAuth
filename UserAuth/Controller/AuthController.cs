using Microsoft.AspNetCore.Mvc;

namespace UserAuth.Controller;

public class AuthController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}