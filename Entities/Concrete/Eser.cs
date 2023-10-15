using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Eser:IEntity
    {
        public int EserID { get; set; }
        public int SanatciID { get; set; }
        public string EserName { get; set; }

    }
}
