﻿using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table4Commands : ITableEditorCommand
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
            string query = $"INSERT INTO [Пользователи] " +
                    $"([Код пользователя], [Фамилия], [Имя], [Отчество], [Адрес])" +
                    $"VALUES ({args[0]}, '{args[1]}', '{args[2]}', '{args[3]}', '{args[4]}')";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [Пользователи]
                    SET [Фамилия] = '{args[1]}',[Имя] = '{args[2]}',[Отчество] = '{args[3]}',[Адрес] = '{args[4]}'
                    WHERE [Код пользователя] = {args[0]}";
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [Пользователи] " +
                    $"WHERE [Код пользователя] = {args[0]}";
            controller.ExecuteCommand(query);
        }


    }
}
