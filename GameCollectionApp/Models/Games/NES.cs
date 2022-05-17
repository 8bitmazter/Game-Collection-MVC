
namespace GameCollectionApp.Models.Games
{
    public class NES : Game
    {
        public bool IsManualActive { get; set; }

        public bool IsStyrofoamPieceActive { get; set; }

        public GameCondition GameCondition { get; set; }
    }
}