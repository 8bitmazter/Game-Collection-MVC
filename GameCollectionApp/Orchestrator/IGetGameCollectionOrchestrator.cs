using GameCollectionApp.Models.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameCollectionApp.Orchestrator
{
    public interface IGetGameCollectionOrchestrator
    {
        Game GetGame();
    }
}