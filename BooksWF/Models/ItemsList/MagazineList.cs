﻿using BooksWF.Models.ItemsList;
using BooksWF.Models.OutputList;
using CardProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksWF.Models
{
    public class MagazineList : IGenerateList
    {
        private List<PolygraphicItem> _list;
        private static MagazineList _magazineList;
        private static ISetItem _itemSetter;
        protected MagazineList()
        {

        }
        public static MagazineList GetMagazineList(ISetItem itemSetter)
        {
            _itemSetter = itemSetter;
            if (_magazineList == null)
                _magazineList = new MagazineList();
            return _magazineList;
        }
        public List<PolygraphicItem> GenerateList()
        {
            _list = new List<PolygraphicItem>();
            return ReadFromFile("Magazines.txt");
        }
        public List<PolygraphicItem> ReadFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Magazine magazine = new Magazine();
                    string[] magazinsParts = line.Split('|');
                    _itemSetter.SetPolygraphicItem(magazinsParts[0], magazine);
                                  
                    for (int i = 1; i < magazinsParts.Length; i++)
                    {
                        AuthoredItem article = new AuthoredItem();
                       _itemSetter.SetPolygraphicItem(magazinsParts[i], article);
                        magazine.Articles.Add(article);
                    }
                    _list.Add(magazine);
                }
            }
            return _list;
        }
        
    }
}
