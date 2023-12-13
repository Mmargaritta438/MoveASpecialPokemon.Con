using MoveASpecialPokemonGame.Modelss.HoldStills;
using System;

namespace MoveAsSpecialPokemon.Repositories
{
    public class FightHoldStillRepository : IRepositories<FightHoldStill>
    {
        private List<FightHoldStill> _holdStills = new List<FightHoldStill>
        {
            new Struggle(),
            new FightHoldStill(2, "Tackle", Modelss.BeastMonsterKind.Normal, 45, "A physical attack in which the user charges, full body, into the foe.", 40, 100),
            new FightHoldStill(3, "Growl", Modelss.BeastMonsterKind.Normal, 40, "The user growls in an endearing way, making the foe less wary. The target's Attack stat is lowered.", 0, 100)
        };
        public FightHoldStill Get(int id)
        {
            return _holdStills.Where(h => h.Id == id).FirstOrDefault();
        }

        public IList<FightHoldStill> GetAll()
        {
            return _holdStills;
        }

        public int Save(FightHoldStill item, bool allowUpdate = true)
        {
            var existing = Get(item.Id);
            if (item.Id > 0 && existing != null)
            {
                //we have a match, item is existing.
                if (allowUpdate)
                {
                    // update existing item.
                    _holdStills[_holdStills.IndexOf(item)] = item;
                    return item.Id;
                }
                return -1;
            }            
            //add new item
            item.Id = _holdStills.OrderBy(h => h.Id).Last().Id + 1;
            _holdStills.Add(item);
            return item.Id;
        }
    }
}
