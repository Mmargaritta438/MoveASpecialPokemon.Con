using MoveASpecialPokemonGame.Modelss.MonsterBeasts;
using MoveASpecialPokemonGame.Modelss.PlayerGames;
using System.Numerics;

namespace MoveASpecialPokemon
{
    public class Programm
    {
        static void Main(string[] args)
        {
            var fightManager = new FightLibr.FightManager();

            var playergameone = new COMEPlayerGame("AI PLAYER ONE");

            var playergametwo = new COMEPlayerGame("AI PLAYER TWO");

            playergameone.Party = new List<FightMonster>
            {

            };

            System.Console.ReadLine();

        }
    }
}
