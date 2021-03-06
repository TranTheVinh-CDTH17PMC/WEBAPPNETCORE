#pragma checksum "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54c36e39479429f8268b19a680e5f97216bfdddd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SaleReport_DoanhThuTheoThang), @"mvc.1.0.view", @"/Areas/Admin/Views/SaleReport/DoanhThuTheoThang.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c36e39479429f8268b19a680e5f97216bfdddd", @"/Areas/Admin/Views/SaleReport/DoanhThuTheoThang.cshtml")]
    public class Areas_Admin_Views_SaleReport_DoanhThuTheoThang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Models.DoanhThuTheoTungThang>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml"
  
    ViewData["Title"] = "DoanhThuTheoThang";
    Layout = "~/Views/Shared/ACE_Layout_Admin.cshtml";
    var i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"" id=""container-wrapper"">
    <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
        <h1 class=""h3 mb-0 text-gray-800"">Báo cáo doanh thu theo tháng</h1>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""./"">Trang chủ</a></li>
            <li class=""breadcrumb-item"">Báo cáo</li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Doanh thu theo tháng</li>
        </ol>
    </div>
    <div class=""row"">
        <div class=""col-lg-12 mb-4"">
            <!-- Simple Tables -->
            <div class=""card"">
");
#nullable restore
#line 22 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml"
                 using (Html.BeginForm("DoanhThuTheoThang", "SaleReport", FormMethod.Get))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                        <div class=""col-md-4"">
                            <select class=""form-control "" data-val=""true"" data-val-number=""The field Loại người dùng must be a number."" data-val-required=""Bắt buộc nhập"" id=""s_year"" name=""s_year"">
");
#nullable restore
#line 27 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml"
                                 foreach (var item in ViewBag.year)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option ");
#nullable restore
#line 29 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml"
                                        Write(ViewBag.isyear == item.Value ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"");
#nullable restore
#line 29 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml"
                                                                                                Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Năm ");
#nullable restore
#line 29 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml"
                                                                                                                 Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 30 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </select>
                        </div>
                        <div class=""col-md-8"">
                            <button type=""submit"" class=""btn btn-primary"" style=""width: 12%;border: 1px solid grey;border-left: none;""><i class=""fa fa-search""></i></button>
                           
                        </div>
                    </div>
");
#nullable restore
#line 38 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""table-responsive"">
                    <div class=""grid-mvc"" data-lang=""en"" data-gridname="""" data-selectable=""true"" data-multiplefilters=""false"">
                        <div class=""grid-wrap"">
                            <table class=""table table-striped grid-table"" id=""table-grid"">
                                <thead class=""thead-light"">
                                    <tr>
                                        <th class=""grid-header"">
                                            <div class=""grid-header-title"">
                                                <span>STT</span>
                                            </div>
                                        </th>
                                        <th class=""grid-header"">
                                            <div class=""grid-header-title"">
                                                <span>Tháng</span>
                                            </div>
                                 ");
            WriteLiteral(@"       </th>
                                        <th class=""grid-header"">
                                            <div class=""grid-header-title"">
                                                <span>Tổng tiền thu S0</span>
                                            </div>
                                        </th>
                                        <th class=""grid-header"">
                                            <div class=""grid-header-title"">
                                                <span>Tổng tiền chi S1</span>
                                            </div>
                                        </th>
                                        <th class=""grid-header"">
                                            <div class=""grid-header-title"">
                                                <span>Tiền lãi (S0-S1)</span>
                                            </div>
                                        </th>
                                </thead>
     ");
            WriteLiteral("                           <tbody>\r\n");
#nullable restore
#line 72 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"grid-row \">\r\n                                            <td class=\"grid-cell\" data-name=\"\">");
#nullable restore
#line 75 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml"
                                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"grid-cell\" data-name=\"\">\r\n                                                <span>Tháng ");
#nullable restore
#line 77 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml"
                                                       Write(item.Thang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </td>\r\n                                            <td class=\"grid-cell money1\" data-name=\"GhiChu\">");
#nullable restore
#line 79 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml"
                                                                                       Write(item.Tongthu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"grid-cell money1\" data-name=\"TongTien\">");
#nullable restore
#line 80 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml"
                                                                                         Write(item.Tongchi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"grid-cell money1\" data-name=\"TenKH\">");
#nullable restore
#line 81 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml"
                                                                                      Write(item.Loinhuan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml"
                                        i++;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                                <tfoot>
                                    <tr>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td>Tổng tiền :</td>
                                        <td class=""money1"" style=""color:blue"">");
#nullable restore
#line 92 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Areas\Admin\Views\SaleReport\DoanhThuTheoThang.cshtml"
                                                                         Write(ViewBag.tongtien);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    </tr>
                                </tfoot>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--Row-->
</div>


<script>
    function openpoupmy(value) {
        debugger
        var sd = $(""#s_year"").val();
        newwindow = window.open('/CMS_Sale/SaleReport/ExportToExcel?name=doanhthutheothang&s_year=' + sd + '&ExportExcel=' + value + '', 'print', 'height=500,width=500');

        setTimeout(function () {
        }, 500);
    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Models.DoanhThuTheoTungThang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
