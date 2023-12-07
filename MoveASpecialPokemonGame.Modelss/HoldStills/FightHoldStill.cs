using System;

namespace MoveASpecialPokemonGame.Modelss.HoldStills
{
    public class FightHoldStill
    {
        public int Id { get; set; }
        public BeastMonsterKind Kind { get; set; }
        public string Name { get; set; }
        public int MaxBP { get; set; }
        public int CurrentBP { get; set; }
        public string Description { get; set; }
        public int Power { get; set; }
        public int Accuracy { get; set; }
    }
}
