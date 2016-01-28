using Model.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BetRepository : AbstractRepository<Bet>
    {
        public bool ContainsBet(int mId, int uId)
        {
           OpenSession();
           return QueryOverModel().Where(x => x.User.Id == uId && x.Match.Id == mId).Take(1).RowCount()>0;  
        }

        public Bet GetByMatchAndUserIds(int mId, int uId)
        {
            OpenSession();
            return QueryOverModel().Where(x => x.User.Id == uId && x.Match.Id == mId).Take(1).SingleOrDefault();
        }
    }
}
