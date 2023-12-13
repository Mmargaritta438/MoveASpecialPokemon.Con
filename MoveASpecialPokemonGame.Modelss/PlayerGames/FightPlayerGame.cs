using System;

namespace MoveASpecialPokemonGame.Modelss.PlayerGames
{
    public abstract class FightPlayerGame
    {
        public string Name { get; set; }

        /// <summary>
        /// Current party of speacial pokemon. Max of six and needs controls/restrictions
        /// for swapping new special pokemon with existing.
        /// </summary>
        public virtual IList<MonsterBeasts.FightMonster> Party { get; set; }
    }
}
