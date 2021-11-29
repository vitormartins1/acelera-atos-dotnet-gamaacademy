using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaPadrao;

namespace ExercicioCadastroDeAluno {
    internal class NE_Aluno {

        public Aluno CadastrarAluno(Aluno aluno) {
            if (aluno == null)
            {
                aluno.CodErro = -1;
                aluno.MSGErro = "Não pode cadastrar objeto Aluno sendo nulo.";
            }
            else
            {
                FabricaDePersistencia fabrica = FabricaDePersistencia.Instance();
                IPersistencia ipersistencia = fabrica.CriarPersistencia();

                aluno = ipersistencia.CadastrarEntidade<Aluno>(aluno);
            }

            return aluno;
        }

        public List<Aluno> ListarAlunos() 
        {
            List<Aluno> listaAlunos;

            FabricaDePersistencia fabrica = FabricaDePersistencia.Instance();
            IPersistencia ipersistencia = fabrica.CriarPersistencia();

            listaAlunos = ipersistencia.ListarEntidade<Aluno>();

            return listaAlunos;
        }
    }
}
