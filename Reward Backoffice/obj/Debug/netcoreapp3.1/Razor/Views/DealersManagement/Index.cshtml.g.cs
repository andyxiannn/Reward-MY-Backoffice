#pragma checksum "D:\inetpub\Reward Backoffice\Reward Backoffice\Views\DealersManagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dac4db8c57775eb04a05b18b7c951ed32882257"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DealersManagement_Index), @"mvc.1.0.view", @"/Views/DealersManagement/Index.cshtml")]
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
#line 1 "D:\inetpub\Reward Backoffice\Reward Backoffice\Views\_ViewImports.cshtml"
using Reward_Backoffice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\inetpub\Reward Backoffice\Reward Backoffice\Views\_ViewImports.cshtml"
using Reward_Backoffice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dac4db8c57775eb04a05b18b7c951ed32882257", @"/Views/DealersManagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e97ea1abd549a65cdf9fc4e723982772628e8a42", @"/Views/_ViewImports.cshtml")]
    public class Views_DealersManagement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/datatable/dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/datatable/jquery.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DealersManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dac4db8c57775eb04a05b18b7c951ed328822576213", async() => {
                WriteLiteral(@"
    <link href=""https://cdn.datatables.net/1.10.22/css/jquery.dataTables.min.css"" rel=""stylesheet"" />
    <script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.18/js/jquery.dataTables.min.js"" defer></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js""></script>
    <link href=""https://netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap-glyphicons.css"" rel=""stylesheet"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dac4db8c57775eb04a05b18b7c951ed328822577101", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script src=\"//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9dac4db8c57775eb04a05b18b7c951ed328822578379", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9dac4db8c57775eb04a05b18b7c951ed328822579558", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"row pt-4\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-primary\">Dealer List</h2>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dac4db8c57775eb04a05b18b7c951ed3288225711647", async() => {
                WriteLiteral("\r\n                <i class=\"fas fa-plus\"></i> &nbsp; Add New Dealer\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    
    <br /><br />
    <div class=""row"">
        <div class=""col-lg-12 "">
            <div class=""table-responsive"">
                <table id=""tblDealers"" class=""table table-striped table-bordered table-hover dataTable no-footer"">
                    <thead>
                        <tr role=""row"">
                            <th>Dealer Id</th>
                            <th>Name</th>
                            <th>Code</th>
                            <th>Branch</th>
                            <th>Status</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                    </tbody>
                </table>
            </div>
        </div>
    </div>

    <script type=""text/javascript"">
    $(document).ready(function () {
        $('#tblDealers').DataTable({
            ""ajax"": {
                ""url"": '/api/Dealers/GetDealers',
                ""dataSrc"": ''
       ");
            WriteLiteral(@"     },
            bAutoWidth: false,
            columns: [
                { data: 'DealerId' },
                { data: 'Name', className: ""text-center""},
                { data: 'Code', className: ""text-center""},
                { data: 'Branch', className: ""text-center""},
                {
                    data: 'status',
                    render: function (data, type, row) {
                        return (data === true) ? ""<span class='glyphicon glyphicon-ok'></span > "" : "" <span class='glyphicon glyphicon-remove'></span > "";
                    },
                    className: ""text-center""
                },
                {
                    data: ""id"",
                    render: function (data, type, row, meta) {
                        return  ""<button class='btn btn-success' style='margin-right:5px;' onclick=View("" + JSON.stringify(row) + "")>View</button>"" +
                                ""<button class='btn btn-primary' style='margin-right:5px;' onclick=Edit("" + JSO");
            WriteLiteral(@"N.stringify(row) + "")>Edit</button>"" +
                                ""<button class='btn btn-danger' style='margin-right:5px;' onclick= Delete("" + JSON.stringify(row) + "")>Delete</button>"";
                    },
                    className: ""text-center""
                },

            ]
        });

        
    });

    function Edit(oDealer) {
       var url = '");
#nullable restore
#line 85 "D:\inetpub\Reward Backoffice\Reward Backoffice\Views\DealersManagement\Index.cshtml"
             Write(Url.Action("Edit", "DealersManagement", new { id = "__id__" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        window.location.href = url.replace('__id__', oDealer.DealerId);
    }

    function Delete(oDealer) {
      /* $.delete(""api/Dealer?id="" + oDealer.DealerId, function () {
            alert(""Deleted"");
            ReloadGrid();
        });*/
        //if (confirm(""Are you sure?""))
        //{
            //var url = '");
#nullable restore
#line 96 "D:\inetpub\Reward Backoffice\Reward Backoffice\Views\DealersManagement\Index.cshtml"
                    Write(Url.Action("Delete", "DealersManagement", new { id = "__id__" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
            //window.location.href = url.replace('__id__', oDealer.DealerId);
        //}
        //return false;

        swal({
            title: ""Are you sure?"",
            text: ""Once deleted, you will not be able to recover"",
            icon: ""warning"",
            dangerMode: true,
            buttons: [
            'No, cancel it!',
            'Yes, I am sure!'
          ],

        }).then((willDelete) => {

            if (willDelete) {
                var url = '");
#nullable restore
#line 114 "D:\inetpub\Reward Backoffice\Reward Backoffice\Views\DealersManagement\Index.cshtml"
                      Write(Url.Action("Delete", "DealersManagement", new { id = "__id__" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
                window.location.href = url.replace('__id__', oDealer.DealerId);
                $.ajax({
                    type: ""POST"",
                    url: url,
                    success: function (data) {

                        alert(""Successfully Deleted ! "");

                        window.location.href = '");
#nullable restore
#line 123 "D:\inetpub\Reward Backoffice\Reward Backoffice\Views\DealersManagement\Index.cshtml"
                                           Write(Url.Action("Index", "DealersManagement"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
                        ReloadGrid();

                       //swal(""Deleted"", ""Your Dealer is deleted :)"", ""success"");
                    }
                })

            }
            else
            {
                swal(""Cancelled"", ""Your Dealer is safe :)"", ""error"");
            }

        }

        )

    }
    function View(oDealer) {
        var url = '");
#nullable restore
#line 142 "D:\inetpub\Reward Backoffice\Reward Backoffice\Views\DealersManagement\Index.cshtml"
              Write(Url.Action("Views", "DealersManagement", new { id = "__id__" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        window.location.href = url.replace(\'__id__\', oDealer.DealerId);\r\n    }\r\n\r\n    function ReloadGrid() {\r\n        $(\'#tblDealers\').DataTable().clear();\r\n        $(\'#tblDealers\').DataTable().ajax.reload();\r\n    }\r\n\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
