﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using NiceApiLibrary.ASP_AppCode;

public partial class HowItWorks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // This come from an anonymous browser
        Page.MetaKeywords = "HowTo, Send Whatsapp message, Free";
        Page.MetaDescription = "See how our service works.";
        NiceASP.KeywordLoader.Load(this, NiceASP.KeywordLoader.Which.HowItWorks);
    }
}