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
                        data.Id = GetIntegerValue(reader["id"]);
                        data.Legal_Name = GetStringValue(reader["legal_name"]);
                        data.Website_Url = GetStringValue(reader["website_url"]);
                        data.Logo_Url = GetStringValue(reader["logo_url"]);
                        data.Status = GetIntegerValue(reader["status"]);
                        data.Overview = GetStringValue(reader["overview"]);
                        data.Industry_Type = GetIntegerValue(reader["industry_type"]);
                        data.Company_Size = GetIntegerValue(reader["company_size"]);
                        data.Founded_Year = GetStringValue(reader["founded_year"]);
                        data.Verified = GetBitValue(reader["verified"]);
                        data.Active = GetBitValue(reader["active"]);
                        data.Primary_User_Email = GetStringValue(reader["primary_user_email"]);
                        data.Primary_User_Name = GetStringValue(reader["primary_user_name"]);
                        data.Created_By = GetStringValue(reader["created_by"]);
                        data.Created_Date = GetDateTimeValue(reader["created_date"]);
                        data.Modified_By = GetStringValue(reader["modified_by"]);
                        data.Modified_Date = GetDateTimeValue(reader["modified_date"]);
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
                        data.Id = GetIntegerValue(reader["id"]);
                        data.Legal_Name = GetStringValue(reader["legal_name"]);
                        data.Website_Url = GetStringValue(reader["website_url"]);
                        data.Logo_Url = GetStringValue(reader["logo_url"]);
                        data.Status = GetIntegerValue(reader["status"]);
                        data.Overview = GetStringValue(reader["overview"]);
                        data.Industry_Type = GetIntegerValue(reader["industry_type"]);
                        data.Company_Size = GetIntegerValue(reader["company_size"]);
                        data.Founded_Year = GetStringValue(reader["founded_year"]);
                        data.Verified = GetBitValue(reader["verified"]);
                        data.Active = GetBitValue(reader["active"]);
                        data.Primary_User_Email = GetStringValue(reader["primary_user_email"]);
                        data.Primary_User_Name = GetStringValue(reader["primary_user_name"]);
                        data.Created_By = GetStringValue(reader["created_by"]);
                        data.Created_Date = GetDateTimeValue(reader["created_date"]);
                        data.Modified_By = GetStringValue(reader["modified_by"]);
                        data.Modified_Date = GetDateTimeValue(reader["modified_date"]);
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
                    cmd.Parameters.AddWithValue("@legal_name", companyDTO.Legal_Name);
                    cmd.Parameters.AddWithValue("@website_url", companyDTO.Website_Url);
                    cmd.Parameters.AddWithValue("@logo_url", companyDTO.Logo_Url);
                    cmd.Parameters.AddWithValue("@status", companyDTO.Status);
                    cmd.Parameters.AddWithValue("@overview", companyDTO.Overview);
                    cmd.Parameters.AddWithValue("@industry_type", companyDTO.Industry_Type);
                    cmd.Parameters.AddWithValue("@company_size", companyDTO.Company_Size);
                    cmd.Parameters.AddWithValue("@founded_year", companyDTO.Founded_Year);
                    cmd.Parameters.AddWithValue("@verified", companyDTO.Verified);
                    cmd.Parameters.AddWithValue("@active", true);
                    cmd.Parameters.AddWithValue("@primary_user_email", companyDTO.Primary_User_Email);
                    cmd.Parameters.AddWithValue("@primary_user_name", companyDTO.Primary_User_Name);
                    cmd.Parameters.AddWithValue("@created_by", companyDTO.Created_By);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.UtcNow);
                    cmd.Parameters.AddWithValue("@modified_by", companyDTO.Modified_By);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.UtcNow);
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
                    cmd.Parameters.AddWithValue("@CompanyId", companyDTO.Id);
                    cmd.Parameters.AddWithValue("@legal_name", companyDTO.Legal_Name);
                    cmd.Parameters.AddWithValue("@website_url", companyDTO.Website_Url);
                    cmd.Parameters.AddWithValue("@logo_url", companyDTO.Logo_Url);
                    cmd.Parameters.AddWithValue("@status", companyDTO.Status);
                    cmd.Parameters.AddWithValue("@overview", companyDTO.Overview);
                    cmd.Parameters.AddWithValue("@industry_type", companyDTO.Industry_Type);
                    cmd.Parameters.AddWithValue("@company_size", companyDTO.Company_Size);
                    cmd.Parameters.AddWithValue("@founded_year", companyDTO.Founded_Year);
                    cmd.Parameters.AddWithValue("@verified", companyDTO.Verified);
                    cmd.Parameters.AddWithValue("@active", companyDTO.Active);
                    cmd.Parameters.AddWithValue("@primary_user_email", companyDTO.Primary_User_Email);
                    cmd.Parameters.AddWithValue("@primary_user_name", companyDTO.Primary_User_Name);
                    cmd.Parameters.AddWithValue("@created_by", companyDTO.Created_By);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.UtcNow);
                    cmd.Parameters.AddWithValue("@modified_by", companyDTO.Modified_By);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.UtcNow);
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

        /// <summary>
        /// Get Office Location
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public List<OfficeLocationDTO> GetOfficeLocationDetails(AppSettings settings, out Exception ex)
        {
            List<OfficeLocationDTO> dataToReturn = new List<OfficeLocationDTO>();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_GetOfficeLocation, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        OfficeLocationDTO data = new OfficeLocationDTO();
                        data.id = GetIntegerValue(reader["id"]);
                        data.title = GetStringValue(reader["title"]);
                        data.CountryId = GetIntegerValue(reader["CountryId"]);
                        data.StateId = GetIntegerValue(reader["StateId"]);
                        data.Address_text = GetStringValue(reader["Address_text"]);
                        data.CityId = GetIntegerValue(reader["CityId"]);
                        data.CompanyId = GetIntegerValue(reader["CompanyId"]);
                        data.Active = GetBitValue(reader["Active"]);
                        data.Created_By = GetStringValue(reader["created_by"]);
                        data.Created_Date = GetDateTimeValue(reader["created_date"]);
                        data.Modified_By = GetStringValue(reader["modified_by"]);
                        data.Modified_Date = GetDateTimeValue(reader["modified_date"]);
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
        /// Get Office Location By Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public OfficeLocationDTO GetOfficeLocationDetailsById(int id, AppSettings settings, out Exception ex)
        {
            OfficeLocationDTO data = new OfficeLocationDTO();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_GetOfficeLocationById, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@id", id);
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.Read())
                    {                        
                        data.id = GetIntegerValue(reader["id"]);
                        data.title = GetStringValue(reader["title"]);
                        data.CountryId = GetIntegerValue(reader["CountryId"]);
                        data.StateId = GetIntegerValue(reader["StateId"]);
                        data.Address_text = GetStringValue(reader["Address_text"]);
                        data.CityId = GetIntegerValue(reader["CityId"]);
                        data.CompanyId = GetIntegerValue(reader["CompanyId"]);
                        data.Active = GetBitValue(reader["Active"]);
                        data.Created_By = GetStringValue(reader["created_by"]);
                        data.Created_Date = GetDateTimeValue(reader["created_date"]);
                        data.Modified_By = GetStringValue(reader["modified_by"]);
                        data.Modified_Date = GetDateTimeValue(reader["modified_date"]);                        
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
        /// Insert Office Location Details
        /// </summary>
        /// <param name="officeLocationDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public OfficeLocationDTO InsertOfficeLocationDetails(OfficeLocationDTO officeLocationDTO, AppSettings settings, out Exception ex)
        {
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_InsertOfficeLocation, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@title", officeLocationDTO.title);
                    cmd.Parameters.AddWithValue("@CountryId", officeLocationDTO.CountryId);
                    cmd.Parameters.AddWithValue("@StateId", officeLocationDTO.StateId);
                    cmd.Parameters.AddWithValue("@Address_text", officeLocationDTO.Address_text);
                    cmd.Parameters.AddWithValue("@CityId", officeLocationDTO.CityId);
                    cmd.Parameters.AddWithValue("@CompanyId", officeLocationDTO.CompanyId);
                    cmd.Parameters.AddWithValue("@Active", true);                    
                    cmd.Parameters.AddWithValue("@created_by", officeLocationDTO.Created_By);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified_by", officeLocationDTO.Modified_By);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.Now);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return officeLocationDTO;
        }

        /// <summary>
        /// Update Office Location Details
        /// </summary>
        /// <param name="officeLocationDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public OfficeLocationDTO UpdateOfficeLocationDetails(OfficeLocationDTO officeLocationDTO, AppSettings settings, out Exception ex)
        {
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_UpdateOfficeLocation, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@id", officeLocationDTO.id);
                    cmd.Parameters.AddWithValue("@title", officeLocationDTO.title);
                    cmd.Parameters.AddWithValue("@CountryId", officeLocationDTO.CountryId);
                    cmd.Parameters.AddWithValue("@StateId", officeLocationDTO.StateId);
                    cmd.Parameters.AddWithValue("@Address_text", officeLocationDTO.Address_text);
                    cmd.Parameters.AddWithValue("@CityId", officeLocationDTO.CityId);
                    cmd.Parameters.AddWithValue("@CompanyId", officeLocationDTO.CompanyId);
                    cmd.Parameters.AddWithValue("@Active", officeLocationDTO.Active);
                    cmd.Parameters.AddWithValue("@created_by", officeLocationDTO.Created_By);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified_by", officeLocationDTO.Modified_By);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.Now);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return officeLocationDTO;
        }
        public string DeleteOfficeLocationDetails(int id, AppSettings settings, out Exception ex)
        {
            string result = null;
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_DeleteOfficeLocation, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@active", false);
                    cmd.Parameters.AddWithValue("@id", id);
                    dbConn.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res != 0)
                    {
                        result = "Office Location Removed Successfully";
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
