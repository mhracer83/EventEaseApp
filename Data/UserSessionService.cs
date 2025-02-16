
namespace EventEaseApp.Data
{
    public class UserSessionService
    {
        private string userName;

        public string UserName
        {
            get => userName;
            set
            {
                userName = value;
                SessionStartTime = DateTime.Now;
            }
        }

        public DateTime SessionStartTime { get; private set; }

        public TimeSpan SessionDuration => DateTime.Now - SessionStartTime;

        public bool IsSessionActive => !string.IsNullOrEmpty(UserName);
    }
}
