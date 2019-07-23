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

        public DataTable getDebtInfo(int id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getDebtInfo", param);
            accessobject.close();

            return Dt;

        }


        public void setCompaniesDebts(int order_no, string comp_name, double moneyOf)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];


            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = order_no;

            param[1] = new SqlParameter("@comp_name", SqlDbType.NVarChar,50);
            param[1].Value = comp_name;

            param[2] = new SqlParameter("@moneyOf", SqlDbType.Money);
            param[2].Value = moneyOf;

            param[3] = new SqlParameter("@dateT", SqlDbType.Date);
            param[3].Value = DateTime.Now;





            DAL.Executecmd("setCompaniesDebts", param);
            DAL.close();
        }

        




        public DataTable fetchCompaniesDebts(string compName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@comp_name", SqlDbType.NVarChar,50);
            param[0].Value = compName;

            

            dt = DAL.selectData("fetchCompaniesDebts", param);
            DAL.close();
            return dt;
        }


        public DataTable compDebtHistory(string compName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@compName", SqlDbType.NVarChar, 50);
            param[0].Value = compName;



            dt = DAL.selectData("compDebtHistory", param);
            DAL.close();
            return dt;
        }


        public DataTable final_status_of_debts ()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            


            dt = DAL.selectData("the_final_status_of_debts", null);
            DAL.close();
            return dt;
        }




    }


}
