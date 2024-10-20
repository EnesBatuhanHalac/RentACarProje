﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string AuthorID { get; set; }
        public Author Author { get; set; }
        public string CoverImageURL { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}