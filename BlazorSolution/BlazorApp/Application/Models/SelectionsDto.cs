using System;
using System.Collections.Generic;

namespace BlazorApp.Application.Models
{
    public class SelectionsDto
    {
        public IList<String> Names { get; set; }

        public IList<String> Roles { get; set; }

        public SelectionsDto()
        {
        }
}
