#pragma checksum "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ada407e4241236d76b0b62f7500675940b280ca9"
// <auto-generated/>
#pragma warning disable 1591
namespace CascandingValue.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\_Imports.razor"
using CascandingValue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\_Imports.razor"
using CascandingValue.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\_Imports.razor"
using CascandingValue.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn" + " " + (
#nullable restore
#line 7 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\Pages\Counter.razor"
                    tema.ButtonClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\Pages\Counter.razor"
                                                IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
#nullable restore
#line 9 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\Pages\Counter.razor"
 foreach (var item in tema.ListaUnidades)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "    ");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, 
#nullable restore
#line 11 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\Pages\Counter.razor"
        item.CodUnidade

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " - ");
            __builder.AddContent(14, 
#nullable restore
#line 11 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\Pages\Counter.razor"
                           item.NomeUnidade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 12 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\Pages\Counter.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\PROJETOS E ARQUIVOS DE TRABALHO\PROJETOS\EXEMPLOS\CascandingValue\Pages\Counter.razor"
       
    /*
     Para recepcionar um valor passado por cascata em um componente filho,
     precisamos criar um parâmetro do tipo CascadingParameter.
    */

    [CascadingParameter]
    public Tema tema { get; set; }

    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
