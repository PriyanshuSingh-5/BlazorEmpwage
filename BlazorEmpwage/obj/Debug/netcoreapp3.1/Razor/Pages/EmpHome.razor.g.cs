#pragma checksum "C:\Users\K.R.DHASHNIGA\source\repos\BlazorEmpwage\BlazorEmpwage\Pages\EmpHome.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c43627c7448b54d93835863576d60df08ec651a3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorEmpwage.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\K.R.DHASHNIGA\source\repos\BlazorEmpwage\BlazorEmpwage\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\K.R.DHASHNIGA\source\repos\BlazorEmpwage\BlazorEmpwage\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\K.R.DHASHNIGA\source\repos\BlazorEmpwage\BlazorEmpwage\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\K.R.DHASHNIGA\source\repos\BlazorEmpwage\BlazorEmpwage\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\K.R.DHASHNIGA\source\repos\BlazorEmpwage\BlazorEmpwage\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\K.R.DHASHNIGA\source\repos\BlazorEmpwage\BlazorEmpwage\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\K.R.DHASHNIGA\source\repos\BlazorEmpwage\BlazorEmpwage\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\K.R.DHASHNIGA\source\repos\BlazorEmpwage\BlazorEmpwage\_Imports.razor"
using BlazorEmpwage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\K.R.DHASHNIGA\source\repos\BlazorEmpwage\BlazorEmpwage\_Imports.razor"
using BlazorEmpwage.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\K.R.DHASHNIGA\source\repos\BlazorEmpwage\BlazorEmpwage\Pages\EmpHome.razor"
using BlazorEmpwage.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/emphome")]
    public partial class EmpHome : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EmpHome</h3>\r\n");
            __builder.AddMarkupContent(1, "<h1>Employee Data</h1>\r\n");
            __builder.AddMarkupContent(2, "<p>This component demonstrates fetching Employee data from the server.</p>\r\n");
            __builder.AddMarkupContent(3, "<p>\r\n    <a href=\"/empwage\">Create New</a>\r\n</p>\r\n\r\n\r\n    ");
            __builder.AddMarkupContent(4, @"<table class=""table"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Gender</th>
                <th>Department</th>
                <th>City</th>
            </tr>
        </thead>
        <tbody>
            
               
            
        </tbody>
    </table>");
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\K.R.DHASHNIGA\source\repos\BlazorEmpwage\BlazorEmpwage\Pages\EmpHome.razor"
            
    Employee[] empList;
    protected  async Task OnInitAsync()
    {
       // empList = await Http.GetAsync(HttpMethod.Get, "/api/Employee/Index")
        
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
