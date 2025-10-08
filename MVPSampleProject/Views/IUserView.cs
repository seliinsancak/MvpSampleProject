using System.Collections.Generic;
using MVPSampleProject.Models;

namespace MVPSampleProject.Views
{
    public interface IUserView
    {
        void DisplayUsers(List<User> users);
        void ShowMessage(string message);
    }
}

