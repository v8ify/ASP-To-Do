#pragma checksum "C:\Users\DELL\Desktop\asp.net projects\ToDoApp\Pages\ToDo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3b1f01ba312ea27ee7e294c6eb26788e71e4023"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ToDoApp.Pages.ToDo.Pages_ToDo_Index), @"mvc.1.0.razor-page", @"/Pages/ToDo/Index.cshtml")]
namespace ToDoApp.Pages.ToDo
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
#line 1 "C:\Users\DELL\Desktop\asp.net projects\ToDoApp\Pages\_ViewImports.cshtml"
using ToDoApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3b1f01ba312ea27ee7e294c6eb26788e71e4023", @"/Pages/ToDo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9affeb890dc580d99ff63cea802307dafcadbdec", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ToDo_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\DELL\Desktop\asp.net projects\ToDoApp\Pages\ToDo\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 8 "C:\Users\DELL\Desktop\asp.net projects\ToDoApp\Pages\ToDo\Index.cshtml"
     foreach(var task in Model.ToDos)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>");
#nullable restore
#line 10 "C:\Users\DELL\Desktop\asp.net projects\ToDoApp\Pages\ToDo\Index.cshtml"
       Write(task.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p>Is Completed: ");
#nullable restore
#line 11 "C:\Users\DELL\Desktop\asp.net projects\ToDoApp\Pages\ToDo\Index.cshtml"
                     Write(task.IsCompleted ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\Users\DELL\Desktop\asp.net projects\ToDoApp\Pages\ToDo\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoApp.Pages.ToDo.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ToDoApp.Pages.ToDo.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ToDoApp.Pages.ToDo.IndexModel>)PageContext?.ViewData;
        public ToDoApp.Pages.ToDo.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591