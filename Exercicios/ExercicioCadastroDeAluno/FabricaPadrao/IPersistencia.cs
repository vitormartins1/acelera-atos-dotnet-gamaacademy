using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPadrao {
    public interface IPersistencia {
        EntidadeBase<object> CadastrarEntidade(EntidadeBase<object> eb);
        List<EntidadeBase<object>> ListarEntidade();
        void RemoverEntidade(EntidadeBase<object> eb);
        void AtualizarEntidade(EntidadeBase<object> eb);
    }
}
