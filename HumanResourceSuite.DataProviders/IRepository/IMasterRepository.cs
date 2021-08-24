using HumanResourceSuite.Common.Framework;
using HumanResourceSuite.DataObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataProviders.IRepository
{
    public interface IMasterRepository
    {
        public List<MasterDTO> GetAll(AppSettings settings, out Exception ex);
        public List<MasterDTO> Get(int id, AppSettings settings, out Exception ex);
    }
}
