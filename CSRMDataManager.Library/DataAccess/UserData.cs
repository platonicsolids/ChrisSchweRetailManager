﻿using CSRMDataManager.Library.Internal.DataAccess;
using CSRMDataManager.Library.Internal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSRMDataManager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string id)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new { id = id };
            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "DefaultConnection");
            return output;
        }
    }
}
