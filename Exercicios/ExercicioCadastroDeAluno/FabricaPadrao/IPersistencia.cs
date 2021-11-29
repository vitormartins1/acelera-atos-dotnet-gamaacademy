using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPadrao {
    public interface IPersistencia {
        T CadastrarEntidade<T>(T eb) where T : class;
        List<T> ListarEntidade<T>() where T : class;
        void RemoverEntidade<T>(T eb) where T : class;
        void AtualizarEntidade<T>(T eb) where T : class;
    }
}
