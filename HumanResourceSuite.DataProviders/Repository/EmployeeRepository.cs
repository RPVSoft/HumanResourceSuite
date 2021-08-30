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
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EmployeeRepository()
        {

        }
        /// <summary>
        /// Get Employee Details
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public List<EmployeeDTO> GetEmployeeDetails(AppSettings settings, out Exception ex)
        {
            List<EmployeeDTO> dataToReturn = new List<EmployeeDTO>();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_GetEmployeeDetails, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        EmployeeDTO data = new EmployeeDTO();
                        data.id = GetIntegerValue(reader["id"]);
                        data.emp_code = GetStringValue(reader["emp_code"]);
                        data.photo_url = GetStringValue(reader["photo_url"]);
                        data.first_name = GetStringValue(reader["first_name"]);
                        data.middle_name = GetStringValue(reader["middle_name"]);
                        data.last_name = GetStringValue(reader["last_name"]);
                        data.gender = GetIntegerValue(reader["gender"]);
                        data.pan_number = GetStringValue(reader["pan_number"]);
                        data.marital_status = GetIntegerValue(reader["marital_status"]);
                        data.personal_email = GetStringValue(reader["personal_email"]);
                        data.work_email = GetStringValue(reader["work_email"]);
                        data.work_phone = GetStringValue(reader["work_phone"]);
                        data.phone_ext = GetStringValue(reader["phone_ext"]);
                        data.mobile_no = GetStringValue(reader["mobile_no"]);
                        data.date_of_birth = GetDateTimeValue(reader["date_of_birth"]);
                        data.vendor_id = GetIntegerValue(reader["vendor_id"]);
                        data.active = GetBitValue(reader["active"]);
                        data.deleted = GetBitValue(reader["deleted"]);
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
        /// Get Employee Details By Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeDTO GetEmployeeDetailsById(int id, AppSettings settings, out Exception ex)
        {
            EmployeeDTO data = new EmployeeDTO();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_GetEmployeeDetailsbyId, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@EmployeeId", id);
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        data.id = GetIntegerValue(reader["id"]);
                        data.emp_code = GetStringValue(reader["emp_code"]);
                        data.photo_url = GetStringValue(reader["photo_url"]);
                        data.first_name = GetStringValue(reader["first_name"]);
                        data.middle_name = GetStringValue(reader["middle_name"]);
                        data.last_name = GetStringValue(reader["last_name"]);
                        data.gender = GetIntegerValue(reader["gender"]);
                        data.pan_number = GetStringValue(reader["pan_number"]);
                        data.marital_status = GetIntegerValue(reader["marital_status"]);
                        data.personal_email = GetStringValue(reader["personal_email"]);
                        data.work_email = GetStringValue(reader["work_email"]);
                        data.work_phone = GetStringValue(reader["work_phone"]);
                        data.phone_ext = GetStringValue(reader["phone_ext"]);
                        data.mobile_no = GetStringValue(reader["mobile_no"]);
                        data.date_of_birth = GetDateTimeValue(reader["date_of_birth"]);
                        data.vendor_id = GetIntegerValue(reader["vendor_id"]);
                        data.active = GetBitValue(reader["active"]);
                        data.deleted = GetBitValue(reader["deleted"]);
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
        /// Insert Employee Details
        /// </summary>
        /// <param name="employeeDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeDTO InsertEmployeeDetails(EmployeeDTO employeeDTO, AppSettings settings, out Exception ex)
        {
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_InsertEmployeeDetails, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@emp_code", employeeDTO.emp_code);
                    cmd.Parameters.AddWithValue("@photo_url", employeeDTO.photo_url);
                    cmd.Parameters.AddWithValue("@first_name", employeeDTO.first_name);
                    cmd.Parameters.AddWithValue("@middle_name", employeeDTO.middle_name);
                    cmd.Parameters.AddWithValue("@last_name", employeeDTO.last_name);
                    cmd.Parameters.AddWithValue("@gender", employeeDTO.gender);
                    cmd.Parameters.AddWithValue("@pan_number", employeeDTO.pan_number);
                    cmd.Parameters.AddWithValue("@marital_status", employeeDTO.marital_status);
                    cmd.Parameters.AddWithValue("@personal_email", employeeDTO.personal_email);
                    cmd.Parameters.AddWithValue("@work_email", employeeDTO.work_email);
                    cmd.Parameters.AddWithValue("@work_phone", employeeDTO.work_phone);
                    cmd.Parameters.AddWithValue("@phone_ext", employeeDTO.phone_ext);
                    cmd.Parameters.AddWithValue("@mobile_no", employeeDTO.mobile_no);
                    cmd.Parameters.AddWithValue("@date_of_birth", employeeDTO.date_of_birth);
                    cmd.Parameters.AddWithValue("@vendor_id", employeeDTO.vendor_id);
                    cmd.Parameters.AddWithValue("@active", true);
                    cmd.Parameters.AddWithValue("@deleted", employeeDTO.deleted);
                    cmd.Parameters.AddWithValue("@created_by", employeeDTO.created_by);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified_by", employeeDTO.modified_by);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.Now);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return employeeDTO;
        }

        /// <summary>
        /// Update Employee Details
        /// </summary>
        /// <param name="employeeDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeDTO UpdateEmployeeDetails(EmployeeDTO employeeDTO, AppSettings settings, out Exception ex)
        {
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_UpdateEmployeeDetails, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeDTO.id);
                    cmd.Parameters.AddWithValue("@emp_code", employeeDTO.emp_code);
                    cmd.Parameters.AddWithValue("@photo_url", employeeDTO.photo_url);
                    cmd.Parameters.AddWithValue("@first_name", employeeDTO.first_name);
                    cmd.Parameters.AddWithValue("@middle_name", employeeDTO.middle_name);
                    cmd.Parameters.AddWithValue("@last_name", employeeDTO.last_name);
                    cmd.Parameters.AddWithValue("@gender", employeeDTO.gender);
                    cmd.Parameters.AddWithValue("@pan_number", employeeDTO.pan_number);
                    cmd.Parameters.AddWithValue("@marital_status", employeeDTO.marital_status);
                    cmd.Parameters.AddWithValue("@personal_email", employeeDTO.personal_email);
                    cmd.Parameters.AddWithValue("@work_email", employeeDTO.work_email);
                    cmd.Parameters.AddWithValue("@work_phone", employeeDTO.work_phone);
                    cmd.Parameters.AddWithValue("@phone_ext", employeeDTO.phone_ext);
                    cmd.Parameters.AddWithValue("@mobile_no", employeeDTO.mobile_no);
                    cmd.Parameters.AddWithValue("@date_of_birth", employeeDTO.date_of_birth);
                    cmd.Parameters.AddWithValue("@vendor_id", employeeDTO.vendor_id);
                    cmd.Parameters.AddWithValue("@active", true);
                    cmd.Parameters.AddWithValue("@deleted", employeeDTO.deleted);
                    cmd.Parameters.AddWithValue("@created_by", employeeDTO.created_by);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified_by", employeeDTO.modified_by);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.Now);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return employeeDTO;
        }
        /// <summary>
        /// Remove Employee Details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public string DeleteEmployeeDetails(int id, AppSettings settings, out Exception ex)
        {
            string result = null;
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_DeleteEmployeeDetails, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@active", false);
                    cmd.Parameters.AddWithValue("@EmployeeId", id);
                    dbConn.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res != 0)
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
        /// Get Employee Address
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public List<EmployeeAddressDTO> GetEmployeeAddress(AppSettings settings, out Exception ex)
        {
            List<EmployeeAddressDTO> dataToReturn = new List<EmployeeAddressDTO>();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_GetEmployeeAddress, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        EmployeeAddressDTO data = new EmployeeAddressDTO();
                        data.id = GetIntegerValue(reader["id"]);
                        data.employee_id = GetIntegerValue(reader["employee_id"]);
                        data.emp_code = GetStringValue(reader["emp_code"]);
                        data.address_line = GetStringValue(reader["address_line"]);
                        data.city = GetIntegerValue(reader["city"]);
                        data.country = GetIntegerValue(reader["country"]);
                        data.state = GetIntegerValue(reader["state"]);
                        data.type = GetIntegerValue(reader["type"]);
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
        /// Get Employee Address By Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeAddressDTO GetEmployeeAddressById(int id, AppSettings settings, out Exception ex)
        {
            EmployeeAddressDTO data = new EmployeeAddressDTO();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_GetEmployeeAddressbyId, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@id", id);
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.Read())
                    {                        
                        data.id = GetIntegerValue(reader["id"]);
                        data.employee_id = GetIntegerValue(reader["employee_id"]);
                        data.emp_code = GetStringValue(reader["emp_code"]);
                        data.address_line = GetStringValue(reader["address_line"]);
                        data.city = GetIntegerValue(reader["city"]);
                        data.country = GetIntegerValue(reader["country"]);
                        data.state = GetIntegerValue(reader["state"]);
                        data.type = GetIntegerValue(reader["type"]);
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
        /// Insert Employee Address
        /// </summary>
        /// <param name="employeeaddressDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeAddressDTO InsertEmployeeAddress(EmployeeAddressDTO employeeaddressDTO, AppSettings settings, out Exception ex)
        {
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_InsertEmployeeAddress, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@employee_id", employeeaddressDTO.employee_id);
                    cmd.Parameters.AddWithValue("@emp_code", employeeaddressDTO.emp_code);
                    cmd.Parameters.AddWithValue("@address_line", employeeaddressDTO.address_line);
                    cmd.Parameters.AddWithValue("@city", employeeaddressDTO.city);
                    cmd.Parameters.AddWithValue("@country", employeeaddressDTO.country);
                    cmd.Parameters.AddWithValue("@state", employeeaddressDTO.state);
                    cmd.Parameters.AddWithValue("@type", employeeaddressDTO.type);
                    cmd.Parameters.AddWithValue("@created_by", employeeaddressDTO.created_by);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified_by", employeeaddressDTO.modified_by);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.Now);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return employeeaddressDTO;
        }

        /// <summary>
        /// Update Employee Address
        /// </summary>
        /// <param name="employeeaddressDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeAddressDTO UpdateEmployeeAddress(EmployeeAddressDTO employeeaddressDTO, AppSettings settings, out Exception ex)
        {
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_UpdateEmployeeAddress, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@id", employeeaddressDTO.id);
                    cmd.Parameters.AddWithValue("@employee_id", employeeaddressDTO.employee_id);
                    cmd.Parameters.AddWithValue("@emp_code", employeeaddressDTO.emp_code);
                    cmd.Parameters.AddWithValue("@address_line", employeeaddressDTO.address_line);
                    cmd.Parameters.AddWithValue("@city", employeeaddressDTO.city);
                    cmd.Parameters.AddWithValue("@country", employeeaddressDTO.country);
                    cmd.Parameters.AddWithValue("@state", employeeaddressDTO.state);
                    cmd.Parameters.AddWithValue("@type", employeeaddressDTO.type);
                    cmd.Parameters.AddWithValue("@created_by", employeeaddressDTO.created_by);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified_by", employeeaddressDTO.modified_by);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.Now);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return employeeaddressDTO;
        }
    }
}
