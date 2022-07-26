﻿using System;
using System.Collections.Generic;

namespace BackEndProject.Models
{
    public class Brand
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public Nullable<DateTime> CreatedAt { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }
        public Nullable<DateTime> UptadetAt { get; set; }

        public List<Product> Products { get; set; }
    }
}
