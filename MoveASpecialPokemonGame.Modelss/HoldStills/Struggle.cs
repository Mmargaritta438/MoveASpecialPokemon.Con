using System;

namespace MoveASpecialPokemonGame.Modelss.HoldStills
{
    public class Struggle : FightHoldStill
    {
        public Struggle() : base(
            id: 1,
            kind: BeastMonsterKind.Normal,
            name: "Struggle", 
            maxBP: -1, 
            currentBP: -1,
            description: "Default move when a Fight BeastMonster is out of hold stills. Inflicts damage to the target as well as the user.",
            power: 10,
            accuracy: 100) 
        {
        }
    }
}
