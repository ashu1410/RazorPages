﻿using System;
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
    public class CategoriesModel : PageModel
    {
        private readonly IResourceRepository resourceRepository;

        public IEnumerable<resPage> resPages { get; set; }

        public CategoriesModel(IResourceRepository resourceRepository)
        {
            this.resourceRepository = resourceRepository;
        }
        public void OnGet()
        {
            resPages = resourceRepository.GetAllResources();

        }
    }
}