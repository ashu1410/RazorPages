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
    public class AddModel : PageModel
    {
        private readonly IResourceRepository resourceRepository;
        [BindProperty]
        public resPage newRes { get; set; }

        public void OnGet()
        {
        }

        public AddModel(IResourceRepository resourceRepository)
        {
            this.resourceRepository = resourceRepository;
        }

        public IActionResult OnPost()
        {

            if (ModelState.IsValid)
            {
                var redirect = "/Error";
                switch (newRes.resCat)
                {
                    case ResCategory.Administration:
                        newRes.Img_path = "~/resources/os1.jpg";
                        resourceRepository.Add(newRes);
                        redirect = "/AdministrationTutorials";
                        break;
                    case ResCategory.Database:
                        newRes.Img_path = "~/resources/db.png";
                        resourceRepository.Add(newRes);
                        redirect = "/DatabaseTutorials";
                        break;
                    case ResCategory.Web:
                        newRes.Img_path = "~/resources/web.jpg";
                        resourceRepository.Add(newRes);
                        redirect = "/WebTutorials";
                        break;
                    case ResCategory.Language:
                        newRes.Img_path = "~/resources/desktop.jpg";
                        resourceRepository.Add(newRes);
                        redirect = "/LangTutorials";
                        break;
                    default:
                        break;

                }
                return RedirectToPage(redirect);
            }
            else
                return Page();
        }
    }
}