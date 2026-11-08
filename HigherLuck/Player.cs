namespace HigherLuck
{
    public class Player
    {
        public string Name { get; set; }
        public string AvatarFile { get; set; }
        public int Point { get; set; }

        public Player(string name, string avatarFile)
        {
            Name = name;
            AvatarFile = avatarFile;
            Point = 0;
        }
    }
}