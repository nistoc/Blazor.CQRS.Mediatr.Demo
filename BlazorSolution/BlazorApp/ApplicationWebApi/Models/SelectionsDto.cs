using System;
using System.Collections.Generic;

namespace BlazorApp.ApplicationWebApi.Models
{

    public class SelectionsDto
    {
        public IList<String> Names { get; set; }

        public IList<String> Roles { get; set; }

        public SelectionsDto()
        {
        }
    }
}
