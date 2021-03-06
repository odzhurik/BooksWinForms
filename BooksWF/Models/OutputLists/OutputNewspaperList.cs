﻿using BooksWF.Models.Instances;
using BooksWF.Models.OutputInstance;
using BooksWF.Models.OutputList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWF.Models.OutputList
{
    internal class OutputNewspaperList 
    {
        public string Output()
        {
            WinFormOutputAuthoredItem articleOutput = new WinFormOutputAuthoredItem();
            WinFormOutputNewspaper output = new WinFormOutputNewspaper(articleOutput);
            SetItem newspaperSetter = new SetItem();
             return output.ListOutput(NewspaperList.GetNewspaperList(newspaperSetter).GenerateList()).ToString();
        }

    }
}
