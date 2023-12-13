using System;

namespace MoveASpecialPokemonGame.Modelss.HoldStills
{
    public class FightHoldStill : IIdentifiablee
    {
        public int Id { get; set; }
        public BeastMonsterKind Kind { get; set; }
        public string Name { get; set; }
        public int MaxBP { get; set; }
        public int CurrentBP { get; set; }
        public string Description { get; set; }
        public int Power { get; set; }
        public int Accuracy { get; set; }

        public FightHoldStill(int id, BeastMonsterKind kind, string name, int maxBP, string description, int power, int accuracy)
        {
            Id = id;
            Kind = kind;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            MaxBP = maxBP;
            CurrentBP = maxBP;
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Power = power;
            Accuracy = accuracy;
        }
    }
}
