using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Razor.Models;
using Razor.Services;

namespace RazorPagesInz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly IResourceRepository resourceRepository;

        public IEnumerable<resPage> resPages;

        public IndexModel(IResourceRepository resourceRepository, ILogger<IndexModel> logger)
        {
            this.resourceRepository = resourceRepository;
            _logger = logger;
        }

        [BindProperty(SupportsGet =true)]
        public string searchPhrase { get; set; }

        public void OnGet()
        {
            resPages=resourceRepository.searchPhrase(searchPhrase);
        }

    }
}
