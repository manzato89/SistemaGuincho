using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGuincho.Repositorio;

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

        public static void inicializarSistema() {
            Config.init();

            inicializarRepositorios();
        }

        private static void inicializarRepositorios() {
            SQLiteDatabase.loadDatabase();

            OrcamentoRepositorio.Instance.init();
        }

        public static String formatValor(float valor) {
            return string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valor);
        }

    }
}
