using System;
using MoveASpecialPokemonGame.Modelss.HoldStills;
using MoveASpecialPokemonGame.Modelss.MonsterBeasts;

namespace MoveAsSpecialPokemon.Repositories
{
    public class FightMonsterRepository : IRepositories<FightMonster>
    {
        private List<FightMonster> _monsterBeasts = new List<FightMonster>()
        {
            new FightMonster(1, "Bulbasaur", MoveASpecialPokemonGame.Modelss.BeastMonsterKind.Grass, 45, 49, 49, 45, null),
            new FightMonster(4, "Charmader", MoveASpecialPokemonGame.Modelss.BeastMonsterKind.Fire, 39, 52, 43, 65, null),
            new FightMonster(7, "Squirtle", MoveASpecialPokemonGame.Modelss.BeastMonsterKind.Fire, 39, 52, 43, 65, null),
        };

        public FightMonster Get(int id)
        {

        }

        public IList<FightMonster> GetAll()
        {

        }

        public int Save(FightMonster item, bool allowUpdate = true)
        {

        }
    }
}

