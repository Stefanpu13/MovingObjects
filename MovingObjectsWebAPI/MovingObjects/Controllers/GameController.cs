using MovingObjects.Data;
using MovingObjects.Models;
using MovingObjects.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovingObjects.Controllers
{
    public class GameController : ApiController
    {
        private IRepository<Game> gameRepository;

        public GameController()
        {
            this.gameRepository = new GameRepository();
        }

        // get all games

        public IEnumerable<GameModel> GetGames(int id) 
        {
            IEnumerable<GameModel> games = (
                from game in this.gameRepository.GetAll()
                select new GameModel 
                {
                    Id = game.Id,
                    Name = game.Name,
                    SaveDate = game.Date
                });

            return games;            
        }
    }
}
