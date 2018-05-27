using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMongoDB.Dal
{
    public interface IGameContext
    {
        IMongoCollection<Game> Games { get; }
    }
}
