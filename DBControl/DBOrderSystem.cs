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

        public DataTable GetArticle(string category, string subCategory)
        {
            DataTable dt = new DataTable();
            string sql = $"SELECT * FROM Assortiment ";

            if (category != "-- Default --")
            {
                sql += $"WHERE asstCategory = '{category}' ";

                if (subCategory != "")
                {
                    if (subCategory != "-- Default --")
                    {
                        sql += $"AND asstSubCategory = '{subCategory}'";
                    }
                }
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

        public bool AddArticle(string artNr, string artDesc, string category, string subCategory)
        {
            string sql = $"INSERT INTO Assortiment (asstArticleNumber, asstArticleDescription, asstCategory, asstSubCategory) " +
                         $"VALUES ( '{artNr}', '{artDesc}', '{category}', '{subCategory}' );";

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

        public bool UpdateArticle(string artNrOld, string artNrNew, string artDesc, string category, string subCategory, string price)
        {
            if (category == "-- Default --")
            {
                category = "";
            }

            string sql = $"UPDATE Assortiment " +
                         $"SET asstArticleNumber = '{artNrNew}', asstArticleDescription = '{artDesc}', asstCategory = '{category}', asstSubCategory = '{subCategory}', asstPrice = '{Convert.ToDouble(price)}'" +
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

        public bool DeleteArticle(string artNr)
        {
            string sql = $"DELETE " +
                         $"FROM Assortiment " +
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

        #region ManageOrder
        public DataTable GetOrders(string orderNr, string category)
        {
            DataTable dt = new DataTable();
            string sql = $"SELECT * FROM Orders ";

            if (category != "-- Default --")
            {
                sql += $"WHERE odCategory = '{category}' ";

                if (orderNr != "")
                {
                    sql += $"AND odOrderNumber = '{orderNr}'";
                }
            }
            else 
            {
                if (orderNr != "")
                {
                    sql += $" WHERE odOrderNumber = '{orderNr}'";
                }
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

        public DataTable GetOrders(string orderNr, string category, string status)
        {
            DataTable dt = new DataTable();
            string sql = $"SELECT * FROM Orders " +
                         $"WHERE odStatus = {status} ";

            if (category != "-- Default --")
            {
                sql += $"AND odCategory = '{category}' ";
            }
            if (orderNr != "")
            {
                sql += $"AND odOrderNumber = '{orderNr}'";
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
        #endregion

        #region Category
        public DataTable GetAllCategories()
        {
            DataTable dt = new DataTable();
            string sql = $"SELECT * FROM SystemParameters";

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

        public DataTable GetCategories()
        {
            DataTable dt = new DataTable();
            string sql = $"SELECT DISTINCT (spCategory) " +
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

        public DataTable GetSubCategories(string cat)
        {
            DataTable dt = new DataTable();
            string sql = $"SELECT spSubCategory " +
                         $"FROM SystemParameters " +
                         $"WHERE spCategory = '{cat}' " +
                         $"OR  spCategory = '-- Default --'; ";

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

        public bool AddCategory(string category, string subCategory)
        {
            string sql = $"INSERT INTO SystemParameters (spCategory, spSubCategory) " +
                         $"VALUES ( '{category}', '{subCategory}' );";

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
