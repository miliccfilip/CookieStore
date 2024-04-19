
using Shared;
using Shared.DataInterface;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;


namespace DataLayer
{
    public class ArticleRepository : IArticleRepository
    {
        public ArticleRepository()
        {

        }

        public List<Article> GetAllArticles()
        {
            List<Article> articles = new List<Article>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Articles";
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    Article article = new Article();
                    article.Id = sqlDataReader.GetInt32(0);
                    article.Name = sqlDataReader.GetString(1);
                    article.Type = sqlDataReader.GetString(2);
                    article.Price = sqlDataReader.GetDecimal(3);
                    article.Image = sqlDataReader.GetString(4);
                    article.Description = sqlDataReader.GetString(5);

                    articles.Add(article);
                }

            }
            return articles;
        }
     
        public int InsertArticle(Article a)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Articles VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", a.Name, a.Type, a.Price, a.Image, a.Description);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
                
            }
            
        }
        public int UpdateArticle(Article a)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                string query = "UPDATE Articles SET Name = @Name, Type = @Type, Price = @Price, Image = @Image, Description = @Description WHERE Id = @Id";

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Name", a.Name);
                    sqlCommand.Parameters.AddWithValue("@Type", a.Type);
                    sqlCommand.Parameters.AddWithValue("@Price", a.Price);
                    sqlCommand.Parameters.AddWithValue("@Image", a.Image);
                    sqlCommand.Parameters.AddWithValue("@Description", a.Description);
                    sqlCommand.Parameters.AddWithValue("@Id", a.Id);

                    sqlConnection.Open();
                    return sqlCommand.ExecuteNonQuery();
                }
            }
        }
        public int DeleteArticle(int Id)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM Articles WHERE Id = '{0}'", Id);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
                
        }
        public int GetNewArticleId()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT IDENT_CURRENT('Articles')";
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                var result = Convert.ToInt32(sqlDataReader[0]);
                return result;
            }
        }
    }
}
