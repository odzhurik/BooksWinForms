﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWF.Models.Instances
{
    public class Newspaper : PolygraphicItem,IIssueItem,IPeriodicalItem
    {
        public string Periodical { get; set; }
        public string IssueNumber { get; set; }

    }
}
