﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL
{
    class categories
    {

        public DataTable getCategoriesInfo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getCategoriesInfo", null);
            accessobject.close();


            return Dt;

        }

        public void delCat(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@ref", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            DAL.Executecmd("deleteCat", param);
            DAL.close();
        }

    }
}
