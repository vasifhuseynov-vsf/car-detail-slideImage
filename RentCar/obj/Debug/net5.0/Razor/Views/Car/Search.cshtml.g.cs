#pragma checksum "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ac220392084c019854e71c34d8bd24f1b70bdb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Search), @"mvc.1.0.view", @"/Views/Car/Search.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\HP\Desktop\RentCar\RentCar\Views\_ViewImports.cshtml"
using RentCar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\RentCar\RentCar\Views\_ViewImports.cshtml"
using RentCar.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\RentCar\RentCar\Views\_ViewImports.cshtml"
using RentCar.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\RentCar\RentCar\Views\_ViewImports.cshtml"
using RentCar.Models.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\RentCar\RentCar\Views\_ViewImports.cshtml"
using RentCar.Models.ViewModels.Car;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Desktop\RentCar\RentCar\Views\_ViewImports.cshtml"
using RentCar.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ac220392084c019854e71c34d8bd24f1b70bdb6", @"/Views/Car/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59446d1e6eb512a4da9c02bd3c686a7f8f6276b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CarModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Car", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section>\r\n    <div class=\"box-container\">\r\n");
#nullable restore
#line 9 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
         foreach (var carModel in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
             foreach (var carImage in carModel.CarImages)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"box\">\r\n                    <div class=\"image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1ac220392084c019854e71c34d8bd24f1b70bdb65277", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 350, "~/image/cars/", 350, 13, true);
#nullable restore
#line 15 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
AddHtmlAttributeValue("", 363, carImage.ImageName, 363, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
AddHtmlAttributeValue("", 389, carImage.ImageName, 389, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"info\">\r\n                        <h4>");
#nullable restore
#line 18 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
                       Write(carModel.Car.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <h5>");
#nullable restore
#line 19 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
                       Write(carModel.ModelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <mark>");
#nullable restore
#line 20 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
                         Write(carModel.District.City.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 20 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
                                                      Write(carModel.District.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</mark>\r\n                        <p>");
#nullable restore
#line 21 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
                      Write(carModel.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <span>₼");
#nullable restore
#line 22 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
                          Write(carModel.CurrentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(".00 günlük <s>₼");
#nullable restore
#line 22 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
                                                               Write(carModel.OldPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(".00</s></span>\r\n                        <div class=\"stars\">\r\n");
#nullable restore
#line 24 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
                             if (carModel.Rating == 5)
                            {
                                for (int i = 1; i <= 5; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"fa fa-star checked\"></span>\r\n");
#nullable restore
#line 29 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
                                }
                            }
                            else
                            {
                                byte dif = (byte)(5 - carModel.Rating);

                                for (int i = 1; i <= carModel.Rating; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"fa fa-star checked\"></span>\r\n");
#nullable restore
#line 38 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
                                }

                                for (int i = 1; i <= dif; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"fa fa-star unchecked\"></span>\r\n");
#nullable restore
#line 43 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
                                }

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"btn\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ac220392084c019854e71c34d8bd24f1b70bdb610957", async() => {
                WriteLiteral("Detallı");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
                                                                      WriteLiteral(carModel.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 52 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Car\Search.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</section>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CarModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591