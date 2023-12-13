using MoveASpecialPokemonGame.Modelss;
using System;

namespace MoveAsSpecialPokemon.Repositories
{
    public interface IRepositories<T> where T : class, IIdentifiablee
    {
        T? Get(int id);

        IList<T> GetAll();  

        /// <summary>
        /// Save an item by Create or Update if allowUpdate is true. Otherwise
        /// it will return an error if the item already exists.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="allowUpdate"></param>
        /// <returns></returns>
        int Save(T item, bool allowUpdate =  true); 
    }
}
