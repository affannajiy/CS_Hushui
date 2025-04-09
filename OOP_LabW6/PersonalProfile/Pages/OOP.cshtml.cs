using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PersonalProfile.Pages
{
    public class OOPModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public OOPModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
