using GameCollectionApp.Models.Games;
using GameCollectionApp.Models.RetroAchievements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameCollectionApp.Orchestrator
{
    public class GetGameCollectionOrchestrator : IGetGameCollectionOrchestrator
    {
        public Game GetGame()
        {
            Game game = new Game();
            game.Title = "Megaman";
            game.System = "NES";
            game.RetroAchievementProgress = RetroAchievementProgress.InProgress;

            return game;
        }
    }
}