using ProfileBook.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProfileBook.ViewModels
{
    class Repository
    {
        SQLiteConnection database;
        public Repository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<DataProfile>();
        }
        public IEnumerable<DataProfile> GetItems()
        {
            return database.Table<DataProfile>().ToList();
        }
        public DataProfile GetItem(int id)
        {
            return database.Get<DataProfile>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<DataProfile>(id);
        }
        public int SaveItem(DataProfile item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
