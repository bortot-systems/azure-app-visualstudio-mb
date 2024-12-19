using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_app_visualstudio_mb.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            throw new Exception("Testing Insights");
        }
    }

}
