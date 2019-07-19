using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace IFarmer.BL
{
    class debtClass
    {
        public void add_debt_detail(int order_no, int cusID,double moneyOf)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];


            param[0] = new SqlParameter("@order_no", SqlDbType.Int);
            param[0].Value = order_no;

            param[1] = new SqlParameter("@cus_id", SqlDbType.Int);
            param[1].Value = cusID;

            param[2] = new SqlParameter("@moneyOf", SqlDbType.Money);
            param[2].Value = moneyOf;

            param[3] = new SqlParameter("@dateT", SqlDbType.Date);
            param[3].Value = DateTime.Now;





            DAL.Executecmd("add_debt_detail", param);
            DAL.close();
        }

        public DataTable getDebtInfo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getDebtInfo", null);
            accessobject.close();

            return Dt;

        }
    }
}
