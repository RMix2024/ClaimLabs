#pragma checksum "D:\Software_Developing\C_Sharp\C_Sharp_Labs\Lab_4\Grade_Manager\Grade_Manager_Razor\Pages\Students\ShowGradeAverage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3734a6f8c887359371a944b95ca084cc8b124c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Grade_Manager_Razor.Pages.Students.Pages_Students_ShowGradeAverage), @"mvc.1.0.razor-page", @"/Pages/Students/ShowGradeAverage.cshtml")]
namespace Grade_Manager_Razor.Pages.Students
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
#line 1 "D:\Software_Developing\C_Sharp\C_Sharp_Labs\Lab_4\Grade_Manager\Grade_Manager_Razor\Pages\_ViewImports.cshtml"
using Grade_Manager_Razor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3734a6f8c887359371a944b95ca084cc8b124c5", @"/Pages/Students/ShowGradeAverage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd7f399735f63483dc04eacf9e95f3290416cb7b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Students_ShowGradeAverage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Software_Developing\C_Sharp\C_Sharp_Labs\Lab_4\Grade_Manager\Grade_Manager_Razor\Pages\Students\ShowGradeAverage.cshtml"
  
    ViewData["Title"] = "Grade Average";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "D:\Software_Developing\C_Sharp\C_Sharp_Labs\Lab_4\Grade_Manager\Grade_Manager_Razor\Pages\Students\ShowGradeAverage.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <table>\r\n        <thead>Student Grade Average</thead>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Grade_Manager_Razor.Pages.Students.ShowGradeAverageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Grade_Manager_Razor.Pages.Students.ShowGradeAverageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Grade_Manager_Razor.Pages.Students.ShowGradeAverageModel>)PageContext?.ViewData;
        public Grade_Manager_Razor.Pages.Students.ShowGradeAverageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591