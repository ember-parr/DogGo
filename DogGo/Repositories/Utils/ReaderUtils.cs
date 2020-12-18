﻿using DogGo.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doggo.Repositories.Utils
{
    public class ReaderUtils
    {
        public static string GetNullableString(SqlDataReader reader, string columnName)
        {
            if (!reader.IsDBNull(reader.GetOrdinal(columnName)))
            {
                return reader.GetString(reader.GetOrdinal(columnName));
            }
            else
            {
                return null;
            }
        }

        //public static object GetNullableParam(object value)
        //{
        //    if (value != null)
        //    {
        //        return value;
        //    }
        //    else
        //    {
        //        return DBNull.Value;
        //    }
        //}

        public static object GetNullableParam(object value)
        {
            return value ?? DBNull.Value;
        }
    }
}