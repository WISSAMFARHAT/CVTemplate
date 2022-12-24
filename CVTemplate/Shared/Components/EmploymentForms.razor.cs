using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using CVTemplate;
using CVTemplate.Shared;
using AngryMonkey.Cloud.Components;
using CVTemplate.Model;
using CVTemplate.Pages;

namespace CVTemplate.Shared.Components
{
    public partial class EmploymentForms
    {
        [CascadingParameter]
        public List<EmployeModel>? EmployeList { get; set; }

        protected void RemoveEmployee(Guid educationId)
        {
            EmployeList.Remove(EmployeList.First(key => key.ID == educationId));
        }

        protected void CheckChange(ChangeEventArgs e, Guid ID)
        {
            EmployeList.Find(x=>x.ID== ID).Present= (bool)e.Value;
        }
    }
}