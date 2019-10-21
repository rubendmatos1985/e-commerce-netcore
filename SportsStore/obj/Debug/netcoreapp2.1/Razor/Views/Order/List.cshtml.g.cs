#pragma checksum "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\Order\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7c896dbf54934b945684e1e26ed2f54a77107cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_List), @"mvc.1.0.view", @"/Views/Order/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/List.cshtml", typeof(AspNetCore.Views_Order_List))]
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
#line 1 "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#line 2 "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7c896dbf54934b945684e1e26ed2f54a77107cd", @"/Views/Order/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2097b54f91e91a7f99db2cd5f8be111204fc385", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkShipped", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\Order\List.cshtml"
   
  ViewBag.Title = "Orders";
  Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(94, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\Order\List.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
            BeginContext(124, 151, true);
            WriteLiteral(" <table class=\"table table-bordered table-stripped\">\r\n     <tr>\r\n     <th>Name</th>\r\n     <th>Zip</th>\r\n     <th colspan=\"2\">Details</th>\r\n     </tr>\r\n");
            EndContext();
#line 16 "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\Order\List.cshtml"
      foreach(Order o in Model)
     {

#line default
#line hidden
            BeginContext(316, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(347, 6, false);
#line 19 "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\Order\List.cshtml"
           Write(o.Name);

#line default
#line hidden
            EndContext();
            BeginContext(353, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(377, 5, false);
#line 20 "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\Order\List.cshtml"
           Write(o.Zip);

#line default
#line hidden
            EndContext();
            BeginContext(382, 102, true);
            WriteLiteral("</td>\r\n            <th>Product</th>\r\n            <th>Quantity</th>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(484, 286, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a612ceacfbea4fc4a717980748c665d7", async() => {
                BeginContext(529, 59, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"orderedId\"");
                EndContext();
                BeginWriteAttribute("value", "  value=\"", 588, "\"", 607, 1);
#line 25 "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\Order\List.cshtml"
WriteAttributeValue("", 597, o.OrderID, 597, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(608, 155, true);
                WriteLiteral("/>\r\n                    <button type=\"submit\" class=\"btn btn-sm btn-danger\">\r\n                        Ship\r\n                    </button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(770, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 32 "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\Order\List.cshtml"
         foreach(CartLine line in o.Lines)
        {

#line default
#line hidden
            BeginContext(861, 77, true);
            WriteLiteral("            <tr>\r\n                <td colspan=\"2\"></td>\r\n                <td>");
            EndContext();
            BeginContext(939, 17, false);
#line 36 "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\Order\List.cshtml"
               Write(line.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(956, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(984, 13, false);
#line 37 "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\Order\List.cshtml"
               Write(line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(997, 53, true);
            WriteLiteral("</td>\r\n                <td></td>\r\n            </tr>\r\n");
            EndContext();
#line 40 "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\Order\List.cshtml"
        }

#line default
#line hidden
#line 40 "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\Order\List.cshtml"
         
     }

#line default
#line hidden
            BeginContext(1069, 13, true);
            WriteLiteral("\r\n </table>\r\n");
            EndContext();
#line 44 "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\Order\List.cshtml"
}else
{

#line default
#line hidden
            BeginContext(1092, 56, true);
            WriteLiteral("    <div class=\"text-center\">No Unshipped Orders</div>\r\n");
            EndContext();
#line 47 "C:\Users\User\Documents\PRO_ASPNET_CORE\SportsStore\SportsStore\Views\Order\List.cshtml"
}

#line default
#line hidden
            BeginContext(1149, 1, true);
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
