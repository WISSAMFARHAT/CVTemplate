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
    public partial class HobbyForm
    {
        [CascadingParameter]
        public List<HobbyModel> HobbyList { get; set; }

        protected void RemoveHobby(Guid educationId)
        {
            HobbyList.Remove(HobbyList.First(key => key.ID == educationId));
        }
    }
}