using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace easj_sem3_rest
{
    public class Service1 : IService1
    {
        private const string db = "Server=tcp:easj-sem3.database.windows.net,1433;Initial Catalog=easj-sem3;Persist Security Info=False;User ID=hjeppesen;Password=strongPassword512;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        /// <summary>
        /// READ SINGLE RECORD EXAMPLE!
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Object</returns>
        //public Object read(string id)
        //{
        //    int objId = int.Parse(id);
        //    const string sql = "SELECT * FROM table WHERE id=@id";

        //    using (SqlConnection conn = new SqlConnection(db))
        //    using (SqlCommand query = new SqlCommand(sql, conn))
        //    {
        //        query.Parameters.AddWithValue("@id", objId);
        //        conn.Open();
        //        using (SqlDataReader reader = query.ExecuteReader())
        //        {
        //            int id = reader.GetInt32(0);
        //            string value = reader.GetString(1);

        //            Object result = new Object
        //            {
        //                id = id,
        //                value = value
        //            };

        //            conn.Close();
        //            reader.Close();
        //            return result;
        //        }
        //    }
        //}

        /// <summary>
        /// CREATE EXAMPLE!
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>int rowsAffected</returns>
        //public int Create(object obj)
        //{
        //    const string sql = "INSERT INTO table (row) VALUES (@value)";
        //    using (SqlConnection conn = new SqlConnection(db))
        //    using (SqlCommand insert = new SqlCommand(sql, conn))
        //    {

        //        insert.Parameters.AddWithValue("@value", obj.value);

        //        conn.Open();
        //        int rowsAffected = insert.ExecuteNonQuery();

        //        conn.Close();
        //        return rowsAffected;
        //    }
        //}

        /// <summary>
        /// RECEIVE ALL RECORDS EXAMPLE!
        /// </summary>
        /// <returns>Objects</returns>
        //public IList<object> readAll()
        //{
        //    IList<Object> result = new List<Object>();
        //    const string sql = "SELECT * FROM table";

        //    using (SqlConnection conn = new SqlConnection(db))
        //    using (SqlCommand query = new SqlCommand(sql, conn))
        //    {
        //        conn.Open();
        //        using (SqlDataReader reader = query.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                int id = reader.GetInt32(0);
        //                string value = reader.GetString(1);

        //                result.Add(new Object
        //                {
        //                    id = id,
        //                    value = value
        //                });
        //            }

        //            conn.Close();
        //            reader.Close();
        //            return result;
        //        }
        //    }
        //}

        /// <summary>
        /// UPDATE RECORD EXAMPLE
        /// </summary>
        /// <param name="id">id of the object</param>
        /// <param name="obj"></param>
        /// <returns>int rowsAffected</returns>
        //public int Update(string id, object obj)
        //{
        //    int objId = int.Parse(id);
        //    const string sql = "UPDATE table SET row=@value WHERE id=@id";

        //    using (SqlConnection conn = new SqlConnection(db))
        //    using (SqlCommand insert = new SqlCommand(sql, conn))
        //    {

        //        insert.Parameters.AddWithValue("@id", objId);
        //        insert.Parameters.AddWithValue("@value", obj.value);

        //        conn.Open();
        //        int rowsAffected = insert.ExecuteNonQuery();

        //        conn.Close();
        //        return rowsAffected;
        //    }
        //}

        /// <summary>
        /// DELETE EXAMPLE!
        /// </summary>
        /// <param name="id">the id of the record</param>
        /// <returns>int rowsAffected</returns>
        //public int Delete(string id)
        //{
        //    int objId = int.Parse(id);
        //    const string sql = "DELETE FROM table WHERE id=@id";

        //    using (SqlConnection conn = new SqlConnection(db))
        //    using (SqlCommand insert = new SqlCommand(sql, conn))
        //    {

        //        insert.Parameters.AddWithValue("@id", objId);

        //        conn.Open();
        //        int rowsAffected = insert.ExecuteNonQuery();

        //        conn.Close();
        //        return rowsAffected;
        //    }
        //}
    }
}
