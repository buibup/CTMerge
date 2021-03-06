﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CTMerge.API.DataAccess
{
    public static class Extension
    {
        public static void AddInputParameters<T>(this IDbCommand cmd,
         T parameters) where T : class
        {
            foreach (var prop in parameters.GetType().GetProperties())
            {
                object val = prop.GetValue(parameters, null);
                var p = cmd.CreateParameter();
                p.ParameterName = prop.Name;
                p.Value = val ?? DBNull.Value;
                cmd.Parameters.Add(p);
            }
        }
    }
}