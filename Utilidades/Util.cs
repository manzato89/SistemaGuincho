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

        public static string getMes(int mes) {
            switch (mes) {
                case 1: return "Janeiro";
                case 2: return "Fevereiro";
                case 3: return "Março";
                case 4: return "Abril";
                case 5: return "Maio";
                case 6: return "Junho";
                case 7: return "Julho";
                case 8: return "Agosto";
                case 9: return "Setembro";
                case 10: return "Outubro";
                case 11: return "Novembro";
                case 12: return "Dezembro";
                default: return "";
            }
        }

    }
}
