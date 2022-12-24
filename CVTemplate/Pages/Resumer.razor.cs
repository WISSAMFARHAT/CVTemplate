using AngryMonkey.Cloud.Files;
using CVTemplate.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Security.Principal;
using System.Xml.Linq;

namespace CVTemplate.Pages
{
    public partial class Resumer
    {
        public DataModel Data => DataService.Data;
        private IJSObjectReference JSModule { get; set; }
        protected override async Task OnInitializedAsync()
        {
            JSModule = await js.InvokeAsync<IJSObjectReference>("import", "./js/resume.js");
        }

        protected async Task Fill()
        {
            Data.Personal.Name = "Mohamed El-Ashkar";
            Data.Personal.Position = "Design Manager";
            Data.Personal.Nationality = "Egypt";
            Data.Personal.Address = "Egypt, cario 123";
            Data.Personal.Email = "m2_elashkar@yahoo.com";
            Data.Personal.PhoneNumber = "00965- 97221520";
            Data.Personal.Headline = "Well qualified and highly driven person. Capacity to work in highly diverse multicultural organizations.\r\nHigh ability to provide leadership and technical expertise across the Projects spectrum," +
                "Also have developed a wealth of technical knowledge and project management experience through designing and reviewing versified projects.\n" +
                "Now looking forward to next stage in career through a similar position or a management position in a company that could use my 15 years of experience to achieve mutual success";
           
            Data.Educations.AddRange(
                new List<EducationModel>()
                {
                  new()
                    {
                        Title = "BSc. Architecture",
                        School = "Alexandria University",
                        City="Egypt",
                        Started = new DateTime(1999, 01, 01),
                        Description = "BSc. Architecture, Alexandria University, Egypt 1999."
                    },
                  new()
                    {
                        Description = "Member of the Egyptian Syndicate of Engineers & Egyptian Society of Engineers."
                    },

               new()
                {
                    Description = "Member of the Kuwait Syndicate of Engineers / professional Engineer"
                },

                new()
                {
                    Description = "Member of SAVE INTERNATIONAL \"Associate Value Specialist\", \"AVS' for value engineering"
                }

                }

            );
            Data.Employees.AddRange(
                new List<EmployeModel>()
                {
                    new()
                    {
                        Title = "Design manager",
                        Employee = "Nezar Alanjari consulting office",
                        Started = new DateTime(2017, 01, 01),
                        EndDate = new DateTime(2022, 12, 12),
                        Present=true,
                        Description = "Participate in design meetings and provide continual input to optimize design and minimize futile work.\r\nAssist in developing Design Delivery Schedule along with client, Project Manager, Design Managers and consultants.\r\nDevelop comprehensive scope-of-work and contract document deliverables list for each related discipline.\r\nNegotiate scope-of-work, deliverables and price with consulting firms.\r\nManage distribution and production of project workload within team.\r\nDetermine need for use of outside studios or vendors. .\r\nCollaborate on new design issues and research projects with team.\r\nEnsure projects and finished graphics are accurate and precise." +
                        "Responsibilities included technical/design management, coordination and supervising for several project,:\r\n1. Acting as the Design Manager for the extension of Kuwait science and Technology college\r\n2. Acting as the Design Manager for the extension of Kuwait Technical college\r\n3. Acting as the Project Manager of all the Kuwait Danish Dairy Company projects inside NAB(11,000 sqm stores , Headquarter design, factories )\r\n4. Responsible for all the technical and financial proposals in the office\r\n5. Design concept of several residential complexes, educational and commercial, buildings.\r\n6. Design Concept of several cold and AC stores for KGL, JTC etc� .\r\n7. Liaison with international consultant forming a joint venture in several projects.\r\n8. Providing Simple feasibility studies with extended project design concept analysis to conclude the best project program that satisfy the owner needs."
                    },

                    new()
                   {
                       Title = "Marketing",
                       Employee = "Antonine University",
                        Started = new DateTime(1998, 01, 01),
                        EndDate = new DateTime(2022, 12, 12),
                       Description = "sfdsfdsfdsfsdfdsfdsfsdfsdfdsfsdfsdfdsfsdfdsfsdfdsfdsfdsfsdfdsfdsfdsfsdfsddsfsfdsfdsf \n sfdsfdsfdsfsdfdsfdsfsdfsdfdsfsdfsdfdsfsdfdsfsdfdsfdsfdsfsdfdsfdsfdsfsdfsddsfsfdsfdsf "
                   },
                     new()
                   {
                       Title = "Real Estate Solutions as Project Manager",
                       Employee = "Subsidiary of al Massaleh Real Estate Company",
                       City="Kuwait",
                        Started = new DateTime(2006, 01, 01),
                        EndDate = new DateTime(2016, 12, 12),
                       Description = ".Real Estate Solutions is a project Management Company.\r\nResponsibilities included technical/design management , coordination and supervising for all projects Design teams/consultants, also the Project manager for design phases in Kuwait projects. Scope including coordination, planning supervising" +
                       "the assigned consultants during design and tenders packages preparations. Prepare analyses for the consultants & contractors technical and financial submittals." +
                       "\n For the last 5 years I have been involved in Coordination for the following projects:\n" +
                       "1. Massaleh Towers Bnied Algar,29 and 40 floors with a total area of 36,000 sqm (total cost 14.5 M KD)\r\n2. Taameer complex Renovation ,full refurbishment for 86 apartments with a total of 18,600 sqm (total cost 3.5M) KD\r\n3. Corniche Club interior refurbishment ( total cost 1.1 M KD)\r\n4. Prime Tower (Business Bay Dubai ) new office building 64 floors. (total cost 24 m KD)" +
                       "\n As I worked with our sister company �Taameer Real Estate Investment Company� I have designed and acted as a design manager for some of the Ramada encore in the middle east:\n" +
                       "1- Ramada Encore Tangier (concept design /design management) completed.\r\n2- Ramada FES (due diligence )\r\n3- Ramada Sohar proposed (proposed - Concept Design)\r\n4- Ramda encore Agadir (proposed-concept design )\r\n5- Taameer complex extension � Kuwait- Ramda hotel+ residential complex ( project manager)\n" +
                       ""
                   },
                       new()
                   {
                       Title = "Senior Architect",
                       Employee = "Nezar Alanjari consulting office",
                        Started = new DateTime(2003, 01, 01),
                        EndDate = new DateTime(2005, 12, 12),
                       Description = "As a Senior Architect I was responsible supervising the design process and presentation of most of the residential, commercial and administration buildings and participated in most of the architecture competitions in Kuwait. Directly involved in\n" +
                       "� Al-arjan residential complex �$13.2 million �jabriya-kuwait �\r\n� Al-khaled office Tower -$8 million �Kuwait\r\n� Heritage village competition\r\n� Over 50 residential buildings/ villas\n" +
                       ""
                   },
                          new()
                   {
                       Title = "As an architect",
                       Employee = "Awad Enterprises-Egypt.",
                        Started = new DateTime(1999, 01, 01),
                        EndDate = new DateTime(2002, 12, 12),
                       Description = "Participated in designing of \n " +
                       "� Various luxurious residential villas\r\n� Renovation of the Greek patriarchate in Alexandria\r\n� The Grand Egyptian Museum competition"
                   },
                          new()
                   {
                       Title = "Alexandria preservation trust",
                        Started = new DateTime(1999, 01, 01),
                        EndDate = new DateTime(2002, 12, 12),
                       Description = "The Alexandria Preservation Trust is a private organization founded for the general purpose of promoting awareness and preservation of Alexandria's cultural heritage, ancient and modern, with a special emphasis on the built environment.\r\nI was engaged in documenting the monuments and buildings of historical and architectural value throughout Alexandria gathering information on archaeological sites\r\nCollecting of detailed plans, drawings and photo documentation provides a comprehensive listing of both the Ottoman and Cosmopolitan segments of the city."
                   },
                          new()
                   {
                       Title = "Design & Construction Group",
                        Started = new DateTime(1997, 01, 01),
                        EndDate = new DateTime(1999, 12, 12),
                       Description = "Summer training in office from 1997 till 1999"
                       },
                          new()
                   {
                       Title = "CAD & Graphics",
                       Description = "16 years experience Mastering using 3d Studio Max .\r\n20 years experience Mastering-using AutoCAD .\r\n20 years experience Mastering-using CorelDraw.\r\n20 years experience Mastering-using Corel Photo Paint with most plugins.\r\n20 years experience Mastering using Adobe Photoshop up to CS5 with most plugins"

                    },
                }
           );

            Data.Languages.AddRange(
                new List<LanguagesModel>()
                {
                    new()
                    {
                        Title="Arabic"
                    },
                    new()
                    {
                        Title="English"
                    },
                    new()
                    {
                        Title="Fresnh"
                    },
                }
                );

        }

