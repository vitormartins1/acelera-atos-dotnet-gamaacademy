using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPadrao {
    internal class PersistenciaArquivo : IPersistencia {
        public void AtualizarEntidade(EntidadeBase<object> eb) {
            throw new NotImplementedException();
        }

        public EntidadeBase<object> CadastrarEntidade(EntidadeBase<object> eb) {
            return new EntidadeBase<object>();
        }

        public List<EntidadeBase<object>> ListarEntidade() {
            throw new NotImplementedException();
        }

        public void RemoverEntidade(EntidadeBase<object> eb) {
            throw new NotImplementedException();
        }
    }
}
