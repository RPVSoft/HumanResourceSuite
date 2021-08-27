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
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CompanyRepository()
        {

        }
        /// <summary>
        /// Get Company Details
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public List<CompanyDTO> GetCompanyDetails(AppSettings settings, out Exception ex)
        {
            List<CompanyDTO> dataToReturn = new List<CompanyDTO>();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_GetCompanyDetails, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CompanyDTO data = new CompanyDTO();
                        data.id = GetIntegerValue(reader["id"]);
                        data.legal_name = GetStringValue(reader["legal_name"]);
                        data.website_url = GetStringValue(reader["website_url"]);
                        data.logo_url = GetStringValue(reader["logo_url"]);
                        data.status = GetIntegerValue(reader["status"]);
                        data.overview = GetStringValue(reader["overview"]);
                        data.industry_type = GetIntegerValue(reader["industry_type"]);
                        data.company_size = GetIntegerValue(reader["company_size"]);
                        data.founded_year = GetStringValue(reader["founded_year"]);
                        data.verified = GetBitValue(reader["verified"]);
                        data.active = GetBitValue(reader["active"]);
                        data.primary_user_email = GetStringValue(reader["primary_user_email"]);
                        data.primary_user_name = GetStringValue(reader["primary_user_name"]);
                        data.created_by = GetStringValue(reader["created_by"]);
                        data.created_date = GetDateTimeValue(reader["created_date"]);
                        data.modified_by = GetStringValue(reader["modified_by"]);
                        data.modified_date = GetDateTimeValue(reader["modified_date"]);
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
        /// Get Compant Details by Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public CompanyDTO GetCompanyDetailsById(int id, AppSettings settings, out Exception ex)
        {
            CompanyDTO data = new CompanyDTO();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_GetCompanyDetailsbyId, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@CompanyId", id);
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        data.id = GetIntegerValue(reader["id"]);
                        data.legal_name = GetStringValue(reader["legal_name"]);
                        data.website_url = GetStringValue(reader["website_url"]);
                        data.logo_url = GetStringValue(reader["logo_url"]);
                        data.status = GetIntegerValue(reader["status"]);
                        data.overview = GetStringValue(reader["overview"]);
                        data.industry_type = GetIntegerValue(reader["industry_type"]);
                        data.company_size = GetIntegerValue(reader["company_size"]);
                        data.founded_year = GetStringValue(reader["founded_year"]);
                        data.verified = GetBitValue(reader["verified"]);
                        data.active = GetBitValue(reader["active"]);
                        data.primary_user_email = GetStringValue(reader["primary_user_email"]);
                        data.primary_user_name = GetStringValue(reader["primary_user_name"]);
                        data.created_by = GetStringValue(reader["created_by"]);
                        data.created_date = GetDateTimeValue(reader["created_date"]);
                        data.modified_by = GetStringValue(reader["modified_by"]);
                        data.modified_date = GetDateTimeValue(reader["modified_date"]);
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
        /// Insert Company Details
        /// </summary>
        /// <param name="companyDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public CompanyDTO InsertCompanyDetails(CompanyDTO companyDTO, AppSettings settings, out Exception ex)
        {
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_InsertCompanyDetails, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@legal_name", companyDTO.legal_name);
                    cmd.Parameters.AddWithValue("@website_url", companyDTO.website_url);
                    cmd.Parameters.AddWithValue("@logo_url", companyDTO.logo_url);
                    cmd.Parameters.AddWithValue("@status", companyDTO.status);
                    cmd.Parameters.AddWithValue("@overview", companyDTO.overview);
                    cmd.Parameters.AddWithValue("@industry_type", companyDTO.industry_type);
                    cmd.Parameters.AddWithValue("@company_size", companyDTO.company_size);
                    cmd.Parameters.AddWithValue("@founded_year", companyDTO.founded_year);
                    cmd.Parameters.AddWithValue("@verified", companyDTO.verified);
                    cmd.Parameters.AddWithValue("@active", companyDTO.active);
                    cmd.Parameters.AddWithValue("@primary_user_email", companyDTO.primary_user_email);
                    cmd.Parameters.AddWithValue("@primary_user_name", companyDTO.primary_user_name);
                    cmd.Parameters.AddWithValue("@created_by", companyDTO.created_by);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified_by", companyDTO.modified_by);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.Now);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return companyDTO;
        }
        /// <summary>
        /// Update Company Details
        /// </summary>
        /// <param name="companyDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public CompanyDTO UpdateCompanyDetails(CompanyDTO companyDTO, AppSettings settings, out Exception ex)
        {
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_UpdateCompanyDetails, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@CompanyId", companyDTO.id);
                    cmd.Parameters.AddWithValue("@legal_name", companyDTO.legal_name);
                    cmd.Parameters.AddWithValue("@website_url", companyDTO.website_url);
                    cmd.Parameters.AddWithValue("@logo_url", companyDTO.logo_url);
                    cmd.Parameters.AddWithValue("@status", companyDTO.status);
                    cmd.Parameters.AddWithValue("@overview", companyDTO.overview);
                    cmd.Parameters.AddWithValue("@industry_type", companyDTO.industry_type);
                    cmd.Parameters.AddWithValue("@company_size", companyDTO.company_size);
                    cmd.Parameters.AddWithValue("@founded_year", companyDTO.founded_year);
                    cmd.Parameters.AddWithValue("@verified", companyDTO.verified);
                    cmd.Parameters.AddWithValue("@active", companyDTO.active);
                    cmd.Parameters.AddWithValue("@primary_user_email", companyDTO.primary_user_email);
                    cmd.Parameters.AddWithValue("@primary_user_name", companyDTO.primary_user_name);
                    cmd.Parameters.AddWithValue("@created_by", companyDTO.created_by);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified_by", companyDTO.modified_by);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.Now);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return companyDTO;
        }
        /// <summary>
        /// Remove Company Details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public string DeleteCompanyDetails(int id, AppSettings settings, out Exception ex)
        {
            string result = null;
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_DeleteCompanyDetails, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@active", false);
                    cmd.Parameters.AddWithValue("@CompanyId", id);
                    dbConn.Open();
                   int res=cmd.ExecuteNonQuery();
                    if(res!=0)
                    {
                        result = "Company Details Removed Successfully";
                    }
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return result;
        }
    }
}
