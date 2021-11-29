using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPadrao {
    public class EntidadeBase<T> {
        public int CodErro { get; set; }
        public string MSGErro { get; set; }

        public EntidadeBase() {
            this.CodErro = 1;
        }
    }
}
