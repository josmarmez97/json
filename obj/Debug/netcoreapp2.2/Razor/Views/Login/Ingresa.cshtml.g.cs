#pragma checksum "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\login-josmar\Views\Login\Ingresa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aae401105b5937741030cca001a6e21124bb311"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Ingresa), @"mvc.1.0.view", @"/Views/Login/Ingresa.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Ingresa.cshtml", typeof(AspNetCore.Views_Login_Ingresa))]
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
#line 1 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\login-josmar\Views\_ViewImports.cshtml"
using login;

#line default
#line hidden
#line 2 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\login-josmar\Views\_ViewImports.cshtml"
using login.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aae401105b5937741030cca001a6e21124bb311", @"/Views/Login/Ingresa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27b77a31d4cc5a00256e7fc7b0c4a61d82c79e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Ingresa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<login.Models.Roles>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Registrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\login-josmar\Views\Login\Ingresa.cshtml"
  
    ViewData["Title"]="Registra";

#line default
#line hidden
            BeginContext(71, 98, true);
            WriteLiteral("<div>\n    <h1>REGISTRO</h1>\n    <p>Ingrese los datos de la nueva persona</p>    \n</div>\n<div>\n    ");
            EndContext();
            BeginContext(169, 1059, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3aae401105b5937741030cca001a6e21124bb3114516", async() => {
                BeginContext(208, 557, true);
                WriteLiteral(@"                        
            <label>
                Userid:
                <input type=""text"" name=""usuario_registra"">
            </label><br><br>
            <label>
                Nombre:
                <input type=""text"" name=""nombre_registra"">                
            </label><br><br>    
            <label>
                Password:
                <input type=""password"" name=""pass_registra"">
            </label><br><br>
            <div>
                <h6>Rol de Usuario</h6>
                    <select name=""rol"" id=""rolesXD"">
");
                EndContext();
#line 26 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\login-josmar\Views\Login\Ingresa.cshtml"
                     foreach(var item in Model)
                    {

#line default
#line hidden
                BeginContext(835, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(859, 106, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3aae401105b5937741030cca001a6e21124bb3115833", async() => {
                    BeginContext(886, 29, true);
                    WriteLiteral("\n                            ");
                    EndContext();
                    BeginContext(916, 15, false);
#line 29 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\login-josmar\Views\Login\Ingresa.cshtml"
                       Write(item.nombre_rol);

#line default
#line hidden
                    EndContext();
                    BeginContext(931, 25, true);
                    WriteLiteral("\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 28 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\login-josmar\Views\Login\Ingresa.cshtml"
                            WriteLiteral(item.id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(965, 25, true);
                WriteLiteral("                        \n");
                EndContext();
#line 31 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\login-josmar\Views\Login\Ingresa.cshtml"
                    }

#line default
#line hidden
                BeginContext(1012, 209, true);
                WriteLiteral("                    </select>\n            </div>\n            <br><br>\n            <input type=\"submit\" name =\"XD\" class=\"btn btn-success\">\n            <a href=\"ViewSU\" class=\"btn btn-warning\">Regresar</a>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            BeginContext(1228, 8, true);
            WriteLiteral("\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<login.Models.Roles>> Html { get; private set; }
    }
}
#pragma warning restore 1591