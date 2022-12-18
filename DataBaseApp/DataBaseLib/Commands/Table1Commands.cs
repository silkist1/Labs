using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table1Commands : ITableEditorCommand
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
            string query = $"INSERT INTO [Альбомы] " +
                    $"([Код альбома], [Исполнитель], [Стиль], [Код Носителя], [Магазин]) " +
                    $"VALUES ({args[0]}, '{args[1]}', '{args[2]}', {args[3]}, {args[4]})";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [Альбомы]
                    SET [Исполнитель] = '{args[1]}', [Стиль] = '{args[2]}', [Код Носителя] = {args[3]}, [Магазин] = {args[4]}
                    WHERE [Код альбома] = {args[0]}";
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [Альбомы] " +
                    $"WHERE [Код альбома] = {args[0]}";
            controller.ExecuteCommand(query);
        }


    }
}
