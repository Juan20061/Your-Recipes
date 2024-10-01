using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginApp.Models;

namespace LoginApp.Models
{
    public  class LocalDbService
    {
        private const string DB_NAME = "demo_local_db.db3";
        private readonly SQLiteAsyncConnection _connection;


        public LocalDbService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<Recetas>().Wait();
        }

        //metodo para alistar los registros de nuestra tabla
        public async Task<List<Recetas>> GetRecetasAsync()
        {
            return await _connection.Table<Recetas>().ToListAsync();
        }

        public async Task<Recetas> GetById(int id)
        {
            return await _connection.Table<Recetas>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        //Metodo para crear registros
        public  async Task Create(Recetas clientes)
        {
            await _connection.InsertAsync(clientes);
        }

        //Metodo para actualizar 
        public async Task Update(Recetas clientes)
        {
            await _connection.UpdateAsync(clientes);
        }

        //Metodo para eliminar
        public async Task Delete(Recetas clientes)
        {
            await _connection.DeleteAsync(clientes);
        }

     
    }
    
}
