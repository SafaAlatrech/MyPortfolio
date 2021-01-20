﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class PortfolioViewModel
    {
        public Guid Id { get; set; }
        public int Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public IFormFile File { get; set; }

    }
}
