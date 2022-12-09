﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMP_reseni.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Disabled { get; set; }
        public string ImageUrl { get; set; }

        public List<SubCategory> SubCategories { get; set; }
        public Category()
        {
            this.SubCategories = new List<SubCategory>();
        }


    }
}
