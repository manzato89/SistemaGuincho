using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaGuincho.Repositorio{
    public interface Repositorio <T> {
        bool create(ref T obj);
        List<T> read();
        T read(int id);
        bool update(T obj);
        bool delete(T obj);
        void createTable(SqlConnection sqlServerConnection);
    }
}