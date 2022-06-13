namespace Essentials
{
    internal class Character
    {
        int _hitPoints { get; set; }
        int _level { get; set; }
        string _characterName { get; set; }

        public Character(string name)
        {
            _characterName = name.ToLower();
            _level = 1;
            _hitPoints = 20;
        }

        public Character(string name, int level)
        {
            _characterName = name.ToLower();
            _level = level;
            _hitPoints = (_level * 10);
        }

        public string GetName() => _characterName;

        public string CapitalizeName =>
            $"{char.ToUpper(_characterName[0])}{_characterName[1..]}";

        public int GetLevel() => _level;

        public int GetHP() => _hitPoints;

        public void LevelUp()
        {
            _level++;
            _hitPoints += 10;
        }
    }
}
