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
    public partial class LanguagesForm
    {
        [CascadingParameter]
        public List<LanguagesModel> LanguagesList { get; set; }

        protected void RemoveLang(Guid educationId)
        {
            LanguagesList.Remove(LanguagesList.First(key => key.ID == educationId));
        }

        private void Change(ChangeEventArgs e, Guid ID)
        {
            int step = Int32.Parse(e.Value.ToString());
            string RangeChoise = "Make a choice";

            switch (step)
            {
                case 0:
                    RangeChoise = "Make a choice";
                    break;
                case 1:
                    RangeChoise = "Beginner";
                    break;
                case 2:
                    RangeChoise = "Moderate";
                    break;
                case 3:
                    RangeChoise = "Good";
                    break;
                case 4:
                    RangeChoise = "Very good";
                    break;
                case 5:
                    RangeChoise = "Excellent";
                    break;
                default:
                    RangeChoise = "Make a choice";
                    break;
            }

            int percentage = (step / 5) * 100;
            LanguagesList.Find(x => x.ID == ID).Range = $"{step.ToString()}%";
            LanguagesList.Find(x => x.ID == ID).RangeName = RangeChoise;
        }
    }
}