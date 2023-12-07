using MoveASpecialPokemonGame.Modelss.PlayerGames;
using System;

namespace MoveASpecialPokemonGame.FightLibr
{
    public class FightManag
    {
        public FightManag ()
        {
        }
        public void StartFight(FightPlayerGame playerGame1, FightPlayerGame playerGame2) 
        {
            System.Console.WriteLine($"Starting Fight between {playerGame1.Name} and {playerGame2.Name}!");
            System.Console.ReadLine();
        }
    }
}
