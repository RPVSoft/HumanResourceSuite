﻿using HumanResourceSuite.Common.Framework;
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
                    cmd.Parameters.AddWithValue("@created_by", employeeDTO.Created_By);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified_by", employeeDTO.Modified_By);
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
                    cmd.Parameters.AddWithValue("@created_by", employeeDTO.Created_By);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified_by", employeeDTO.Modified_By);
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
                        data.Id = GetIntegerValue(reader["id"]);
                        data.Employee_Id = GetIntegerValue(reader["employee_id"]);
                        data.Emp_Code = GetStringValue(reader["emp_code"]);
                        data.Address_Line = GetStringValue(reader["address_line"]);
                        data.City = GetIntegerValue(reader["city"]);
                        data.Country = GetIntegerValue(reader["country"]);
                        data.State = GetIntegerValue(reader["state"]);
                        data.Type = GetIntegerValue(reader["type"]);
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
                        data.Id = GetIntegerValue(reader["id"]);
                        data.Employee_Id = GetIntegerValue(reader["employee_id"]);
                        data.Emp_Code = GetStringValue(reader["emp_code"]);
                        data.Address_Line = GetStringValue(reader["address_line"]);
                        data.City = GetIntegerValue(reader["city"]);
                        data.Country = GetIntegerValue(reader["country"]);
                        data.State = GetIntegerValue(reader["state"]);
                        data.Type = GetIntegerValue(reader["type"]);
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
                    cmd.Parameters.AddWithValue("@employee_id", employeeaddressDTO.Employee_Id);
                    cmd.Parameters.AddWithValue("@emp_code", employeeaddressDTO.Emp_Code);
                    cmd.Parameters.AddWithValue("@address_line", employeeaddressDTO.Address_Line);
                    cmd.Parameters.AddWithValue("@city", employeeaddressDTO.City);
                    cmd.Parameters.AddWithValue("@country", employeeaddressDTO.Country);
                    cmd.Parameters.AddWithValue("@state", employeeaddressDTO.State);
                    cmd.Parameters.AddWithValue("@type", employeeaddressDTO.Type);
                    cmd.Parameters.AddWithValue("@created_by", employeeaddressDTO.Created_By);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.UtcNow);
                    cmd.Parameters.AddWithValue("@modified_by", employeeaddressDTO.Modified_By);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.UtcNow);
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
                    cmd.Parameters.AddWithValue("@id", employeeaddressDTO.Id);
                    cmd.Parameters.AddWithValue("@employee_id", employeeaddressDTO.Employee_Id);
                    cmd.Parameters.AddWithValue("@emp_code", employeeaddressDTO.Emp_Code);
                    cmd.Parameters.AddWithValue("@address_line", employeeaddressDTO.Address_Line);
                    cmd.Parameters.AddWithValue("@city", employeeaddressDTO.City);
                    cmd.Parameters.AddWithValue("@country", employeeaddressDTO.Country);
                    cmd.Parameters.AddWithValue("@state", employeeaddressDTO.State);
                    cmd.Parameters.AddWithValue("@type", employeeaddressDTO.Type);
                    cmd.Parameters.AddWithValue("@created_by", employeeaddressDTO.Created_By);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.UtcNow);
                    cmd.Parameters.AddWithValue("@modified_by", employeeaddressDTO.Modified_By);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.UtcNow);
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
        /// Get Employee Bank Details
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public List<EmployeeBankDetailsDTO> GetEmployeeBankDetails(AppSettings settings, out Exception ex)
        {
            List<EmployeeBankDetailsDTO> dataToReturn = new List<EmployeeBankDetailsDTO>();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_GetEmployeeBankDetails, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        EmployeeBankDetailsDTO data = new EmployeeBankDetailsDTO();
                        data.id = GetIntegerValue(reader["id"]);
                        data.employee_id = GetIntegerValue(reader["employee_id"]);
                        data.emp_code = GetStringValue(reader["emp_code"]);
                        data.bank = GetStringValue(reader["bank"]);
                        data.account_no = GetStringValue(reader["account_no"]);
                        data.ifsc_code = GetStringValue(reader["ifsc_code"]);
                        data.active = GetBitValue(reader["active"]);                        
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
        /// Get Employee Bank Details By Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeBankDetailsDTO GetEmployeeEmployeeBankDetailsById(int id, AppSettings settings, out Exception ex)
        {
            EmployeeBankDetailsDTO data = new EmployeeBankDetailsDTO();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_GetEmployeeBankDetailsbyId, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@id", id);
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        data.id = GetIntegerValue(reader["id"]);
                        data.employee_id = GetIntegerValue(reader["employee_id"]);
                        data.emp_code = GetStringValue(reader["emp_code"]);
                        data.bank = GetStringValue(reader["bank"]);
                        data.account_no = GetStringValue(reader["account_no"]);
                        data.ifsc_code = GetStringValue(reader["ifsc_code"]);
                        data.active = GetBitValue(reader["active"]);
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
        /// Insert Employee Bank Details
        /// </summary>
        /// <param name="employeeBankDetailsDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeBankDetailsDTO InsertEmployeeBankDetails(EmployeeBankDetailsDTO employeeBankDetailsDTO, AppSettings settings, out Exception ex)
        {
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_InsertEmployeeBankDetails, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@employee_id", employeeBankDetailsDTO.employee_id);
                    cmd.Parameters.AddWithValue("@emp_code", employeeBankDetailsDTO.emp_code);
                    cmd.Parameters.AddWithValue("@bank", employeeBankDetailsDTO.bank);
                    cmd.Parameters.AddWithValue("@account_no", employeeBankDetailsDTO.account_no);
                    cmd.Parameters.AddWithValue("@ifsc_code", employeeBankDetailsDTO.ifsc_code);
                    cmd.Parameters.AddWithValue("@active", true);
                    cmd.Parameters.AddWithValue("@created_by", employeeBankDetailsDTO.Created_By);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified_by", employeeBankDetailsDTO.Modified_By);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.Now);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return employeeBankDetailsDTO;
        }

        /// <summary>
        /// Update Employee Bank Details
        /// </summary>
        /// <param name="employeeBankDetailsDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeBankDetailsDTO UpdateEmployeeBankDetails(EmployeeBankDetailsDTO employeeBankDetailsDTO, AppSettings settings, out Exception ex)
        {
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_UpdateEmployeeBankDetails, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@id", employeeBankDetailsDTO.id);
                    cmd.Parameters.AddWithValue("@employee_id", employeeBankDetailsDTO.employee_id);
                    cmd.Parameters.AddWithValue("@emp_code", employeeBankDetailsDTO.emp_code);
                    cmd.Parameters.AddWithValue("@bank", employeeBankDetailsDTO.bank);
                    cmd.Parameters.AddWithValue("@account_no", employeeBankDetailsDTO.account_no);
                    cmd.Parameters.AddWithValue("@ifsc_code", employeeBankDetailsDTO.ifsc_code);
                    cmd.Parameters.AddWithValue("@active", employeeBankDetailsDTO.active);
                    cmd.Parameters.AddWithValue("@created_by", employeeBankDetailsDTO.Created_By);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified_by", employeeBankDetailsDTO.Modified_By);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.Now);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return employeeBankDetailsDTO;
        }

        /// <summary>
        /// Get Employee Investment Details
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public List<EmployeeInvestmentDTO> GetEmployeeInvestment(AppSettings settings, out Exception ex)
        {
            List<EmployeeInvestmentDTO> dataToReturn = new List<EmployeeInvestmentDTO>();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_GetEmployeeInvestment, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        EmployeeInvestmentDTO data = new EmployeeInvestmentDTO();
                        data.id = GetIntegerValue(reader["id"]);
                        data.employee_id = GetIntegerValue(reader["employee_id"]);
                        data.emp_code = GetStringValue(reader["emp_code"]);
                        data.financial_year = GetStringValue(reader["financial_year"]);
                        data.house_rent_allowance = GetDecimalValue(reader["house_rent_allowance"]);
                        data.life_insurance_premium = GetDecimalValue(reader["life_insurance_premium"]);                        
                        data.provident_fund = GetDecimalValue(reader["provident_fund"]);
                        data.public_provident_fund = GetDecimalValue(reader["public_provident_fund"]);
                        data.voluntary_provident_fund = GetDecimalValue(reader["voluntary_provident_fund"]);
                        data.nsc = GetDecimalValue(reader["nsc"]);
                        data.interest_nsc = GetDecimalValue(reader["interest_nsc"]);
                        data.ulip = GetDecimalValue(reader["ulip"]);
                        data.elss_mutual_fund = GetDecimalValue(reader["elss_mutual_fund"]);
                        data.tution_fees = GetDecimalValue(reader["tution_fees"]);
                        data.principal_repayment_house_loan = GetDecimalValue(reader["principal_repayment_house_loan"]);
                        data.house_stamp_duty_reg_charges = GetDecimalValue(reader["house_stamp_duty_reg_charges"]);
                        data.infrastructure_bonds = GetDecimalValue(reader["infrastructure_bonds"]);
                        data.bank_fixed_deposit = GetDecimalValue(reader["bank_fixed_deposit"]);
                        data.post_office_term_deposit = GetDecimalValue(reader["post_office_term_deposit"]);
                        data.medical_insurance_premium = GetDecimalValue(reader["medical_insurance_premium"]);
                        data.medical_insurance_premuim_parents = GetDecimalValue(reader["medical_insurance_premuim_parents"]);
                        data.preventive_health_checkup = GetDecimalValue(reader["preventive_health_checkup"]);
                        data.home_loan_interest = GetDecimalValue(reader["home_loan_interest"]);                        
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
        /// Get Employee Investment Details By Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeInvestmentDTO GetEmployeeEmployeeInvestmentById(int id, AppSettings settings, out Exception ex)
        {
            EmployeeInvestmentDTO data = new EmployeeInvestmentDTO();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_GetEmployeeInvestmentbyId, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@id", id);
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        data.id = GetIntegerValue(reader["id"]);
                        data.employee_id = GetIntegerValue(reader["employee_id"]);
                        data.emp_code = GetStringValue(reader["emp_code"]);
                        data.financial_year = GetStringValue(reader["financial_year"]);
                        data.house_rent_allowance = GetDecimalValue(reader["house_rent_allowance"]);
                        data.life_insurance_premium = GetDecimalValue(reader["life_insurance_premium"]);
                        data.provident_fund = GetDecimalValue(reader["provident_fund"]);
                        data.public_provident_fund = GetDecimalValue(reader["public_provident_fund"]);
                        data.voluntary_provident_fund = GetDecimalValue(reader["voluntary_provident_fund"]);
                        data.nsc = GetDecimalValue(reader["nsc"]);
                        data.interest_nsc = GetDecimalValue(reader["interest_nsc"]);
                        data.ulip = GetDecimalValue(reader["ulip"]);
                        data.elss_mutual_fund = GetDecimalValue(reader["elss_mutual_fund"]);
                        data.tution_fees = GetDecimalValue(reader["tution_fees"]);
                        data.principal_repayment_house_loan = GetDecimalValue(reader["principal_repayment_house_loan"]);
                        data.house_stamp_duty_reg_charges = GetDecimalValue(reader["house_stamp_duty_reg_charges"]);
                        data.infrastructure_bonds = GetDecimalValue(reader["infrastructure_bonds"]);
                        data.bank_fixed_deposit = GetDecimalValue(reader["bank_fixed_deposit"]);
                        data.post_office_term_deposit = GetDecimalValue(reader["post_office_term_deposit"]);
                        data.medical_insurance_premium = GetDecimalValue(reader["medical_insurance_premium"]);
                        data.medical_insurance_premuim_parents = GetDecimalValue(reader["medical_insurance_premuim_parents"]);
                        data.preventive_health_checkup = GetDecimalValue(reader["preventive_health_checkup"]);
                        data.home_loan_interest = GetDecimalValue(reader["home_loan_interest"]);
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
        /// Insert Employee Investment Details
        /// </summary>
        /// <param name="employeeInvestmentDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeInvestmentDTO InsertEmployeeInvestment(EmployeeInvestmentDTO employeeInvestmentDTO, AppSettings settings, out Exception ex)
        {
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_InsertEmployeeInvestment, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@employee_id", employeeInvestmentDTO.employee_id);
                    cmd.Parameters.AddWithValue("@emp_code", employeeInvestmentDTO.emp_code);
                    cmd.Parameters.AddWithValue("@financial_year", employeeInvestmentDTO.financial_year);
                    cmd.Parameters.AddWithValue("@house_rent_allowance", employeeInvestmentDTO.house_rent_allowance);
                    cmd.Parameters.AddWithValue("@life_insurance_premium", employeeInvestmentDTO.life_insurance_premium);
                    cmd.Parameters.AddWithValue("@provident_fund", employeeInvestmentDTO.provident_fund);
                    cmd.Parameters.AddWithValue("@public_provident_fund", employeeInvestmentDTO.public_provident_fund);
                    cmd.Parameters.AddWithValue("@voluntary_provident_fund", employeeInvestmentDTO.voluntary_provident_fund);
                    cmd.Parameters.AddWithValue("@nsc", employeeInvestmentDTO.nsc);
                    cmd.Parameters.AddWithValue("@interest_nsc", employeeInvestmentDTO.interest_nsc);
                    cmd.Parameters.AddWithValue("@ulip", employeeInvestmentDTO.ulip);
                    cmd.Parameters.AddWithValue("@elss_mutual_fund", employeeInvestmentDTO.elss_mutual_fund);
                    cmd.Parameters.AddWithValue("@tution_fees", employeeInvestmentDTO.tution_fees);
                    cmd.Parameters.AddWithValue("@principal_repayment_house_loan", employeeInvestmentDTO.principal_repayment_house_loan);
                    cmd.Parameters.AddWithValue("@house_stamp_duty_reg_charges", employeeInvestmentDTO.house_stamp_duty_reg_charges);
                    cmd.Parameters.AddWithValue("@infrastructure_bonds", employeeInvestmentDTO.infrastructure_bonds);
                    cmd.Parameters.AddWithValue("@bank_fixed_deposit", employeeInvestmentDTO.bank_fixed_deposit);
                    cmd.Parameters.AddWithValue("@post_office_term_deposit", employeeInvestmentDTO.post_office_term_deposit);
                    cmd.Parameters.AddWithValue("@medical_insurance_premium", employeeInvestmentDTO.medical_insurance_premium);
                    cmd.Parameters.AddWithValue("@medical_insurance_premuim_parents", employeeInvestmentDTO.medical_insurance_premuim_parents);
                    cmd.Parameters.AddWithValue("@preventive_health_checkup", employeeInvestmentDTO.preventive_health_checkup);
                    cmd.Parameters.AddWithValue("@home_loan_interest", employeeInvestmentDTO.home_loan_interest);                   
                    cmd.Parameters.AddWithValue("@created_by", employeeInvestmentDTO.Created_By);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified_by", employeeInvestmentDTO.Modified_By);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.Now);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return employeeInvestmentDTO;
        }

        /// <summary>
        /// Update Employee Investment Details
        /// </summary>
        /// <param name="employeeInvestmentDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeInvestmentDTO UpdateEmployeeInvestment(EmployeeInvestmentDTO employeeInvestmentDTO, AppSettings settings, out Exception ex)
        {
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_UpdateEmployeeInvestment, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@id", employeeInvestmentDTO.id);
                    cmd.Parameters.AddWithValue("@employee_id", employeeInvestmentDTO.employee_id);
                    cmd.Parameters.AddWithValue("@emp_code", employeeInvestmentDTO.emp_code);
                    cmd.Parameters.AddWithValue("@financial_year", employeeInvestmentDTO.financial_year);
                    cmd.Parameters.AddWithValue("@house_rent_allowance", employeeInvestmentDTO.house_rent_allowance);
                    cmd.Parameters.AddWithValue("@life_insurance_premium", employeeInvestmentDTO.life_insurance_premium);
                    cmd.Parameters.AddWithValue("@provident_fund", employeeInvestmentDTO.provident_fund);
                    cmd.Parameters.AddWithValue("@public_provident_fund", employeeInvestmentDTO.public_provident_fund);
                    cmd.Parameters.AddWithValue("@voluntary_provident_fund", employeeInvestmentDTO.voluntary_provident_fund);
                    cmd.Parameters.AddWithValue("@nsc", employeeInvestmentDTO.nsc);
                    cmd.Parameters.AddWithValue("@interest_nsc", employeeInvestmentDTO.interest_nsc);
                    cmd.Parameters.AddWithValue("@ulip", employeeInvestmentDTO.ulip);
                    cmd.Parameters.AddWithValue("@elss_mutual_fund", employeeInvestmentDTO.elss_mutual_fund);
                    cmd.Parameters.AddWithValue("@tution_fees", employeeInvestmentDTO.tution_fees);
                    cmd.Parameters.AddWithValue("@principal_repayment_house_loan", employeeInvestmentDTO.principal_repayment_house_loan);
                    cmd.Parameters.AddWithValue("@house_stamp_duty_reg_charges", employeeInvestmentDTO.house_stamp_duty_reg_charges);
                    cmd.Parameters.AddWithValue("@infrastructure_bonds", employeeInvestmentDTO.infrastructure_bonds);
                    cmd.Parameters.AddWithValue("@bank_fixed_deposit", employeeInvestmentDTO.bank_fixed_deposit);
                    cmd.Parameters.AddWithValue("@post_office_term_deposit", employeeInvestmentDTO.post_office_term_deposit);
                    cmd.Parameters.AddWithValue("@medical_insurance_premium", employeeInvestmentDTO.medical_insurance_premium);
                    cmd.Parameters.AddWithValue("@medical_insurance_premuim_parents", employeeInvestmentDTO.medical_insurance_premuim_parents);
                    cmd.Parameters.AddWithValue("@preventive_health_checkup", employeeInvestmentDTO.preventive_health_checkup);
                    cmd.Parameters.AddWithValue("@home_loan_interest", employeeInvestmentDTO.home_loan_interest);
                    cmd.Parameters.AddWithValue("@created_by", employeeInvestmentDTO.Created_By);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified_by", employeeInvestmentDTO.Modified_By);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.Now);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return employeeInvestmentDTO;
        }

        /// <summary>
        /// Get Employee Leave Details
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public List<EmployeeLeaveDTO> GetEmployeeLeaveDetails(AppSettings settings, out Exception ex)
        {
            List<EmployeeLeaveDTO> dataToReturn = new List<EmployeeLeaveDTO>();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_GetEmployeeLeaveDetails, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        EmployeeLeaveDTO data = new EmployeeLeaveDTO();
                        data.id = GetIntegerValue(reader["id"]);
                        data.leave_type = GetIntegerValue(reader["leave_type"]);
                        data.employee_id = GetIntegerValue(reader["employee_id"]);
                        data.emp_code = GetStringValue(reader["emp_code"]);
                        data.from_date = GetDateTimeValue(reader["from_date"]);
                        data.to_date = GetDateTimeValue(reader["to_date"]);
                        data.reason = GetStringValue(reader["reason"]);
                        data.status = GetIntegerValue(reader["status"]);
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
        /// Get Employee Leave Details By Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeLeaveDTO GetEmployeeLeaveDetailsById(int id, AppSettings settings, out Exception ex)
        {
            EmployeeLeaveDTO data = new EmployeeLeaveDTO();
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_GetEmployeeLeaveDetailsbyId, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@id", id);
                    dbConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        data.id = GetIntegerValue(reader["id"]);
                        data.leave_type = GetIntegerValue(reader["leave_type"]);
                        data.employee_id = GetIntegerValue(reader["employee_id"]);
                        data.emp_code = GetStringValue(reader["emp_code"]);
                        data.from_date = GetDateTimeValue(reader["from_date"]);
                        data.to_date = GetDateTimeValue(reader["to_date"]);
                        data.reason = GetStringValue(reader["reason"]);
                        data.status = GetIntegerValue(reader["status"]);
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
        /// Insert Employee Leave Details
        /// </summary>
        /// <param name="employeeLeaveDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeLeaveDTO InsertEmployeeLeaveDetails(EmployeeLeaveDTO employeeLeaveDTO, AppSettings settings, out Exception ex)
        {
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_InsertEmployeeLeaveDetails, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@leave_type", employeeLeaveDTO.leave_type);
                    cmd.Parameters.AddWithValue("@employee_id", employeeLeaveDTO.employee_id);
                    cmd.Parameters.AddWithValue("@emp_code", employeeLeaveDTO.emp_code);                    
                    cmd.Parameters.AddWithValue("@from_date", employeeLeaveDTO.from_date);
                    cmd.Parameters.AddWithValue("@to_date", employeeLeaveDTO.to_date);
                    cmd.Parameters.AddWithValue("@reason", employeeLeaveDTO.reason);
                    cmd.Parameters.AddWithValue("@status", employeeLeaveDTO.status);
                    cmd.Parameters.AddWithValue("@created_by", employeeLeaveDTO.Created_By);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified_by", employeeLeaveDTO.Modified_By);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.Now);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return employeeLeaveDTO;
        }

        /// <summary>
        /// Update Employee Leave Details
        /// </summary>
        /// <param name="employeeLeaveDTO"></param>
        /// <param name="settings"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        public EmployeeLeaveDTO UpdateEmployeeLeaveDetails(EmployeeLeaveDTO employeeLeaveDTO, AppSettings settings, out Exception ex)
        {
            ex = null;
            try
            {
                // Make a database call
                using (SqlConnection dbConn = new SqlConnection(settings.DbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(StoreProc.SP_UpdateEmployeeLeaveDetails, dbConn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@id", employeeLeaveDTO.id);
                    cmd.Parameters.AddWithValue("@leave_type", employeeLeaveDTO.leave_type);
                    cmd.Parameters.AddWithValue("@employee_id", employeeLeaveDTO.employee_id);
                    cmd.Parameters.AddWithValue("@emp_code", employeeLeaveDTO.emp_code);
                    cmd.Parameters.AddWithValue("@from_date", employeeLeaveDTO.from_date);
                    cmd.Parameters.AddWithValue("@to_date", employeeLeaveDTO.to_date);
                    cmd.Parameters.AddWithValue("@reason", employeeLeaveDTO.reason);
                    cmd.Parameters.AddWithValue("@status", employeeLeaveDTO.status);
                    cmd.Parameters.AddWithValue("@created_by", employeeLeaveDTO.Created_By);
                    cmd.Parameters.AddWithValue("@created_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified_by", employeeLeaveDTO.Modified_By);
                    cmd.Parameters.AddWithValue("@modified_date", DateTime.Now);
                    dbConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exMsg)
            {
                ex = exMsg;
            }
            return employeeLeaveDTO;
        }

    }
}
