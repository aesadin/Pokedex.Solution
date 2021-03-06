#pragma checksum "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f065d4bd1930b1a678417578afdf99d37a8e900"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PokeTypes_Index), @"mvc.1.0.view", @"/Views/PokeTypes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PokeTypes/Index.cshtml", typeof(AspNetCore.Views_PokeTypes_Index))]
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
#line 5 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Index.cshtml"
using PokedexClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f065d4bd1930b1a678417578afdf99d37a8e900", @"/Views/PokeTypes/Index.cshtml")]
    public class Views_PokeTypes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PokedexClient.Models.PokeType>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(101, 34, true);
            WriteLiteral("\n<h1>All Pokémon Types</h1>\n<hr/>\n");
            EndContext();
#line 10 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Index.cshtml"
 if(@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(160, 49, true);
            WriteLiteral("  <h3>No Pokémon Types have been added yet!</h3>\n");
            EndContext();
#line 13 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Index.cshtml"
}

#line default
#line hidden
#line 14 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Index.cshtml"
 foreach(PokeType pokeType in Model)
{

#line default
#line hidden
            BeginContext(250, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(257, 88, false);
#line 16 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Index.cshtml"
 Write(Html.ActionLink($"{pokeType.PokeTypeName}", "Details", new { id = pokeType.PokeTypeId }));

#line default
#line hidden
            EndContext();
            BeginContext(345, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 17 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PokedexClient.Models.PokeType>> Html { get; private set; }
    }
}
#pragma warning restore 1591
