using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPadrao 
{
    public class FabricaDePersistencia 
    {
        const int TipoDePersistencia = 0;
        static FabricaDePersistencia instance = null;

        private FabricaDePersistencia() { }

        public static FabricaDePersistencia Instance()
        {
            if (instance == null)
            {
	            instance = new FabricaDePersistencia();
            }
            return instance;
        }
        
        public IPersistencia CriarPersistencia() 
        {
            IPersistencia persistencia = null;
            if (TipoDePersistencia == 0)
            {
                persistencia = new PersistenciaArquivo();
            }
            else if (TipoDePersistencia == 1)
            {
                persistencia = new PersistenciaBanco();
            }
            return persistencia;
        }
    }
}
