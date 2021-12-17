#pragma checksum "C:\Users\edwmc\Documents\Coding Dojo\CSharp\ActivityCenter\Views\Home\ViewMeetup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99a7b006281f6e7bccd7c9bc0feed0715ec852bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewMeetup), @"mvc.1.0.view", @"/Views/Home/ViewMeetup.cshtml")]
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
#line 1 "C:\Users\edwmc\Documents\Coding Dojo\CSharp\ActivityCenter\Views\_ViewImports.cshtml"
using ActivityCenter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edwmc\Documents\Coding Dojo\CSharp\ActivityCenter\Views\_ViewImports.cshtml"
using ActivityCenter.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edwmc\Documents\Coding Dojo\CSharp\ActivityCenter\Views\Home\ViewMeetup.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99a7b006281f6e7bccd7c9bc0feed0715ec852bb", @"/Views/Home/ViewMeetup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewMeetup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Meetup>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
            WriteLiteral("    <br>\r\n    <h3>Event Coordinator: ");
#nullable restore
#line 7 "C:\Users\edwmc\Documents\Coding Dojo\CSharp\ActivityCenter\Views\Home\ViewMeetup.cshtml"
                      Write(Model.user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <br>\r\n    <h3>Description:</h3>\r\n    <p>");
#nullable restore
#line 10 "C:\Users\edwmc\Documents\Coding Dojo\CSharp\ActivityCenter\Views\Home\ViewMeetup.cshtml"
  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <br>\r\n    <h3>Participants</h3>\r\n    <ul>\r\n");
#nullable restore
#line 14 "C:\Users\edwmc\Documents\Coding Dojo\CSharp\ActivityCenter\Views\Home\ViewMeetup.cshtml"
          
            if(Model.Guests.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>No Guests Yet</li>\r\n");
#nullable restore
#line 18 "C:\Users\edwmc\Documents\Coding Dojo\CSharp\ActivityCenter\Views\Home\ViewMeetup.cshtml"
            }
            else
            {
                foreach(RSVP g in Model.Guests)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 23 "C:\Users\edwmc\Documents\Coding Dojo\CSharp\ActivityCenter\Views\Home\ViewMeetup.cshtml"
                   Write(g.User.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 24 "C:\Users\edwmc\Documents\Coding Dojo\CSharp\ActivityCenter\Views\Home\ViewMeetup.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <br>\r\n");
#nullable restore
#line 29 "C:\Users\edwmc\Documents\Coding Dojo\CSharp\ActivityCenter\Views\Home\ViewMeetup.cshtml"
      
        if(Context.Session.GetInt32("UserId") != Model.UserId)
        {
            if(!Model.Guests.Any(g => g.UserId == Context.Session.GetInt32("UserId"))){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 817, "\"", 852, 2);
            WriteAttributeValue("", 824, "/meetup/join/", 824, 13, true);
#nullable restore
#line 33 "C:\Users\edwmc\Documents\Coding Dojo\CSharp\ActivityCenter\Views\Home\ViewMeetup.cshtml"
WriteAttributeValue("", 837, Model.MeetupId, 837, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Join</a>\r\n");
#nullable restore
#line 34 "C:\Users\edwmc\Documents\Coding Dojo\CSharp\ActivityCenter\Views\Home\ViewMeetup.cshtml"

            }
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Meetup> Html { get; private set; }
    }
}
#pragma warning restore 1591
