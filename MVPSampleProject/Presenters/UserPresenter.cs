using MVPSampleProject.Data;
using MVPSampleProject.Models;
using MVPSampleProject.Views;
using MVPSampleProject.Watchers;

namespace MVPSampleProject.Presenters
{
    public class UserPresenter
    {
        private readonly IUserView _view;
        private readonly UserRepository _repository;
        private readonly UserWatcher _watcher;

        public UserPresenter(IUserView view)
        {
            _view = view;
            _repository = new UserRepository();
            _watcher = new UserWatcher();
            _watcher.OnUserChanged += msg => _view.ShowMessage(msg);
        }

        public void LoadUsers()
        {
            var users = _repository.GetAllUsers();
            _view.DisplayUsers(users);
        }

        public void AddUser(string name, string email)
        {
            var user = new User { Name = name, Email = email };
            _repository.AddUser(user);
            _watcher.NotifyChange($"Yeni kullanıcı eklendi: {name}");
            LoadUsers();
        }

        public void DeleteUser(int id)
        {
            _repository.DeleteUser(id);
            _watcher.NotifyChange($"Kullanıcı silindi: ID {id}");
            LoadUsers();
        }

        public void UpdateUser(int id, string name, string email)
        {
            _repository.UpdateUser(id, name, email);
            _watcher.NotifyChange($"Kullanıcı güncellendi: {name}");
            LoadUsers();
        }

        public void QueryUsers(string query)
        {
            var users = _repository.QueryUsers(query);
            _view.DisplayUsers(users);
        }
    }
}
