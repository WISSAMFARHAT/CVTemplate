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
using AngryMonkey.Cloud.Files;
using AngryMonkey.Cloud;
using System.Reflection;

namespace CVTemplate.Pages
{
    public partial class Index
    {
        public bool PersonalCheck { get; set; } = false;
        public bool EducationCheck { get; set; } = false;
        public bool EmploymentCheck { get; set; } = false;
        public bool SkillsCheck { get; set; } = false;
        public bool LanguagesCheck { get; set; } = false;
        public bool HobbiesCheck { get; set; } = false;
        public bool NextTo { get; set; } = false;
        public int EducationCount { get; set; } = 1;
        public string ButtonName { get; set; } = "Next";
        public DataModel Data => DataService.Data;

        //public List<EducationModel> EducationList { get; set; } = new();
        //public List<EmployeModel> EmployeList { get; set; } = new();
        //public List<SkillModel> SkillList { get; set; } = new();
        //public List<LanguagesModel> LanguagesList { get; set; } = new();
        //public List<HobbyModel> HobbyList { get; set; } = new();
        //public PersonalModel Personal { get; set; } = new();
        protected void NewEducation() => Data.Educations.Add(new() { ID = Guid.NewGuid() });
        protected void NewEmploye() => Data.Employees.Add(new() { ID = Guid.NewGuid() });
        protected void NewSkill() => Data.Skills.Add(new() { ID = Guid.NewGuid() });
        protected void NewLanguage() => Data.Languages.Add(new() { ID = Guid.NewGuid() });
        protected void NewHobby() => Data.Hobbies.Add(new() { ID = Guid.NewGuid() });

        private IJSObjectReference JSModule { get; set; }

        private async Task OnFileSelected(InputFileChangeEventArgs e)
        {
            if (e.File.Size > 10000000)
                return;


            byte[] buf = new byte[e.File.Size];
            using (var stream = e.File.OpenReadStream(10000000))
            {
                await stream.ReadAsync(buf); // copy the stream to the buffer
            }

            Data.Personal.photo = $"data:image/png;base64,{Convert.ToBase64String(buf)}";

            this.StateHasChanged();
        }

        protected override async Task OnInitializedAsync()
        {
            JSModule = await js.InvokeAsync<IJSObjectReference>("import", "./js/resume.js");
        }
        private void Next() => nv.NavigateTo("/Resume");

    }


}