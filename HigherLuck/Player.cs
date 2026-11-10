namespace HigherLuck
{
    public class Player
    {
        public string Name;
        public string AvatarFile;
        public int Point;

        public Player(string name, string avatarFile)
        {
            Name = name;
            AvatarFile = avatarFile;
            Point = 0;
        }
    }
}
