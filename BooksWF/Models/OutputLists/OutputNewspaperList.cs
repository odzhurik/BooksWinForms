﻿using BooksWF.Models.Instances;
using BooksWF.Models.OutputList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWF.Models.OutputList
{
    internal class OutputNewspaperList :IWinFormOutput
    {
        public string Output()
        {
            WinFormOutputItem output = new WinFormOutputItem();
             return output.ListOutput(NewspaperList.GetNewspaperList().GenerateList()).ToString();
        }

    }
}
