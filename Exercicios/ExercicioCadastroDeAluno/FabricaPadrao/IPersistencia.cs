using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPadrao {
    interface IPersistencia {
        EntidadeBase CadastrarEntidade(EntidadeBase eb);
        List<EntidadeBase> ListarEntidade();
        void RemoverEntidade(EntidadeBase eb);
        void AtualizarEntidade(EntidadeBase eb);
    }
}
