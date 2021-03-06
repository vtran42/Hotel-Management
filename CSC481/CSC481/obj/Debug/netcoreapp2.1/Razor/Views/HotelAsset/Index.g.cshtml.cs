#pragma checksum "E:\Course_Taken\CSC 481\CSC481\CSC481\Views\HotelAsset\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f51f01d9abf05bedd3b37c432e6705197d20829e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HotelAsset_Index), @"mvc.1.0.view", @"/Views/HotelAsset/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HotelAsset/Index.cshtml", typeof(AspNetCore.Views_HotelAsset_Index))]
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
#line 1 "E:\Course_Taken\CSC 481\CSC481\CSC481\Views\_ViewImports.cshtml"
using CSC481;

#line default
#line hidden
#line 2 "E:\Course_Taken\CSC 481\CSC481\CSC481\Views\_ViewImports.cshtml"
using CSC481.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f51f01d9abf05bedd3b37c432e6705197d20829e", @"/Views/HotelAsset/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c75b350d022a362cbef3c7adbd5ec01fb6c9cd79", @"/Views/_ViewImports.cshtml")]
    public class Views_HotelAsset_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CSC481.Models.HotelAsset.AssetIndexModel>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Course_Taken\CSC 481\CSC481\CSC481\Views\HotelAsset\Index.cshtml"
   
    ViewBag.Title = "Hotel Asset Information";

#line default
#line hidden
            BeginContext(105, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(110, 13, false);
#line 5 "E:\Course_Taken\CSC 481\CSC481\CSC481\Views\HotelAsset\Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(123, 78, true);
            WriteLiteral("</h1>\r\n<div>\r\n    <h3>Room Information, display only available room</h3>\r\n    ");
            EndContext();
            BeginContext(201, 1346, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05fac1cbb36d480e9ada39ad8e63c546", async() => {
                BeginContext(207, 529, true);
                WriteLiteral(@"
        <div>
            <table class=""table table-striped"" id=""RoomIndexTable"">
                <thead style=""color:blue;background-color:yellow"">
                    <tr>
                        <th>Room number</th>
                        <th>Bed Size</th>
                        <th>Room Type</th>
                        <th>Area(square feet)</th>
                        <th>Price ($)</th>
                        <th>Booking</th>
                    </tr>
                </thead>
                <tbody>
");
                EndContext();
#line 22 "E:\Course_Taken\CSC 481\CSC481\CSC481\Views\HotelAsset\Index.cshtml"
                     foreach (var asset in Model.Assets)
                    {
                        

#line default
#line hidden
#line 24 "E:\Course_Taken\CSC 481\CSC481\CSC481\Views\HotelAsset\Index.cshtml"
                         if (asset.GetRoomStatus.Equals("Available"))
                        {

#line default
#line hidden
                BeginContext(915, 91, true);
                WriteLiteral("                            <tr>\r\n                                <td class=\"btn-group-lg\">");
                EndContext();
                BeginContext(1007, 16, false);
#line 27 "E:\Course_Taken\CSC 481\CSC481\CSC481\Views\HotelAsset\Index.cshtml"
                                                    Write(asset.RoomNumber);

#line default
#line hidden
                EndContext();
                BeginContext(1023, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(1067, 16, false);
#line 28 "E:\Course_Taken\CSC 481\CSC481\CSC481\Views\HotelAsset\Index.cshtml"
                               Write(asset.GetBedSize);

#line default
#line hidden
                EndContext();
                BeginContext(1083, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(1127, 17, false);
#line 29 "E:\Course_Taken\CSC 481\CSC481\CSC481\Views\HotelAsset\Index.cshtml"
                               Write(asset.GetRoomType);

#line default
#line hidden
                EndContext();
                BeginContext(1144, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(1188, 17, false);
#line 30 "E:\Course_Taken\CSC 481\CSC481\CSC481\Views\HotelAsset\Index.cshtml"
                               Write(asset.GetRoomArea);

#line default
#line hidden
                EndContext();
                BeginContext(1205, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(1249, 18, false);
#line 31 "E:\Course_Taken\CSC 481\CSC481\CSC481\Views\HotelAsset\Index.cshtml"
                               Write(asset.GetRoomPrice);

#line default
#line hidden
                EndContext();
                BeginContext(1267, 155, true);
                WriteLiteral("</td>\r\n\r\n                                <td><button type=\"submit\" class=\"btn btn-primary btn-sm\">Book</button></td>\r\n\r\n                            </tr>\r\n");
                EndContext();
#line 36 "E:\Course_Taken\CSC 481\CSC481\CSC481\Views\HotelAsset\Index.cshtml"
                        }

#line default
#line hidden
#line 36 "E:\Course_Taken\CSC 481\CSC481\CSC481\Views\HotelAsset\Index.cshtml"
                         
                    }

#line default
#line hidden
                BeginContext(1472, 68, true);
                WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1547, 16, true);
            WriteLiteral("\r\n    \r\n\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSC481.Models.HotelAsset.AssetIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
