#pragma checksum "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\login-josmar\Views\Login\Detalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e4fa93a64a539112b7927801545572e6147b460"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Detalles), @"mvc.1.0.view", @"/Views/Login/Detalles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Detalles.cshtml", typeof(AspNetCore.Views_Login_Detalles))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e4fa93a64a539112b7927801545572e6147b460", @"/Views/Login/Detalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27b77a31d4cc5a00256e7fc7b0c4a61d82c79e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Detalles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Usuarios>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../Guardar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\login-josmar\Views\Login\Detalles.cshtml"
  
    ViewData["Title"]="EDITANDO";

#line default
#line hidden
            BeginContext(56, 436, true);
            WriteLiteral(@"<div>    
    <h3>EDITAR</h3>
    <br>    
    <table class=""table"">
        <tr>
            <th scope=""col"">ID</th>            
            <th scope=""col"">USERID</th>
            <th scope=""col"">NOMBRE</th>
            <th scope=""col"">CONTRASEÑA</th>
            <th scope=""col"">PRIVILEGIOS</th>
            <th scope=""col"">OPCIONES</th>  
        </tr>                 
        <tr>                                    
             ");
            EndContext();
            BeginContext(492, 701, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e4fa93a64a539112b7927801545572e6147b4604725", async() => {
                BeginContext(532, 88, true);
                WriteLiteral("\n                <th scope=\"col\"><input type=\"number\"  disabled        name=\"usuario_id\"");
                EndContext();
                BeginWriteAttribute("value", "          value=", 620, "", 645, 1);
#line 19 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\login-josmar\Views\Login\Detalles.cshtml"
WriteAttributeValue("", 636, Model.id, 636, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(645, 104, true);
                WriteLiteral(" ></th>\n                <th scope=\"col\"><input type=\"text\"    disabled id=\"u\" name=\"usuarioid_actualiza\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 749, "\"", 770, 1);
#line 20 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\login-josmar\Views\Login\Detalles.cshtml"
WriteAttributeValue("", 757, Model.userid, 757, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(771, 100, true);
                WriteLiteral("></th>\n                <th scope=\"col\"><input type=\"text\"    disabled id=\"n\" name=\"nombre_actualiza\"");
                EndContext();
                BeginWriteAttribute("value", "    value=\"", 871, "\"", 895, 1);
#line 21 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\login-josmar\Views\Login\Detalles.cshtml"
WriteAttributeValue("", 882, Model.nombre, 882, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(896, 98, true);
                WriteLiteral("></th>\n                <th scope=\"col\"><input type=\"text\"    disabled id=\"p\" name=\"pass_actualiza\"");
                EndContext();
                BeginWriteAttribute("value", "      value=\"", 994, "\"", 1018, 1);
#line 22 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\login-josmar\Views\Login\Detalles.cshtml"
WriteAttributeValue("", 1007, Model.pass, 1007, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1019, 167, true);
                WriteLiteral(" ></th>\n                <th scope=\"col\">XXXX</th>   \n                <th> \n                <input type=\"submit\" class=\"btn btn-success\"  value=\"Guardar\"> \n            ");
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
            BeginContext(1193, 543, true);
            WriteLiteral(@"                          
                    <button onclick=""myFunction()"" class=""btn btn-secondary"">Editar</button>               
                </th>                                   
        </tr>                
            
    </table>
    <a href=""../ViewSU"" class=""btn btn-warning"">Regresar</a>
<script>function myFunction() 
    {
        document.getElementById(""u"").disabled = false;
        document.getElementById(""n"").disabled = false;
        document.getElementById(""p"").disabled = false;        
    }
</script>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Usuarios> Html { get; private set; }
    }
}
#pragma warning restore 1591