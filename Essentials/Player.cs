namespace Essentials
{
    internal class Player : Character
    {
        #region properties
        string _title;
        bool _hasCustomTitle = false;
        #endregion

        #region constructors
        public Player(string name) : base(name)
        {
            _title = SetTitle(1);
        }

        public Player(string name, int level) : base(name, level)
        {
            _title = SetTitle(level);
        }
        #endregion

        #region methods
        public string GetTitle() => _title;

        public bool HasCustomTitle() => _hasCustomTitle;

        string SetTitle(int level)
        {
            switch (level)
            {
                case 1:
                    _title = "the beginner";
                    break;
                case 2:
                    _title = "the novice";
                    break;
                case 3:
                    _title = "the apprentice";
                    break;
                case 4:
                    _title = "the master";
                    break;
                default:
                    _title = "the hero";
                    break;
            }

            return _title;
        }

        public void SetTitle(string message)
        {
            if (!String.IsNullOrEmpty(message))
            {
                _title = message;
                _hasCustomTitle = true;
                Console.WriteLine("Title updated.");
                return;
            }

            _title = SetTitle(base.GetLevel());
            Console.WriteLine("Default password set.");
        }

        #endregion
    }
}
