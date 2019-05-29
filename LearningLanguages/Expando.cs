﻿using System;
using System.Dynamic;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace LearningLanguages
{
    public static class Expando
    {
        public static ExpandoObject ToExpando(this object anonymousObject)
        {
            IDictionary<string, object> anonymousDictionary = HtmlHelper.AnonymousObjectToHtmlAttributes(anonymousObject);
            IDictionary<string, object> expando = new ExpandoObject();
            foreach (var item in anonymousDictionary)
                expando.Add(item);
            return (ExpandoObject)expando;
        }
    }
}
