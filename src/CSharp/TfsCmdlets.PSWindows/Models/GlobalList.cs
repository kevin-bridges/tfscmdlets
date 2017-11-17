﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TfsCmdlets.Models
{
    public class GlobalList
    {
        public string Name { get; set; }

        public List<string> Items { get; internal set; } = new List<string>();

        public XmlDocument ToXml()
        {
            var doc = new XmlDocument();
            doc.LoadXml("<gl:GLOBALLISTS xmlns:gl=\"http://schemas.microsoft.com/VisualStudio/2005/workitemtracking/globallists\">");

            var listElem = doc.CreateElement("GLOBALLIST");
            listElem.SetAttribute("name", Name);

            foreach (var item in Items)
            {
                var itemElem = doc.CreateElement("LISTITEM");
                itemElem.SetAttribute("value", item);
                listElem.AppendChild(itemElem);
            }

            return doc;
        }
    }
}