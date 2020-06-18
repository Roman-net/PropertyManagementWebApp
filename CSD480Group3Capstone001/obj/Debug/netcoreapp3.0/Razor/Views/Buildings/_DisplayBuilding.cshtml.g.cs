#pragma checksum "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Buildings\_DisplayBuilding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "036505745666ca46b1d7dc3a6f39e1dab1eda4ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buildings__DisplayBuilding), @"mvc.1.0.view", @"/Views/Buildings/_DisplayBuilding.cshtml")]
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
#line 1 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\_ViewImports.cshtml"
using CSD480Group3Capstone001;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\_ViewImports.cshtml"
using CSD480Group3Capstone001.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"036505745666ca46b1d7dc3a6f39e1dab1eda4ab", @"/Views/Buildings/_DisplayBuilding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709983a7153eab3563b50021aa9fef6ab9036835", @"/Views/_ViewImports.cshtml")]
    public class Views_Buildings__DisplayBuilding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CSD480Group3Capstone001.Models.Building>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 4 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Buildings\_DisplayBuilding.cshtml"
      
        //TODO: this was just the fastest way to display some of the information that is availble from our building model at this point. this should be cleaned up and possibly more data displayed
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 9 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Buildings\_DisplayBuilding.cshtml"
       Write(Html.DisplayNameFor(model => model.OrgName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 12 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Buildings\_DisplayBuilding.cshtml"
       Write(Html.DisplayFor(model => model.OrgName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Tax Parcel\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Buildings\_DisplayBuilding.cshtml"
       Write(Model.TaxParcelNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n");
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                Tenants\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 26 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Buildings\_DisplayBuilding.cshtml"
                 foreach (Unit u in Model.Units)
                    {
                        foreach (var tu in u.TenantUnits.Where(tu=>DateTime.Compare(tu.MovedOutDate,DateTime.Now) > 0))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
#nullable restore
#line 30 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Buildings\_DisplayBuilding.cshtml"
                          Write(tu.tenant.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Buildings\_DisplayBuilding.cshtml"
                                               Write(tu.tenant.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 31 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Buildings\_DisplayBuilding.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                Vehicles\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 38 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Buildings\_DisplayBuilding.cshtml"
                 foreach (Unit u in Model.Units)
                    {
                        foreach (TenantUnit tu in u.TenantUnits.Where(tu=>DateTime.Compare(tu.MovedOutDate,DateTime.Now) > 0))
                        {
                            foreach (Vehicle v in tu.tenant.Vehicles)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>");
#nullable restore
#line 44 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Buildings\_DisplayBuilding.cshtml"
                              Write(v.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 44 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Buildings\_DisplayBuilding.cshtml"
                                      Write(v.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" plate number: ");
#nullable restore
#line 44 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Buildings\_DisplayBuilding.cshtml"
                                                             Write(v.LicensePlate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 45 "C:\CSD SPRING 2020\CSD480 CAPSTONE\PRESENTATION\FinalSolution\CSD480Group3Capstone001\Views\Buildings\_DisplayBuilding.cshtml"
                            }
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dd>\r\n");
            WriteLiteral("    </dl>\r\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSD480Group3Capstone001.Models.Building> Html { get; private set; }
    }
}
#pragma warning restore 1591