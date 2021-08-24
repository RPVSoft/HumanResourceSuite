using HumanResourceSuite.Common.Framework;
using HumanResourceSuite.DataObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.BusinessProviders.IProviders
{
    public interface IMasterProvider
    {
        public List<MasterDTO> GetAll(AppSettings settings, out Exception ex);
        public List<MasterDTO> Get(int id, AppSettings settings, out Exception ex);
    }
}
