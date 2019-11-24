using System;
using System.Collections.Generic;

namespace BlazorApp.ApplicationWebApi.Models
{

    public class ViewModel
    {

        public IList<String> Names { get; }

        public IList<String> Roles { get; }

        public String SelectedName { get; set; }

        public String SelectedRole { get; set; }

        public ViewModel(IList<String> roles, IList<String> names)
        {
            this.Roles = roles;
            this.Names = names;
        }
    }
}
