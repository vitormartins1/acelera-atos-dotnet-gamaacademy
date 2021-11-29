using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPadrao {
    internal class PersistenciaBanco : IPersistencia {
        public void AtualizarEntidade(EntidadeBase eb) {
            throw new NotImplementedException();
        }

        public EntidadeBase CadastrarEntidade(EntidadeBase eb) {
            throw new NotImplementedException();
        }

        public List<EntidadeBase> ListarEntidade() {
            throw new NotImplementedException();
        }

        public void RemoverEntidade(EntidadeBase eb) {
            throw new NotImplementedException();
        }
    }
}
