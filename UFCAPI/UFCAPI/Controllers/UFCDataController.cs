using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace UFCAPI.Controllers
{
    [ApiController]
    public class UFCDataController : ControllerBase
    {
        [HttpGet]
        [Route("[controller]/fightcards")]
        public string GetFightCards()
        {

            string sqlStatement = "select * from fightcard";

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-STHQHET\\SQLEXPRESS";
            builder.InitialCatalog = "UFCData";
            builder.IntegratedSecurity = true;

            DataTable results = new DataTable();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlStatement, connection))
                {
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        results.Load(dr);
                    }
                }
            }

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in results.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in results.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return JsonConvert.SerializeObject(rows);

        }

        [HttpGet]
        [Route("[controller]/fightcards/{id}")]
        public string GetFightCards(string id)
        {
            string[] ids = id.Split(",");


            string sqlStatement = "select * from fightcard where id in (";

            for (int i = 0; i < ids.Length; i++)
            {
                if (!Regex.IsMatch(ids[i].ToString(), @"^\d+$"))
                {
                    return "Invalid input";
                }

                if (i != 0)
                {
                    sqlStatement += ",";
                }
                sqlStatement += ids[i];

            }

            sqlStatement += ")";

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-STHQHET\\SQLEXPRESS";
            builder.InitialCatalog = "UFCData";
            builder.IntegratedSecurity = true;


            DataTable results = new DataTable();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlStatement, connection))
                {
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        results.Load(dr);
                    }
                }
            }

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in results.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in results.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return JsonConvert.SerializeObject(rows);
        }

        [HttpGet]
        [Route("[controller]/fightcards/fights/{id}")]
        public string GetFightsInFightCard(string id)
        {
            string[] ids = id.Split(",");


            string sqlStatement = "select * from fight where fightcardid =" + ids[0];
           
            if(!Regex.IsMatch(ids[0].ToString(), @"^\d+$"))
            {
                return "Invalid input";
            }

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-STHQHET\\SQLEXPRESS";
            builder.InitialCatalog = "UFCData";
            builder.IntegratedSecurity = true;


            DataTable results = new DataTable();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlStatement, connection))
                {
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        results.Load(dr);
                    }
                }
            }

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in results.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in results.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return JsonConvert.SerializeObject(rows);
        }

        [HttpGet]
        [Route("[controller]/fights")]
        public string GetFights()
        {

            string sqlStatement = "select * from fight";

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-STHQHET\\SQLEXPRESS";
            builder.InitialCatalog = "UFCData";
            builder.IntegratedSecurity = true;

            DataTable results = new DataTable();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlStatement, connection))
                {
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        results.Load(dr);
                    }
                }
            }

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in results.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in results.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return JsonConvert.SerializeObject(rows);

        }

        [HttpGet]
        [Route("[controller]/fights/{id}")]
        public string GetFight(string id)
        {
            string[] ids = id.Split(",");


            string sqlStatement = "select * from fight where id in (";

            for (int i = 0; i < ids.Length; i++)
            {
                if (!Regex.IsMatch(ids[i].ToString(), @"^\d+$"))
                {
                    return "Invalid input";
                }

                if (i != 0)
                {
                    sqlStatement += ",";
                }
                sqlStatement += ids[i];

            }

            sqlStatement += ")";

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-STHQHET\\SQLEXPRESS";
            builder.InitialCatalog = "UFCData";
            builder.IntegratedSecurity = true;


            DataTable results = new DataTable();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlStatement, connection))
                {
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        results.Load(dr);
                    }
                }
            }

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in results.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in results.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }

            return JsonConvert.SerializeObject(rows);
        }

        [HttpGet]
        [Route("[controller]/fightstats/{id}")]
        public string GetFightStats(string id)
        {
            string[] ids = id.Split(",");


            string sqlStatement = "select distinct fightername, knockdown, landersigstrikes, totalsigstrikes, takedowns, takedownattempts, submissionattempt, control, landedStrikes, totalStrikes from FightStats where fightid =" + ids[0];

            if (!Regex.IsMatch(ids[0].ToString(), @"^\d+$"))
            {
                return "Invalid input";
            }

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "DESKTOP-STHQHET\\SQLEXPRESS";
            builder.InitialCatalog = "UFCData";
            builder.IntegratedSecurity = true;


            DataTable results = new DataTable();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlStatement, connection))
                {
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        results.Load(dr);
                    }
                }
            }

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in results.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in results.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }

            return JsonConvert.SerializeObject(rows);
        }

    }
}
