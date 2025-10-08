using System;
using System.Collections.Generic;
using MVPSampleProject.Models;
using MVPSampleProject.Presenters;

namespace MVPSampleProject.Views
{
    public partial class UserView : System.Web.UI.Page, IUserView
    {
        private UserPresenter _presenter;

        public bool IsPostBack { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _presenter = new UserPresenter(this);
                _presenter.LoadUsers();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            _presenter.AddUser(txtName.Text, txtEmail.Text);
            txtName.Text = "";
            txtEmail.Text = "";
        }

        public void DisplayUsers(List<User> users)
        {
            gvUsers.DataSource = users;
            gvUsers.DataBind();
        }

        public void ShowMessage(string message)
        {
            lblMessage.Text = message;
        }

        protected void gvUsers_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DeleteUser")
            {
                int userId = Convert.ToInt32(e.CommandArgument);
                _presenter.DeleteUser(userId);
            }
        }
    }
}

