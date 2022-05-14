
using GameCollectionApp.Models.RetroAchievements;

namespace GameCollectionApp.Models.Games
{
    public class Game
    {
        public string Title { get; set; }

        public string System { get; set; }

        public string ReleaseDate { get; set; }

        public float Price { get; set; }

        public bool IsCompleteInBox { get; set; }

        public RetroAchievementProgress RetroAchievementProgress { get; set; }
    }
}