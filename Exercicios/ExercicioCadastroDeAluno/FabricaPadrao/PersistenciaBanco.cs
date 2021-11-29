using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPadrao {
    internal class PersistenciaBanco : IPersistencia {
        public void AtualizarEntidade<T>(T eb) where T : IGenerico {
            throw new NotImplementedException();
        }

        public T CadastrarEntidade<T>(T eb) where T : IGenerico {
            throw new NotImplementedException();
        }

        public List<T> ListarEntidade<T>() where T : IGenerico {
            throw new NotImplementedException();
        }

        public void RemoverEntidade<T>(T eb) where T : IGenerico {
            throw new NotImplementedException();
        }
    }
}
