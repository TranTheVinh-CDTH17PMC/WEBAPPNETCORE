#pragma checksum "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "992151a45be39d6adcbf5526717e87ee50d86834"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GioHang), @"mvc.1.0.view", @"/Views/Home/GioHang.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
using WebApp.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"992151a45be39d6adcbf5526717e87ee50d86834", @"/Views/Home/GioHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GioHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.ViewModels.GioHangViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("cart-product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
  
    ViewData["Title"] = "GioHang";
    Layout = "~/Views/Shared/ACE_Layout.cshtml";
    int i = 1;
    int x = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<style>
    .bg-dark {
        background-color: #343a40 !important;
    }

    .qty .count {
        color: #000;
        display: inline-block;
        vertical-align: top;
        font-size: 25px;
        font-weight: 700;
        line-height: 30px;
        padding: 0 2px;
        min-width: 35px;
        text-align: center;
    }

    .qty .plus {
        cursor: pointer;
        display: inline-block;
        vertical-align: top;
        color: white;
        width: 30px;
        height: 30px;
        font: 30px/1 Arial,sans-serif;
        text-align: center;
        border-radius: 50%;
    }

    .qty .minus {
        cursor: pointer;
        display: inline-block;
        vertical-align: t");
            WriteLiteral(@"op;
        color: white;
        width: 30px;
        height: 30px;
        font: 30px/1 Arial,sans-serif;
        text-align: center;
        border-radius: 50%;
        background-clip: padding-box;
    }

    div {
        text-align: center;
    }

    .minus:hover {
        background-color: #717fe0 !important;
    }

    .plus:hover {
        background-color: #717fe0 !important;
    }
    /*Prevent text selection*/
    span {
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
    }

    input {
        border: 0;
        width: 2%;
    }

        nput::-webkit-outer-spin-button,
        input::-webkit-inner-spin-button {
            -webkit-appearance: none;
            margin: 0;
        }

        input:disabled {
            background-color: white;
        }

    .mt-5, .my-5 {
        margin-top: 1rem !important;
    }
</style>
<div class=""wrapper"">
    <!--================= Breadcrumb =================");
            WriteLiteral(@"===-->
    <div class=""breadcrumb-top bg-yellow"">
        <div class=""container"">
            <h2>Giỏ Hàng</h2>
            <ol class=""breadcrumb"">
                <li><a href=""#"">Home</a></li>
                <li class=""active"">Cart</li>
            </ol><!--breadcrumb-->
        </div>
    </div>
    <!--================= End of Breadcrumb ====================-->
    <div class=""container"">
");
#nullable restore
#line 105 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
         using (Html.BeginForm("UpdateSL", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <!--================= Cart Inside ====================-->
        <div class=""cart-inside"">
            <h3>Giỏ hàng của bạn</h3>
            <table id=""table"">
                <thead>
                    <tr>
                        <td class=""table-product"">Ảnh SP</td>
                        <td class=""text-center"">Tên SP</td>
                        <td class=""text-center"">Size</td>
                        <td class=""text-center"">Đơn giá</td>
                        <td class=""text-center"">Số Lượng</td>
                        <td class=""text-center"">Tổng</td>
                        <td>&nbsp;</td>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 123 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
                     if (Model.CTGioHangViewModel != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
                         foreach (var item in Model.CTGioHangViewModel)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"product-thumbnail\"><a");
            BeginWriteAttribute("href", " href=\"", 3798, "\"", 3805, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "992151a45be39d6adcbf5526717e87ee50d868349167", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3817, "~/imageproducts/", 3817, 16, true);
#nullable restore
#line 128 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
AddHtmlAttributeValue("", 3833, Comon.ImgByIdSP(item.IdSp), 3833, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></td>\r\n                                <td class=\"product-name text-center\" data-title=\"Tên SP\">");
#nullable restore
#line 129 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
                                                                                    Write(Comon.NameByIdSP(item.IdSp));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"product-name text-center\" data-title=\"Size\">");
#nullable restore
#line 130 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
                                                                                  Write(item.IdSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"product-price text-center\" data-title=\"Price\"><span class=\"price\"");
            BeginWriteAttribute("id", " id=\"", 4248, "\"", 4262, 2);
            WriteAttributeValue("", 4253, "dongia_", 4253, 7, true);
#nullable restore
#line 131 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
WriteAttributeValue("", 4260, i, 4260, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 131 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
                                                                                                                       Write(item.DonGia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                <td class=\"product-quantity text-center\" data-title=\"Quantity\">\r\n                                    <div class=\"qty mt-5\">\r\n                                        <p class=\"minus bg-dark\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4511, "\"", 4530, 3);
            WriteAttributeValue("", 4521, "Giam(", 4521, 5, true);
#nullable restore
#line 134 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
WriteAttributeValue("", 4526, i, 4526, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4528, ");", 4528, 2, true);
            EndWriteAttribute();
            WriteLiteral(">-</p>\r\n                                        <input type=\"number\" class=\"count\"");
            BeginWriteAttribute("id", " id=\"", 4613, "\"", 4628, 2);
            WriteAttributeValue("", 4618, "soluong_", 4618, 8, true);
#nullable restore
#line 135 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
WriteAttributeValue("", 4626, i, 4626, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4629, "\"", 4650, 1);
#nullable restore
#line 135 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
WriteAttributeValue("", 4637, item.SoLuong, 4637, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <input style=\"display:none\"");
            BeginWriteAttribute("name", " name=\"", 4721, "\"", 4758, 3);
            WriteAttributeValue("", 4728, "CTGioHangViewModel[", 4728, 19, true);
#nullable restore
#line 136 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
WriteAttributeValue("", 4747, x, 4747, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4749, "].SoLuong", 4749, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4759, "\"", 4775, 2);
            WriteAttributeValue("", 4764, "soluong1_", 4764, 9, true);
#nullable restore
#line 136 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
WriteAttributeValue("", 4773, i, 4773, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4776, "\"", 4797, 1);
#nullable restore
#line 136 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
WriteAttributeValue("", 4784, item.SoLuong, 4784, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        <input style=\"display:none\"");
            BeginWriteAttribute("name", " name=\"", 4870, "\"", 4902, 3);
            WriteAttributeValue("", 4877, "CTGioHangViewModel[", 4877, 19, true);
#nullable restore
#line 137 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
WriteAttributeValue("", 4896, x, 4896, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4898, "].Id", 4898, 4, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4903, "\"", 4919, 1);
#nullable restore
#line 137 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
WriteAttributeValue("", 4911, item.Id, 4911, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        <p class=\"plus bg-dark\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4988, "\"", 5007, 3);
            WriteAttributeValue("", 4998, "Tang(", 4998, 5, true);
#nullable restore
#line 138 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
WriteAttributeValue("", 5003, i, 5003, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5005, ");", 5005, 2, true);
            EndWriteAttribute();
            WriteLiteral(">+</p>\r\n                                    </div>\r\n                                </td>\r\n                                <td class=\"product-price text-center\" data-title=\"Total\"><span class=\"price\"");
            BeginWriteAttribute("id", " id=\"", 5207, "\"", 5223, 2);
            WriteAttributeValue("", 5212, "tongtien_", 5212, 9, true);
#nullable restore
#line 141 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
WriteAttributeValue("", 5221, i, 5221, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span></td>\r\n                                <td class=\"product-remove text-right\"><img src=\"/assets/images/remove.png\" alt=\"remove\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5358, "\"", 5392, 3);
            WriteAttributeValue("", 5368, "DeleteSP(", 5368, 9, true);
#nullable restore
#line 142 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
WriteAttributeValue("", 5377, item.Id, 5377, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5385, ",this);", 5385, 7, true);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                            </tr>\r\n");
#nullable restore
#line 144 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
                            i++;
                            x++;
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr><td>Rỗng.</td></tr>\r\n");
#nullable restore
#line 151 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 155 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
             if (Model.CTGioHangViewModel != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"bottom-table\">\r\n                    <span><button type=\"submit\" class=\"custom-btn\"><img src=\"assets/images/refresh.png\"");
            BeginWriteAttribute("alt", " alt=\"", 5939, "\"", 5945, 0);
            EndWriteAttribute();
            WriteLiteral(">Cập nhật giỏ hàng</button></span>\r\n                </div>\r\n");
#nullable restore
#line 160 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <!--================= End of Cart Inside ====================-->\r\n            </div>\r\n");
#nullable restore
#line 164 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!--================= Checkout ====================-->\r\n");
#nullable restore
#line 166 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
         using (Html.BeginForm("ThanhToan", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"checkout bg-grey\">\r\n                <div class=\"container\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-8 center\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "992151a45be39d6adcbf5526717e87ee50d8683420888", async() => {
                WriteLiteral("\r\n                                <div class=\"form-group\">\r\n                                    <input name=\"diachi\" placeholder=\"Địa chỉ nhận hàng\" class=\"border-all border-color-extra-gray\"");
                BeginWriteAttribute("value", " value=\"", 6731, "\"", 6775, 1);
#nullable restore
#line 174 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
WriteAttributeValue("", 6739, Context.Session.GetString("diachi"), 6739, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n                                    <input name=\"sdt\" placeholder=\"Số điện thoại nhận hàng\" class=\"border-all border-color-extra-gray\"");
                BeginWriteAttribute("value", " value=\"", 7011, "\"", 7052, 1);
#nullable restore
#line 177 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
WriteAttributeValue("", 7019, Context.Session.GetString("sdt"), 7019, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""col-md-4"">
                            <!--===================== Checkout Form ========================-->
                            <div class=""checkout-form"">
                                <div class=""total"">
                                    <span>Tổng tiền thanh toán :</span><span class=""price"" id=""tongtien""></span>
                                </div><!--total-->
");
#nullable restore
#line 187 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
                                 if (Model.CTGioHangViewModel != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"text-right\"><button type=\"submit\" class=\"custom-btn\" data-toggle=\"modal\" data-target=\"#checkout-modal\">Thanh toán đơn hàng</button></div>\r\n");
#nullable restore
#line 190 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                            <!--===================== End of Checkout Form ========================-->
                            <!--===================== Checkout Modal ========================-->
                            <div class=""modal checkout-modal fade"" id=""checkout-modal"" tabindex=""-1"" role=""dialog"">
                                <div class=""modal-dialog"" role=""document"">
                                    <div class=""modal-content"">
                                        <h3>Thank you</h3>
                                        <p>for your purchase!</p>
                                        <button type=""button"" class=""btn"" data-dismiss=""modal""><img src=""assets/images/close.png"" alt=""close""></button>
                                    </div>
                                </div>
                            </div>
                            <!--===================== End of Checkout Modal ========================-->
                   ");
            WriteLiteral("     </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 208 "C:\Users\Admin\source\repos\WebApp\WEBAPPNETCORE\WebApp\Views\Home\GioHang.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <!--================= End of Checkout ====================-->
        </div>
</div><!--wrapper-->
<script>
    function newtest2(e) {
        $(e).parents('tr').remove();
            }
            function ConfirmDelete() {
                var x = confirm(""Bạn có chắc muốn khóa item đã chọn ?"");
                if (x)
                    return true;
                else
                    return false;
            }
            function DeleteSP(id,e) {
                ConfirmDelete();
                newtest2(e);
        $.ajax({
                url: ""/Home/DeleteSP/"",
            dataType: ""json"",
            type: ""GET"",
            contentType: 'application/json; charset=utf-8',
            data: { Id: id },
            success: function (data) {

                    },
            error: function (xhr) {
                        console.log(xhr);
                    }
                });
            TongTienSP();
        }
        function Tang(i) {
        $");
            WriteLiteral(@"('#soluong_' + i + '').val(parseInt($('#soluong_' + i + '').val()) + 1);
        $('#soluong1_' + i + '').val(parseInt($('#soluong1_' + i + '').val()) + 1);
            TongTienSP();
        }
        function Giam(i) {
        $('#soluong_' + i + '').val(parseInt($('#soluong_' + i + '').val()) - 1);
            if ($('#soluong_' + i + '').val() == 0) {
        $('#soluong_' + i + '').val(1);
            }
        $('#soluong1_' + i + '').val(parseInt($('#soluong1_' + i + '').val()) - 1);
            if ($('#soluong1_' + i + '').val() == 0) {
            $('#soluong1_' + i + '').val(1);
            }
            TongTienSP();
        }
    $(document).ready(function () {
            TongTienSP();
        });

    function TongTienSP() {
            var tongtien = 0;
        $('.count').prop('disabled', true);
            var rowCount = $('#table tr').length - 1;
        $('table > tbody  > tr').each(function (index, tr) {
                var dongia = $(""#dongia_"" + (index + 1) + """").te");
            WriteLiteral(@"xt();
                var soluong = $(""#soluong_"" + (index + 1) + """").val();
            $(""#tongtien_"" + (index + 1) + """").text(dongia * soluong);
                tongtien += parseInt($(""#tongtien_"" + (index + 1) + """").text());
            });
        debugger
        if (tongtien.toString() == ""NaN"") {
            tongtien = 0;
        }
        $(""#tongtien"").text(tongtien+"" VNĐ"");
            console.log(tongtien);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.ViewModels.GioHangViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
