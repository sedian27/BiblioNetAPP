using BiblioNetAPP.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BiblioNetAPP.Services
{
    public interface IRepositorieBook
    {
        void Create(BookModel bookModel);
    }
    public class RepositorieBook : IRepositorieBook
    {
        private readonly string connectionString;
        public RepositorieBook(IConfiguration configuration) {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Create(BookModel bookModel) {
            using var connection = new SqlConnection(connectionString);
            var id = connection.QuerySingle<int>($@"INSERT INTO books(BookName, Author, Price)
                                                    VALUES (@BookName, @Author, @Price);
                                                    select SCOPE_IDENTITY();",
                                                    bookModel);
            bookModel.Id = id;
        }
    }
}
