using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TSSDependencyInjection.Services.Interfaces;

namespace TSSDependencyInjection.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly ITransientService _transientService;
        private readonly IScopeService _scopeService;
        private readonly ISingletonService _singletonService;
        private readonly ITransientService _transientService2;
        private readonly IScopeService _scopeService2;
        private readonly ISingletonService _singletonService2;
        public IndexModel(
            ILogger<IndexModel> logger,
            ITransientService transientService,
            IScopeService scopeService,
            ISingletonService singletonService,
            ITransientService transientService2,
            IScopeService scopeService2,
            ISingletonService singletonService2
         )
        {
            _logger = logger;

            _transientService = transientService;
            _scopeService = scopeService;
            _singletonService = singletonService;
            _transientService2 = transientService2;
            _scopeService2 = scopeService2;
            _singletonService2 = singletonService2;
        }

        public void OnGet()
        {
            ViewData["Transient1_Id"] = _transientService.GetId().ToString();
            ViewData["Transient2_Id"] = _transientService2.GetId().ToString();
            ViewData["Scope1_Id"] = _scopeService.GetId().ToString();
            ViewData["Scope2_Id"] = _scopeService2.GetId().ToString();
            ViewData["Singleton1_Id"] = _singletonService.GetId().ToString();
            ViewData["Singleton2_Id"] = _singletonService2.GetId().ToString();
        }
    }
}