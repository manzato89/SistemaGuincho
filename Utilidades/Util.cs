using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Utilidades {
    public static class Util {
        public enum WindowMode {
            ModoDeEdicao,
            ModoDeInsercao,
            ModoNormal,
            ModoCriacaoForm
        }

        public enum TipoConsulta {
            Selecao,
            Edicao
        }

        public static void inicializarRepositorios() {
            Repositorio.ClienteRepositorio.init();
            Repositorio.VeiculoRepositorio.init();
            Repositorio.ServicoRepositorio.init();
            Repositorio.UnidadeRepositorio.init();
        }

    }
}
