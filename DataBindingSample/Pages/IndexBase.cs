using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;

namespace DataBindingSample.Pages
{
    public class IndexBase: ComponentBase
    {
        public Employee Employee { get; set; }
        protected override Task OnInitializedAsync()
        {
            Employee = new Employee
            {
                FirstName = "Bethany",
                LastName = "Smith",
            };

            return base.OnInitializedAsync();
        }

        public void Button_Click()
        {
            Employee.FirstName = "Gill";

        }
    }
}
