using Microsoft.AspNetCore.Mvc;

namespace NextHorizon.Controllers
{
    public class AgentController : Controller
    {
        public IActionResult HelpCenter()
        {
            return View();
        }
    }
}
