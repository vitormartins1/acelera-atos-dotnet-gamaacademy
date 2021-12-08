using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace FabricaPadrao {
    internal class PersistenciaArquivo : IPersistencia {
        public void AtualizarEntidade<T>(T eb) where T : IGenerico {
            throw new NotImplementedException();
        }

        public T CadastrarEntidade<T>(T eb) where T : IGenerico {
            StreamWriter sw = new StreamWriter("C:\\NOVO\\aluno.txt", true);

            var assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetType(eb.GetType().ToString()).FullName;
            GetType(type) objeto = (IGenerico)Activator.CreateInstanceFrom(assembly.Location, type).Unwrap();

            sw.WriteLine($"{objeto.Nome};{eb.Cpf};{eb.Telefone};{(int)eb.Situacao};{eb.DataRegistro}");

            sw.Close();
            return eb;
        }

        public List<T> ListarEntidade<T>() where T : IGenerico {
            List<T> listaEntidades = new List<T>();

            return listaEntidades;
        }

        public void RemoverEntidade<T>(T eb) where T : IGenerico {
            throw new NotImplementedException();
        }
    }
}
