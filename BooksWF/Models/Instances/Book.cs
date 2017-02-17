﻿using BooksWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardProject.Models
{
   internal class Book:PolygraphicItem
    {
        public List <string> Authors { get; set; }
        public Book()
        {
            Authors = new List<string>();
        }
       
    }
}