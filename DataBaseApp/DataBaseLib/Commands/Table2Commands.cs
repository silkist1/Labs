using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table2Commands : ITableEditorCommand
    {
        // ЕСЛИ нужна другая БД, просто меняем AccessDataBaseController
        // на нужную, например SQLiteDataBaseController
        // в следующей строке
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Select(string[] args)
        {

        }

        public void Insert(string[] args)
        {            
            string query = $"INSERT INTO [Выдача-возврат] " +
                    $"([Код], [Код альбома], [Код пользователя], [Возвращено]) " +
                    $"VALUES ({args[0]}, '{args[1]}','{args[2]}','{args[3]}')";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [Выдача-возврат]
                    SET [Код альбома] = '{args[1]}',[Код пользователя] = '{args[2]}',[Возвращено] = '{args[3]}'
                    WHERE [Код] = {args[0]}";
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [Выдача-возврат] " +
                    $"WHERE [Код] = {args[0]}";
            controller.ExecuteCommand(query);
        }


    }
}
