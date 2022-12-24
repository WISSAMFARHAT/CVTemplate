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

namespace CVTemplate.Shared.Components
{
    public partial class EducationForms
    {
        [CascadingParameter]
        public List<EducationModel>? EducationList { get; set; }

        protected void RemoveEducation(Guid educationId)
        {
            EducationList.Remove(EducationList.First(key => key.ID == educationId));
        }

        protected void CheckChange(ChangeEventArgs e,Guid ID)
        {
          EducationList.Find(x => x.ID == ID).Present = (bool)e.Value;
        }
    }
}