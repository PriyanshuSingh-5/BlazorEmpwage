// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\K.R.DHASHNIGA\source\repos\BlazorEmpwage\BlazorEmpwage\Pages\EmpApp.razor"
using BlazorEmpwage.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/empwage")]
    public partial class EmpApp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 209 "C:\Users\K.R.DHASHNIGA\source\repos\BlazorEmpwage\BlazorEmpwage\Pages\EmpApp.razor"
 
    public bool Checksubmit = false;
    Employee Emp = new Employee();

    public void SubmitData()
    {
        service.SaveEmployee(Emp);
        Emp = new Employee();
        navigation.NavigateTo("/empwage");
    }

    protected async Task CreateCustomer()
    {
        //controller.Create(Emp);
        //await ClientFactory.SendJsonAsync(HttpMethod.Post, "/api/Employee/Create", Emp);
        // using var response = await HttpClient.PostAsJsonAsync("https://reqres.in/api/articles", postBody);
        navigation.NavigateTo("/empwage");
    }
    void Cancel()
    {
        navigation.NavigateTo("/empwage");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmpService service { get; set; }
    }
}
#pragma warning restore 1591
