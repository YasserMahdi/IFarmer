using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL
{
    class CompaniesClass
    {
    

        public void insCompanies(string compName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@comp_name", SqlDbType.VarChar, 50);
            param[0].Value = compName;

            DAL.Executecmd("insCompanies", param);
            DAL.close();
        }

        public DataTable fetchCompanyNames()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("fetchCompanyNames", null);
            accessobject.close();


            return Dt;

        }

    }
}
