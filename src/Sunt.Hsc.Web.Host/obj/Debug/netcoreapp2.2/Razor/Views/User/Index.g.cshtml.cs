#pragma checksum "D:\GitHubCodes\MyFirstCoreApp\src\Sunt.Hsc.Web.Host\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab409e02d131074a1a39f53c2a492d87b8bd9128"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
#line 1 "D:\GitHubCodes\MyFirstCoreApp\src\Sunt.Hsc.Web.Host\Views\_ViewImports.cshtml"
using Sunt.Hsc.Web.Host;

#line default
#line hidden
#line 2 "D:\GitHubCodes\MyFirstCoreApp\src\Sunt.Hsc.Web.Host\Views\_ViewImports.cshtml"
using Sunt.Hsc.Web.Host.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab409e02d131074a1a39f53c2a492d87b8bd9128", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e52742f97974a7d7396d37117487b26aac304ee4", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sunt.Hsc.Core.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("white-space: nowrap;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\GitHubCodes\MyFirstCoreApp\src\Sunt.Hsc.Web.Host\Views\User\Index.cshtml"
  
	ViewBag.Title = "用户列表";

#line default
#line hidden
            BeginContext(75, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(82, 13, false);
#line 7 "D:\GitHubCodes\MyFirstCoreApp\src\Sunt.Hsc.Web.Host\Views\User\Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(95, 300, true);
            WriteLiteral(@"</h2>

<table class=""table"">
	<thead class=""thead-dark"">
		<tr>
			<th scope=""col"">ID</th>
			<th scope=""col"">姓名</th>
			<th scope=""col"">Email</th>
			<th scope=""col"">手机号</th>
			<th scope=""col"">用户名</th>
			<th scope=""col"">密码</th>
			<th scope=""col"">操作</th>
		</tr>
	</thead>
	<tbody>
");
            EndContext();
#line 22 "D:\GitHubCodes\MyFirstCoreApp\src\Sunt.Hsc.Web.Host\Views\User\Index.cshtml"
         foreach (var u in Model)
		{

#line default
#line hidden
            BeginContext(429, 29, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<th scope=\"row\">");
            EndContext();
            BeginContext(459, 4, false);
#line 25 "D:\GitHubCodes\MyFirstCoreApp\src\Sunt.Hsc.Web.Host\Views\User\Index.cshtml"
                           Write(u.Id);

#line default
#line hidden
            EndContext();
            BeginContext(463, 15, true);
            WriteLiteral("</th>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(479, 6, false);
#line 26 "D:\GitHubCodes\MyFirstCoreApp\src\Sunt.Hsc.Web.Host\Views\User\Index.cshtml"
               Write(u.Name);

#line default
#line hidden
            EndContext();
            BeginContext(485, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(501, 14, false);
#line 27 "D:\GitHubCodes\MyFirstCoreApp\src\Sunt.Hsc.Web.Host\Views\User\Index.cshtml"
               Write(u.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(515, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(531, 7, false);
#line 28 "D:\GitHubCodes\MyFirstCoreApp\src\Sunt.Hsc.Web.Host\Views\User\Index.cshtml"
               Write(u.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(538, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(554, 10, false);
#line 29 "D:\GitHubCodes\MyFirstCoreApp\src\Sunt.Hsc.Web.Host\Views\User\Index.cshtml"
               Write(u.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(564, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(580, 10, false);
#line 30 "D:\GitHubCodes\MyFirstCoreApp\src\Sunt.Hsc.Web.Host\Views\User\Index.cshtml"
               Write(u.Password);

#line default
#line hidden
            EndContext();
            BeginContext(590, 22, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(612, 316, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab409e02d131074a1a39f53c2a492d87b8bd91288668", async() => {
                BeginContext(706, 8, true);
                WriteLiteral("\r\n\t\t\t\t\t\t");
                EndContext();
                BeginContext(714, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab409e02d131074a1a39f53c2a492d87b8bd91289061", async() => {
                    BeginContext(784, 2, true);
                    WriteLiteral("编辑");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 33 "D:\GitHubCodes\MyFirstCoreApp\src\Sunt.Hsc.Web.Host\Views\User\Index.cshtml"
                                                   WriteLiteral(u.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(790, 131, true);
                WriteLiteral("\r\n\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-danger\"\r\n\t\t\t\t\t\t\t\tonclick=\"return confirm(\'确认删除？\')\">\r\n\t\t\t\t\t\t\t删除\r\n\t\t\t\t\t\t</button>\r\n\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "D:\GitHubCodes\MyFirstCoreApp\src\Sunt.Hsc.Web.Host\Views\User\Index.cshtml"
                                                    WriteLiteral(u.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(928, 23, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 41 "D:\GitHubCodes\MyFirstCoreApp\src\Sunt.Hsc.Web.Host\Views\User\Index.cshtml"
		}

#line default
#line hidden
            BeginContext(956, 23, true);
            WriteLiteral("\t</tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(979, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab409e02d131074a1a39f53c2a492d87b8bd912814561", async() => {
                BeginContext(1027, 4, true);
                WriteLiteral("添加用户");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sunt.Hsc.Core.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
