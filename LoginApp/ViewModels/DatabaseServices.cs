
using LoginApp.Models;
using SQLite;

namespace LoginApp
{
    public class DatabaseServices : BindableObject
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseServices()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UserDatabase.db3");
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();
        }

        public Task<int> AddUserAsync(User user)
        {
            return _database.InsertAsync(user);
        }

        public Task<User> GetUserByEmailAsync(string email)
        {
            return _database.Table<User>().Where(u => u.Email == email).FirstOrDefaultAsync();
        }

        public Task<User> LoginUserAsync(string email, string password)
        {
            return _database.Table<User>()
                            .Where(u => u.Email == email && u.Password == password)
                            .FirstOrDefaultAsync();
        }
    }
}

