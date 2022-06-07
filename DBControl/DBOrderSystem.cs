using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBControl
{
    public class DBOrderSystem
    {
        DBControl dbc = new DBControl();

        #region ManageArticle
        public DataTable GetAllArticleNumbers()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT asstArticleNumber FROM Assortiment;";

            try
            {
                dt = dbc.GetDataTable(sql);
            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }

        public DataTable GetArticle(string category)
        {
            DataTable dt = new DataTable();
            string sql = $"SELECT * FROM Assortiment ";

            if (category != "-- Default --")
            {
                sql += $"WHERE asstCategory = '{category}' ";
            }

            try
            {
                dt = dbc.GetDataTable(sql);
            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }

        public bool AddArticle(string artNr, string artDesc, string category)
        {
            string sql = $"INSERT INTO Assortiment (asstArticleNumber, asstArticleDescription, asstCategory) " +
                         $"VALUES ( '{artNr}', '{artDesc}', '{category}' );";

            try
            {
                if (dbc.UpdateDatabase(sql))
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateArticle(string artNrOld, string artNrNew, string artDesc, string category, string price)
        {
            string sql = $"UPDATE Assortiment " +
                         $"SET asstArticleNumber = '{artNrNew}', asstArticleDescription = '{artDesc}', asstCategory = '{category}', asstPrice = {Convert.ToDouble(price)}" +
                         $"WHERE asstArticleNumber = '{artNrOld}';";

            try
            {
                if (dbc.UpdateDatabase(sql)) 
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateArticle(string artNr, string price)
        {
            string sql = $"UPDATE Assortiment " +
                         $"SET asstPrice = '{Convert.ToDouble(price)}' " +
                         $"WHERE asstArticleNumber = '{artNr}';";

            try
            {
                if (dbc.UpdateDatabase(sql))
                {
                    return true;
                }
                else { return false; } 
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion


        #region Category
        public DataTable GetAllCategories()
        {
            DataTable dt = new DataTable();
            string sql = $"SELECT spCategory " +
                         $"FROM SystemParameters;";

            try
            {
                dt = dbc.GetDataTable(sql);
            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }

        public bool AddCategory(string category)
        {
            string sql = $"INSERT INTO SystemParameters (spCategory) " +
                         $"VALUES ( '{category}' );";

            try
            {
                if (dbc.UpdateDatabase(sql))
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
