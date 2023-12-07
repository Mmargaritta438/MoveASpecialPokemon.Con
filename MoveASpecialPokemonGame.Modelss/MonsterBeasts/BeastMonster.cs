using System;

namespace MoveASpecialPokemonGame.Modelss.MonsterBeasts
{
    public abstract class BeastMonster
    {
        /// <summary>
        /// SpecialPukemon Number
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// SpecialPokemon Kind
        /// </summary>
        public BeastMonsterKind Kind { get; set; }

        /// <summary>
        /// BeastMonster's Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Health
        /// </summary>
        public int HP { get; set; }

        /// <summary>
        /// Base Attack Stat {Physical and Speatial}
        /// </summary>
        public int Attack { get; set; }

        /// <summary>
        /// Base Defense Stat {Physical and Speatial}
        /// </summary>
        public int Defence { get; set; }

        /// <summary>
        /// Base Speed Stat {used to determine round order}
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// Up to four hold still that beast monster knows
        /// </summary>
        ///-- TODO: Add controls/restrictions for learning new  hold stills.
        ///-- NOTE: When learning a STH hold still, it actually need to replace
        ///-- one of the existing four hold stills.
        public virtual IList<HoldStills.FightHoldStill> HoldStillList { get; set; }
    }
}
