#pragma checksum "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d3a5fad9b7f5363a8b991281b20c2475aeb57c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_Index), @"mvc.1.0.view", @"/Views/Carrinho/Index.cshtml")]
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
#line 1 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d3a5fad9b7f5363a8b991281b20c2475aeb57c0", @"/Views/Carrinho/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb067812bb359391c8184da98976d01e122af00a", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NerdStore.Vendas.Application.Queries.ViewModels.CarrinhoViewModel>
    {
        private global::AspNetCore.Views_Carrinho_Index.__Generated__SummaryViewComponentTagHelper __SummaryViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vitrine", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProdutoDetalhe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoverItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AplicarVoucher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResumoDaCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12 col-md-10 col-md-offset-1\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:summary", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d3a5fad9b7f5363a8b991281b20c2475aeb57c07374", async() => {
            }
            );
            __SummaryViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Carrinho_Index.__Generated__SummaryViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__SummaryViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
              
                if (Model?.Items != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>Produto</th>
                                <th>Quantidade</th>
                                <th class=""text-center"">Valor</th>
                                <th class=""text-center"">Valor Total</th>
                                <th> </th>
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 26 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                              
                                foreach (var item in Model.Items)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <tr>
                                        <td class=""col-sm-5 col-md-5"">
                                            <div class=""media"">
                                                <div class=""media-body"">
                                                    <h4 class=""media-heading"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d3a5fad9b7f5363a8b991281b20c2475aeb57c09728", async() => {
#nullable restore
#line 33 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                                                                                                                                                                Write(item.ProdutoNome);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                                                                                                                                        WriteLiteral(item.ProdutoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h4>
                                                </div>
                                            </div>
                                        </td>

                                        <td class=""col-sm-2 col-md-2"" style=""text-align: center"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d3a5fad9b7f5363a8b991281b20c2475aeb57c012811", async() => {
                WriteLiteral("\r\n                                                <input type=\"hidden\" id=\"Id\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 1876, "\"", 1899, 1);
#nullable restore
#line 40 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
WriteAttributeValue("", 1884, item.ProdutoId, 1884, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                <div class=\"row\" style=\"float: left\">\r\n                                                    <input style=\"width: 70px\" type=\"text\" class=\"form-control\" name=\"quantidade\" id=\"quantidade\"");
                BeginWriteAttribute("value", " value=\"", 2137, "\"", 2161, 1);
#nullable restore
#line 42 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
WriteAttributeValue("", 2145, item.Quantidade, 2145, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                </div>
                                                <div class=""row"" style=""float: right"">
                                                    <button type=""submit"" class=""btn btn-success"">
                                                        <span class=""fas fa-sync""></span>
                                                    </button>
                                                </div>
                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"col-sm-1 col-md-1 text-center\"><strong>");
#nullable restore
#line 51 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                                                                                     Write(item.ValorUnitario.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                                        <td class=\"col-sm-1 col-md-1 text-center\"><strong>");
#nullable restore
#line 52 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                                                                                     Write(item.ValorTotal.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n\r\n                                        <td class=\"col-sm-1 col-md-1\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d3a5fad9b7f5363a8b991281b20c2475aeb57c017315", async() => {
                WriteLiteral("\r\n                                                <input type=\"hidden\" id=\"Id\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 3271, "\"", 3294, 1);
#nullable restore
#line 56 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
WriteAttributeValue("", 3279, item.ProdutoId, 3279, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                                <button type=""submit"" class=""btn btn-danger"">
                                                    <span class=""fas fa-trash-alt""></span> Remover
                                                </button>
                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 63 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <tr>
                                <td> </td>
                                <td> </td>
                                <td> </td>
                                <td><h5>Subtotal</h5></td>
                                <td class=""text-right""><h5><strong>");
#nullable restore
#line 71 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                                                              Write(Model.SubTotal.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h5></td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td> </td>\r\n                                <td colspan=\"2\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d3a5fad9b7f5363a8b991281b20c2475aeb57c021121", async() => {
                WriteLiteral("\r\n                                        <div class=\"row\" style=\"float: left\">\r\n                                            <input placeholder=\"Voucher\" style=\"width: 150px\" type=\"text\" class=\"form-control\" name=\"VoucherCodigo\" id=\"VoucherCodigo\"");
                BeginWriteAttribute("value", " value=\"", 4628, "\"", 4656, 1);
#nullable restore
#line 78 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
WriteAttributeValue("", 4636, Model.VoucherCodigo, 4636, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                        <div class=""row"" style=""float: right"">
                                            <button type=""submit"" class=""btn btn-success"">
                                                <span class=""fas fa-sync""></span>
                                            </button>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td><h5>Desconto</h5></td>\r\n                                <td class=\"text-right\"><h5><strong>");
#nullable restore
#line 88 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                                                              Write(Model.ValorDesconto.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></h5></td>
                            </tr>
                            <tr>
                                <td> </td>
                                <td> </td>
                                <td> </td>
                                <td>
                                    <h3>Total</h3>
                                </td>
                                <td class=""text-right"">
                                    <h3><strong>");
#nullable restore
#line 98 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                                           Write(Model.ValorTotal.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></h3>
                                </td>
                            </tr>
                            <tr>
                                <td> </td>
                                <td> </td>
                                <td> </td>
                                <td>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d3a5fad9b7f5363a8b991281b20c2475aeb57c025610", async() => {
                WriteLiteral("\r\n                                        <span class=\"fa fa-shopping-cart\"></span>Continuar Compra\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d3a5fad9b7f5363a8b991281b20c2475aeb57c027309", async() => {
                WriteLiteral("\r\n                                        <span class=\"fas fa-play\"></span><br /> Finalizar Compra\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 118 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div><p>Carrinho Vazio</p></div>\r\n");
#nullable restore
#line 122 "C:\Estudo\Ecomerce-MVC-DDD-CQRS\src\NerdStore.WebApp.MVC\Views\Carrinho\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NerdStore.Vendas.Application.Queries.ViewModels.CarrinhoViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:summary")]
        public class __Generated__SummaryViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__SummaryViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("Summary", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
