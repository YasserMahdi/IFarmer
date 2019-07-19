using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL
{
    class SeedsAndMaterialClass
    {
        public void insertMtr(string nameMtr, Double buyPrice, Double salePrice, int quantity,string type)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@mat_name", SqlDbType.VarChar, 50);
            param[0].Value = nameMtr;

            param[1] = new SqlParameter("@mat_buy_price", SqlDbType.Money);
            param[1].Value = buyPrice;

            param[2] = new SqlParameter("@mat_sale_price", SqlDbType.Money);
            param[2].Value = salePrice;

            param[3] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[3].Value = quantity;

            param[4] = new SqlParameter("@type_name", SqlDbType.NVarChar, 50);
            param[4].Value = type;

            param[5] = new SqlParameter("@dateT", SqlDbType.Date);
            param[5].Value = DateTime.Now;

            DAL.Executecmd("insertMatirials", param);
            DAL.close();
        }


        public void insertCat(string catName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cat_name", SqlDbType.VarChar, 50);
            param[0].Value = catName;

            DAL.Executecmd("insertCats", param);
            DAL.close();
        }


        public DataTable getMatirialInfo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getMatirialInfo", null);
            accessobject.close();

            foreach (DataRow row in Dt.Rows)
            {
              //  try
              //  {
                //    row["سعر الشراء"] = String.Format("{0:n0}", Convert.ToDouble(row["سعر الشراء"]));
//
             //       row["سعر البيع"] = String.Format("{0:n0}", Convert.ToDouble(row["سعر البيع"]));
              //  }
             //   catch (Exception ex)
              //  {

              //  }
            }


            return Dt;

        }

        public DataTable BringSeedsByType(string type_name)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            param[0].Value = type_name;

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("BringSeedsByType", param);
            accessobject.close();

            foreach (DataRow row in Dt.Rows)
            {
                //  try
                //  {
                //    row["سعر الشراء"] = String.Format("{0:n0}", Convert.ToDouble(row["سعر الشراء"]));
                //
                //       row["سعر البيع"] = String.Format("{0:n0}", Convert.ToDouble(row["سعر البيع"]));
                //  }
                //   catch (Exception ex)
                //  {

                //  }
            }


            return Dt;

        }



    }
}
