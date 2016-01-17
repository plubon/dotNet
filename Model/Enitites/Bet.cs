using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enitites
{
    public class Bet : BaseModel
    {
        public virtual int HomeTeamScore { get; set; }
        public virtual int AwayTeamScore { get; set; }
        public virtual Match Match { get; set; }
        public virtual User User { get; set; }
    }
}
