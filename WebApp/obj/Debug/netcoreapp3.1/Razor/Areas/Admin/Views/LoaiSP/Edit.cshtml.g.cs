#pragma checksum "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\LoaiSP\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14210775c0a6d25f7c3491c1cbd924a5cf4b4ca7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_LoaiSP_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/LoaiSP/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14210775c0a6d25f7c3491c1cbd924a5cf4b4ca7", @"/Areas/Admin/Views/LoaiSP/Edit.cshtml")]
    public class Areas_Admin_Views_LoaiSP_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Areas.Admin.Models.LoaiSPViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\LoaiSP\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/ACE_Layout_Admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<div class=\"container-fluid\" id=\"container-wrapper\">\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-lg-6\">\r\n            <!-- Form Basic -->\r\n");
#nullable restore
#line 14 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\LoaiSP\Edit.cshtml"
             using (Html.BeginForm())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card mb-4"">
                    <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                        <h6 class=""m-0 font-weight-bold text-primary"">Cập nhật loại sản phẩm</h6>
                    </div>
                    <div class=""card-body"" style=""margin-top:-13px"">
                        <div class=""form-group"">
                            <label>Tên loại sản phẩm</label>
                            ");
#nullable restore
#line 23 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\LoaiSP\Edit.cshtml"
                       Write(Html.TextBoxFor(model => model.Ten, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <button class=""btn btn-mini btn-primary"" id=""Save"" type=""submit"" name=""Submit"">
                            <i class=""ace-icon fa fa-save""></i> Lưu
                        </button>
                    </div>

                </div>
");
#nullable restore
#line 31 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\LoaiSP\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>
<script>
    $(""#Save"").click(function () {
        var tenloai = $('#Ten').val();
        if (tenloai == """") {
            swal({
                text: ""Chưa nhập tên loại sản phẩm!"",
                icon: ""warning"",
                button: ""Đồng ý"",
            });
            return false;
        }
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Areas.Admin.Models.LoaiSPViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
