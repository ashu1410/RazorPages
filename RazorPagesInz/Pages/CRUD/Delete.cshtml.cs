using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor.Models;
using Razor.Services;

namespace RazorPagesInz.Pages.CRUD
{
    public class DeleteModel : PageModel
    {
        private readonly IResourceRepository resourceRepository;

        [BindProperty]
        public resPage resToDel { get; set; }

        public DeleteModel(IResourceRepository resourceRepository)
        {
            this.resourceRepository = resourceRepository;
        }
        public IActionResult OnGet(int id)
        {
            resourceRepository.GetResPage(id);
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            resourceRepository.Delete(id);
            return RedirectToPage("/AdminPage");
        }
    }
}