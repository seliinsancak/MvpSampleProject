using System;

namespace MVPSampleProject.Watchers
{
    public class UserWatcher
    {
        public event Action<string> OnUserChanged;

        public void NotifyChange(string message)
        {
            OnUserChanged?.Invoke(message);
        }
    }
}

