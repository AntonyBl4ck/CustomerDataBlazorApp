using System;

namespace CustomerDataBlazorApp.Services
{
    public class UserSessionService
    {
        public event Action OnChange;

        private string email;
        public string Email
        {
            get => email;
            set
            {
                email = value;
                NotifyStateChanged();
            }
        }

        private string firstName;
        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                NotifyStateChanged();
            }
        }

        public void ClearUserSession()
        {
            Email = null;
            FirstName = null;
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
