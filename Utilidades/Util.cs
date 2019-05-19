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

        public static bool inicializarSistema() {
            if (!(Config.init()))
                return false;

            inicializarRepositorios();

            return true;
        }

        private static void inicializarRepositorios() {
            SQLServerDatabase.Instance.loadDatabase();
        }

        public static String formatValor(float valor) {
            return string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", valor);
        }

        public static string getContentBetween(string text, string tag) {
            string tagInicio = String.Format("[{0}]", tag);
            int iInicio = text.IndexOf(tagInicio) + tagInicio.Length;

            string tagFim = String.Format("[/{0}]", tag);
            int iFim = text.IndexOf(tagFim);

            if (iInicio == -1 || iFim == -1)
                return null;

            return text.Substring(iInicio, iFim - iInicio);
        }

        public static string dateTimeToSQLDateTimeFormat(DateTime dateTime) {
            return dateTime.ToString("yyyy/MM/dd HH:mm:ss");
        }

    }
}