        protected async Task PrintPDF()
        {
            await JSModule.InvokeVoidAsync("printInvoke");
        }

        protected async Task DownloadPDF()
        {
            try
            {
                string htmlBody = await JSModule.InvokeAsync<string>("getBodyAsHtml");

                byte[] DocumentPDF = await cloudFiles.Documents.ConvertHtmlToPdfBytes(htmlBody,
                        new HtmlToPdfOptions()
                        {
                            MarginTop = 10,
                            MarginRight = 30,
                            MarginLeft = 10,
                            MarginBottom = 30,
                            EmbedFonts = true,

                            Paging = new HtmlToPdfPaging()
                            {

                                FontEmSize = 6,
                                FontFamily = "Klavika",//"Segeo UI",
                                ForeColor = System.Drawing.Color.FromArgb(125, System.Drawing.Color.Black),
                                HorizontalAlign = PdfTextHorizontalAlign.Left,
                                X = 35,
                                Y = 10,
                                Template = "page {page_number} of {total_pages}"
                            },

                            PdfDocumentInformation = new HtmlToPdfDocumentInformation()
                            {
                                Author = "URC",
                                CreationDate = DateTime.UtcNow,
                                Title = Data.Personal.Name
                            }
                        },
                        new HtmlToPdfHeader(0, string.Empty),
                        new HtmlToPdfFooter(0, string.Empty)
                );

                using var streamRef = new DotNetStreamReference(new MemoryStream(DocumentPDF));

                await JSModule.InvokeVoidAsync("downloadFileFromStream", $"{Data.Personal.Name} Resume - URC.pdf", streamRef);
            }
            catch (Exception e)
            {

            }

        }
    }
}