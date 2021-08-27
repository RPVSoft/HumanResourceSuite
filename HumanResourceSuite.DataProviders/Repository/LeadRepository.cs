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
    public class LeadRepository : BaseRepository, ILeadRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public LeadRepository()
        {

        }
        /// <summary>
        /// Get All Leads
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public List<LeadsDTO> GetAllLeads(AppSettings settings, out Exception ex)
        {
            List<LeadsDTO> dataToReturn = new List<LeadsDTO>();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_Leads_Data, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@ActionType", "Fetchall");
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LeadsDTO data = new LeadsDTO();
                        data.Id = GetIntegerValue(reader["Id"]);
                        data.First_name = GetStringValue(reader["first_name"]);
                        data.Last_name = GetStringValue(reader["last_name"]);
                        data.Mobile_no = GetStringValue(reader["mobile_no"]);
                        data.Email_address = GetStringValue(reader["email_address"]);
                        data.Company = GetStringValue(reader["company"]);
                        data.Industry_type = GetIntegerValue(reader["industry_type"]);
                        data.Created_by = GetStringValue(reader["created_by"]);
                        data.Created_date = GetDateTimeValue(reader["created_date"]);
                        data.Modified_by = GetStringValue(reader["modified_by"]);
                        data.Modified_date = GetDateTimeValue(reader["modified_date"]);
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
        /// <summary>
        /// Get Leads by Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public LeadsDTO GetLeadsById(int id, AppSettings settings, out Exception ex)
        {
            LeadsDTO data = new LeadsDTO();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_Leads_Data, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@ActionType", "FetchbyId");
                    cmd.Parameters.AddWithValue("@LeadId", id);
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        data.Id = GetIntegerValue(reader["Id"]);
                        data.First_name = GetStringValue(reader["first_name"]);
                        data.Last_name = GetStringValue(reader["last_name"]);
                        data.Mobile_no = GetStringValue(reader["mobile_no"]);
                        data.Email_address = GetStringValue(reader["email_address"]);
                        data.Company = GetStringValue(reader["company"]);
                        data.Industry_type = GetIntegerValue(reader["industry_type"]);
                        data.Created_by = GetStringValue(reader["created_by"]);
                        data.Created_date = GetDateTimeValue(reader["created_date"]);
                        data.Modified_by = GetStringValue(reader["modified_by"]);
                        data.Modified_date = GetDateTimeValue(reader["modified_date"]);
                    }
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return data;
        }

        /// <summary>
        /// Insert Leads
        /// </summary>
        /// <param name="leadsDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public LeadsDTO CreateLeads(LeadsDTO leads, AppSettings settings, out Exception ex)
        {
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_Leads_Data, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@ActionType", "Insert");
                    cmd.Parameters.AddWithValue("@FirstName", leads.First_name);
                    cmd.Parameters.AddWithValue("@LastName", leads.Last_name);
                    cmd.Parameters.AddWithValue("@MobileNo", leads.Mobile_no);
                    cmd.Parameters.AddWithValue("@EmailAddress", leads.Email_address);
                    cmd.Parameters.AddWithValue("@Company", leads.Company);
                    cmd.Parameters.AddWithValue("@IndustryType", leads.Industry_type);
                    cmd.Parameters.AddWithValue("@CreatedBy", leads.Created_by);
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@UpdatedBy", leads.Modified_by);
                    cmd.Parameters.AddWithValue("@UpdatedDate", DateTime.Now);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return leads;
        }      
    }
}
