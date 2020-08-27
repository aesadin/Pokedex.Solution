#pragma checksum "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3db38250420a559d44b3d778971c626e5a0a773c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PokeTypes_Details), @"mvc.1.0.view", @"/Views/PokeTypes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PokeTypes/Details.cshtml", typeof(AspNetCore.Views_PokeTypes_Details))]
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
#line 5 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Details.cshtml"
using PokedexClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3db38250420a559d44b3d778971c626e5a0a773c", @"/Views/PokeTypes/Details.cshtml")]
    public class Views_PokeTypes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PokedexClient.Models.PokeType>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(94, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(100, 48, false);
#line 8 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Details.cshtml"
Write(Html.DisplayNameFor(model => model.PokeTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(148, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(151, 44, false);
#line 8 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.PokeTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(195, 23, true);
            WriteLiteral(" -Type Details:</h1>   ");
            EndContext();
            BeginContext(272, 9, true);
            WriteLiteral("\n\n<hr/>\n\n");
            EndContext();
#line 12 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Details.cshtml"
 if(@Model.Pokemon.Count == 0)
{

#line default
#line hidden
            BeginContext(314, 61, true);
            WriteLiteral("  <p>There are no pokemon associated with this poketype!</p>\n");
            EndContext();
#line 15 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(384, 40, true);
            WriteLiteral("  <h3>Pokemon of this type:</h3>\n  <ul>\n");
            EndContext();
#line 20 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Details.cshtml"
     foreach (Pokemon pokemon in @Model.Pokemon)
    {

#line default
#line hidden
            BeginContext(479, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(490, 90, false);
#line 22 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Details.cshtml"
     Write(Html.ActionLink($"{pokemon.Species}", "Details", "Pokemon", new {id = @pokemon.PokemonId}));

#line default
#line hidden
            EndContext();
            BeginContext(580, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 23 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Details.cshtml"
    }

#line default
#line hidden
            BeginContext(592, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 25 "/Users/Henager/Desktop/Pokedex.Solution/PokedexClient/Views/PokeTypes/Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PokedexClient.Models.PokeType> Html { get; private set; }
    }
}
#pragma warning restore 1591
