using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPadrao {
    public interface IPersistencia {
        T CadastrarEntidade<T>(T eb) where T : IGenerico;
        List<T> ListarEntidade<T>() where T : IGenerico;
        void RemoverEntidade<T>(T eb) where T : IGenerico;
        void AtualizarEntidade<T>(T eb) where T : IGenerico;
    }
}
