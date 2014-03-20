using MovingObjects.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingObjects.Repository
{
    public class GameRepository:IRepository<Game>
    {
        private MovingObjectsEntities context;

        public IEnumerable<Game> GetAll() 
        {
            return context.Games;
        }
    }
}
