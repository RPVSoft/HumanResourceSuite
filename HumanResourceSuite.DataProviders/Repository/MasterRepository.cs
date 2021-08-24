using HumanResourceSuite.Common.Framework;
using HumanResourceSuite.DataObjects;
using HumanResourceSuite.DataProviders.Configurations;
using HumanResourceSuite.DataProviders.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HumanResourceSuite.DataProviders.Repository
{
    public class MasterRepository : BaseRepository, IMasterRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MasterRepository()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public List<MasterDTO> GetAll(AppSettings settings, out Exception ex)
        {
            List<MasterDTO> dataToReturn = new List<MasterDTO>();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_GETMASTERS, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        MasterDTO data = new MasterDTO();
                        data.Id = GetIntegerValue(reader["Id"]);
                        data.MasterTypeId = GetIntegerValue(reader["MasterTypeId"]);
                        data.Text = GetStringValue(reader["Text"]);
                        dataToReturn.Add(data);
                    }
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return dataToReturn;
        }


        public List<MasterDTO> Get(int id, AppSettings settings, out Exception ex)
        {
            List<MasterDTO> dataToReturn = new List<MasterDTO>();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {

                    SqlCommand cmd = new SqlCommand(StoreProc.SP_GETMASTERS_BY_TYPE_ID, dbConn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@typeid", id);
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        MasterDTO data = new MasterDTO();
                        data.Id = GetIntegerValue(reader["Id"]);
                        data.MasterTypeId = GetIntegerValue(reader["MasterTypeId"]);
                        data.Text = GetStringValue(reader["Text"]);
                        dataToReturn.Add(data);
                    }
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return dataToReturn;
        }
    }
}
