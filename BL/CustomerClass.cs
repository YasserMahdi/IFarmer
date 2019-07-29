using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace IFarmer.BL
{
    class CustomerClass
    {
        public void insertCus(string name, string phone)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];


            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            param[1].Value = phone;



            DAL.Executecmd("insertCustomer", param);
            DAL.close();
        }

        public DataTable getCustomerInfo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getCustomerInfo", null);
            accessobject.close();

            return Dt;

        }

        public void updateCus(string name, string phone ,int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];


            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            param[1].Value = phone;

            param[2] = new SqlParameter("@id", SqlDbType.Int);
            param[2].Value = id;



            DAL.Executecmd("updateUserInfo", param);
            DAL.close();
        }
    }
}
