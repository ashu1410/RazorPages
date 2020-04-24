using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Razor.Models;
using Razor.Services;

namespace RazorPagesInz.Pages.CRUD
{
    public class EditModel : PageModel
    {
        private readonly IResourceRepository resourceRepository;

        public EditModel(IResourceRepository resourceRepository)
        {
            this.resourceRepository = resourceRepository;
        }

        [BindProperty]
        public resPage resPage { get; set; }

        public IActionResult OnGet(int id)
        {
            resPage = resourceRepository.GetResPage(id);
            if (resPage == null)
            {
               return RedirectToPage("Index");
            }
            return Page();
        }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                switch (resPage.resCat)
                {
                    case ResCategory.Administration:
                        resPage.Img_path = "~/resource/os1.jpg";
                        break;
                    case ResCategory.Database:
                        resPage.Img_path = "~/resource/db.png";
                        break;
                    case ResCategory.Web:
                        resPage.Img_path = "~/resource/web.jpg";
                        break;
                    case ResCategory.Language:
                        resPage.Img_path = "~/resource/desktop.jpg";
                        break;
                    default:
                        break;

                }
                resPage = resourceRepository.Update(resPage);
                return RedirectToPage("/AdminPage");
            }
            else
                return Page();
        }
    }
}