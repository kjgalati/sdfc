﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDFC.Mobile
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //check if user has logged in. 
            if (LoggedIn())
            {
                Response.Redirect("Default.aspx"); //redirect
                return; //stop further execution
            }

            if (!this.IsPostBack)
            {
                this.Master.Title = "log In";
            }
            else
            {

            }
        }

        protected void Page_Unload(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Checks for username stored in session. If exists, the user has logged in.
        /// </summary>
        /// <returns>Log in status for user</returns>
        private bool LoggedIn()
        {
            return (Session["Username"] != null);
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            //To do: add a means of authenticating users
            Session["Username"] = "Username"; //for the time being, give a generic username

            Response.Redirect("Default.aspx");
        }
    }
}