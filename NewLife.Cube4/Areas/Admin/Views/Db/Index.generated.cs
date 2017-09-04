﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 1 "..\..\Areas\Admin\Views\Db\Index.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    
    #line 2 "..\..\Areas\Admin\Views\Db\Index.cshtml"
    using NewLife.Cube.Admin;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    
    #line 3 "..\..\Areas\Admin\Views\Db\Index.cshtml"
    using XCode.DataAccessLayer;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Db/Index.cshtml")]
    public partial class _Areas_Admin_Views_Db_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Db_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Areas\Admin\Views\Db\Index.cshtml"
  
    Layout = NewLife.Cube.Setting.Current.Layout;

    //ViewBag.Title = "服务器信息";
    var dbs = Model as IList<DbItem>;

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">名称</th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">类型</th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">连接字符串</th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">版本</th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">备份</th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">备份并压缩</th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">下载表结构</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 23 "..\..\Areas\Admin\Views\Db\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 23 "..\..\Areas\Admin\Views\Db\Index.cshtml"
         foreach (var item in dbs)
        {
            var dal = DAL.Create(item.Name);

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>");

            
            #line 27 "..\..\Areas\Admin\Views\Db\Index.cshtml"
               Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 28 "..\..\Areas\Admin\Views\Db\Index.cshtml"
               Write(item.Type);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td><span");

WriteAttribute("title", Tuple.Create(" title=\"", 897), Tuple.Create("\"", 929)
            
            #line 29 "..\..\Areas\Admin\Views\Db\Index.cshtml"
, Tuple.Create(Tuple.Create("", 905), Tuple.Create<System.Object, System.Int32>(dal.Db.ConnectionString
            
            #line default
            #line hidden
, 905), false)
);

WriteLiteral(">");

            
            #line 29 "..\..\Areas\Admin\Views\Db\Index.cshtml"
                                                      Write(item.ConnStr);

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n                <td>");

            
            #line 30 "..\..\Areas\Admin\Views\Db\Index.cshtml"
               Write(item.Version);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 31 "..\..\Areas\Admin\Views\Db\Index.cshtml"
               Write(Html.ActionLink("备份", "Backup", new { Name = item.Name }));

            
            #line default
            #line hidden
WriteLiteral("，共 ");

            
            #line 31 "..\..\Areas\Admin\Views\Db\Index.cshtml"
                                                                            Write(item.Backups.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("个</td>\r\n                <td>");

            
            #line 32 "..\..\Areas\Admin\Views\Db\Index.cshtml"
               Write(Html.ActionLink("备份并压缩", "BackupAndCompress", new { Name = item.Name }));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 33 "..\..\Areas\Admin\Views\Db\Index.cshtml"
                                   Write(Html.ActionLink("下载", "Download", new { Name = item.Name }));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n            </tr>\r\n");

            
            #line 35 "..\..\Areas\Admin\Views\Db\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591