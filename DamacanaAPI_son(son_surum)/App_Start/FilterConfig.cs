﻿using System.Web;
using System.Web.Mvc;

namespace DamacanaAPI_son
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
