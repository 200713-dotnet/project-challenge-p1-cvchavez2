#pragma checksum "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80d758f2d088648d88a4b0a13b10561274956b98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Order), @"mvc.1.0.view", @"/Views/Order/Order.cshtml")]
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
#line 1 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/_ViewImports.cshtml"
using PizzaStore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/_ViewImports.cshtml"
using PizzaStore.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80d758f2d088648d88a4b0a13b10561274956b98", @"/Views/Order/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff45d9d3c22cb5a92bf40a1b74ba0b1e6e5323de", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaStore.Client.Models.PizzaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
  
  ViewData["Title"] = "Pizza Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n  <h3>Select a Pizza</h3>\n  <table>\n    <tr>\n");
#nullable restore
#line 10 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
       using (Html.BeginForm("Pizza", "Order", null, FormMethod.Post))
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"hidden\" name=\"pizzaname\" id=\"pizzaname\" value=\"Cheese\">\n        <input id=\"Submit\" type=\"submit\" value=\"Cheese\" class=\"btn btn-primary\" />\n");
#nullable restore
#line 14 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n    <tr>\n");
#nullable restore
#line 17 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
       using (Html.BeginForm("Pizza", "Order", null, FormMethod.Post))
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"hidden\" name=\"pizzaname\" id=\"pizzaname\" value=\"Hawaiian\">\n        <input id=\"Submit\" type=\"submit\" value=\"Hawaiian\" class=\"btn btn-primary\" />\n");
#nullable restore
#line 21 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n    <tr>\n");
#nullable restore
#line 24 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
       using (Html.BeginForm("Pizza", "Order", null, FormMethod.Post))
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"hidden\" name=\"pizzaname\" id=\"pizzaname\" value=\"Veggie\">\n        <input id=\"Submit\" type=\"submit\" value=\"Veggie\" class=\"btn btn-primary\" />\n");
#nullable restore
#line 28 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n  </table>\n</div>\n<hr/>\n<h3>Make Your Own Custom Pizza</h3>\n<hr/>\n");
#nullable restore
#line 35 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
 using (Html.BeginForm("PlaceOrder", "Order", null, FormMethod.Post))  
{  

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"hidden\" name=\"pizzaname\" id=\"pizzaname\" value=\"Custom\">\n");
#nullable restore
#line 38 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
Write(Html.HiddenFor(name => name.PizzaName, "Custom"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <label><b>Crust</b></label>\n");
#nullable restore
#line 40 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
  foreach (var crust in @Model.Crusts)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\n      <tr>\n        <td>\n          ");
#nullable restore
#line 45 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
     Write(Html.RadioButtonFor(m => m.Crust, crust.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n          ");
#nullable restore
#line 48 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
     Write(Html.LabelFor(m => m.Crust, crust.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n          ");
#nullable restore
#line 49 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
     Write(Html.ValidationMessageFor(m => m.Crust));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n      </tr>\n    </table>\n");
#nullable restore
#line 53 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  <div>\n  <label><b>Size</b></label><br>\n  ");
#nullable restore
#line 56 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
Write(Html.DropDownListFor(m => m.Size, 
                      new SelectList(Model.Sizes), 
                      "Select Size"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n  ");
#nullable restore
#line 59 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
Write(Html.ValidationMessageFor(m => m.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n  </div>\n");
            WriteLiteral("  <label><b>Toppings</b> (Min 2, Max 5)</label>\n");
#nullable restore
#line 63 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
  for (var i = 0; i < Model.SelectedToppings.Count(); i++)  
   {  

#line default
#line hidden
#nullable disable
            WriteLiteral("   <table> \n      <tr>\n          <td>  \n            ");
#nullable restore
#line 68 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
       Write(Html.CheckBoxFor(it => it.SelectedToppings[i].IsSelected, new {Style ="vertical-align:3px}"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("   \n            ");
#nullable restore
#line 69 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
       Write(Html.HiddenFor(it => it.SelectedToppings[i].IsSelected));

#line default
#line hidden
#nullable disable
            WriteLiteral("         \n            ");
#nullable restore
#line 70 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
       Write(Html.HiddenFor(it => it.SelectedToppings[i].Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 71 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
       Write(Html.HiddenFor(it => it.SelectedToppings[i].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 72 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
       Write(Html.DisplayFor(it => it.SelectedToppings[i].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \n         </td>   \n      </tr>  \n   </table>  \n");
#nullable restore
#line 76 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div>\n    <input id=\"Submit\" type=\"submit\" value=\"Add to cart\" class=\"btn btn-primary\" />\n   </div>\n");
#nullable restore
#line 80 "/Users/cvchavez2/Projects/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
}  

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80d758f2d088648d88a4b0a13b10561274956b9811088", async() => {
                WriteLiteral("See Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80d758f2d088648d88a4b0a13b10561274956b9812436", async() => {
                WriteLiteral("Go To Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n");
            WriteLiteral("   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaStore.Client.Models.PizzaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
