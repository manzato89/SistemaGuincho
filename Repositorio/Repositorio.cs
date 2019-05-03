using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuincho.Repositorio{
    public interface Repositorio <T> {
        bool create(ref T obj);
        List<T> read();
        T read(int id);
        bool update(T obj);
        bool delete(T obj);
        void createTable(SQLiteConnection sqlLiteConnection);
    }
}