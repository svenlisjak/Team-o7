using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jaj.Models
{
    public class TagList
    {
        public static IEnumerable<SelectListItem> GetTagList()
        {
            IList<SelectListItem> tags = new List<SelectListItem>
            {
            new SelectListItem() {Text="Gaming", Value="Gaming"},
            new SelectListItem() { Text="Lifestyle", Value="Lifestyle"},
            new SelectListItem() { Text="Music", Value="Music"},
            new SelectListItem() { Text="Culture", Value="Culture"},
            new SelectListItem() { Text="Sport", Value="Sport"}
            };
            return tags;
        }
    }
}