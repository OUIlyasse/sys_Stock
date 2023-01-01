using System;
using System.Data;

namespace iTools
{
    public static class iData
    {
        public static DataTable CreateDataTable(string name, params (string Column, string DataType)[] Tables)
        {
            DataTable dt = new DataTable(name);
            foreach (var Table in Tables)
                dt.Columns.Add(Table.Column, Type.GetType(Table.DataType));
            return dt;
        }
    }
}