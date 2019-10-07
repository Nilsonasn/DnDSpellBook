#pragma checksum "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\Components\CasterComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccfc4d6603cab537107fb51526d5984dbb47fbda"
// <auto-generated/>
#pragma warning disable 1591
namespace DNDSpellBook.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\_Imports.razor"
using DNDSpellBook;

#line default
#line hidden
#line 7 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\_Imports.razor"
using DNDSpellBook.Shared;

#line default
#line hidden
#line 8 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\_Imports.razor"
using DNDSpellBook.Models;

#line default
#line hidden
    public class CasterComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "caster-item");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<DNDSpellBook.Components.ExpanderComponent>(3);
            __builder.AddAttribute(4, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 2 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\Components\CasterComponent.razor"
                               Caster.CasterName.ToString()

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "ExpanderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n");
#line 4 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\Components\CasterComponent.razor"
             foreach (CastLevel cl in Enum.GetValues(typeof(CastLevel)).Cast<CastLevel>().ToList())
            {
                if (Caster.ClassSpells.Any(sp => sp.Level == cl))
                {

#line default
#line hidden
                __builder2.AddContent(7, "                    ");
                __builder2.OpenComponent<DNDSpellBook.Components.ExpanderComponent>(8);
                __builder2.AddAttribute(9, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 8 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\Components\CasterComponent.razor"
                                               Spell.CastLevelToString(cl)

#line default
#line hidden
                ));
                __builder2.AddAttribute(10, "ExpanderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n                            ");
                    __builder3.OpenElement(12, "table");
                    __builder3.AddMarkupContent(13, "\r\n                                ");
                    __builder3.AddMarkupContent(14, @"<tr>
                                    <th>Spell Name</th>
                                    <th>Range</th>
                                    <th>Duration</th>
                                    <th>Cast Time</th>
                                    <th>Page Number</th>
                                </tr>

");
#line 19 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\Components\CasterComponent.razor"
                                 foreach (Spell spell in Caster.ClassSpells.Where(sp => sp.Level == cl))
                                {

#line default
#line hidden
                    __builder3.AddContent(15, "                                    ");
                    __builder3.OpenElement(16, "tr");
                    __builder3.AddMarkupContent(17, "\r\n                                        ");
                    __builder3.OpenElement(18, "td");
                    __builder3.AddContent(19, 
#line 22 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\Components\CasterComponent.razor"
                                             spell.Name

#line default
#line hidden
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(20, "\r\n                                        ");
                    __builder3.OpenElement(21, "td");
                    __builder3.AddContent(22, 
#line 23 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\Components\CasterComponent.razor"
                                             spell.Range

#line default
#line hidden
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(23, "\r\n                                        ");
                    __builder3.OpenElement(24, "td");
                    __builder3.AddContent(25, 
#line 24 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\Components\CasterComponent.razor"
                                             spell.Duration

#line default
#line hidden
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(26, "\r\n                                        ");
                    __builder3.OpenElement(27, "td");
                    __builder3.AddContent(28, 
#line 25 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\Components\CasterComponent.razor"
                                             spell.Casting_Time

#line default
#line hidden
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(29, "\r\n                                        ");
                    __builder3.OpenElement(30, "td");
                    __builder3.AddContent(31, 
#line 26 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\Components\CasterComponent.razor"
                                             spell.Page

#line default
#line hidden
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(32, "\r\n                                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(33, "\r\n");
#line 28 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\Components\CasterComponent.razor"
                                }

#line default
#line hidden
                    __builder3.AddMarkupContent(34, "                                    \r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(35, "\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n");
#line 33 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\Components\CasterComponent.razor"
                }
            }

#line default
#line hidden
                __builder2.AddContent(37, "        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 39 "C:\Users\mrand\Documents\KILL ME\DnDSpellBook\DNDSpellBook\Components\CasterComponent.razor"
       
    [Parameter] public CasterClass Caster { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591