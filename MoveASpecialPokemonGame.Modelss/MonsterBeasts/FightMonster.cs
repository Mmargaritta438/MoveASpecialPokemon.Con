using MoveASpecialPokemonGame.Modelss.HoldStills;
using System;

namespace MoveASpecialPokemonGame.Modelss.MonsterBeasts
{
    public class FightMonster : IIdentifiablee
    {
        /// <summary>
        /// SpecialPukemon Number
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Experience Level
        /// </summary>
        public int Level { get; set; }  

        /// <summary>
        /// SpecialPokemon Kind
        /// </summary>
        public BeastMonsterKind Kind { get; set; }

        /// <summary>
        /// FightMonster's Name
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
     
        public FightMonster(int id, string name, BeastMonsterKind kind, int hP, int attack, int defence, int speed, IList<HoldStills.FightHoldStill> holdStillList)
        {
            Id = id;
            Kind = kind;
            Name = name ?? throw new ArgumentNullException(nameof(Name));   
            HP = hP;
            Attack = attack;
            Defence = defence;
            Speed = speed;
            if (holdStillList == null || holdStillList.Count == 0)
                holdStillList = new List<FightHoldStill> { new Struggle() };

            HoldStillList = holdStillList;
        }

    }
}

