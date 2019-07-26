﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL
{
    class DocumentClass
    {
        public DataTable getIDforDoc()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getIDforInvoice", null);
            accessobject.close();

            return Dt;

        }

        public DataTable getLastDocForPrint()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getLastDocForPrint", null);
            accessobject.close();

            return Dt;

        }

        public void add_doc(int customerID, string id, string note, double total_ammount, double paid, Double rest)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = Convert.ToInt32(id);

            param[1] = new SqlParameter("@doc_date", SqlDbType.DateTime);
            param[1].Value = DateTime.Now;

            param[2] = new SqlParameter("@note", SqlDbType.NVarChar, 50);
            param[2].Value = note;

            param[3] = new SqlParameter("@customer_iD", SqlDbType.Int);
            param[3].Value = customerID;

            param[4] = new SqlParameter("@total_amount", SqlDbType.Money);
            param[4].Value = total_ammount;

            param[5] = new SqlParameter("@paid", SqlDbType.Money);
            param[5].Value = paid;

            param[6] = new SqlParameter("@rest", SqlDbType.Money);
            param[6].Value = rest;



            DAL.Executecmd("add_doc", param);
            DAL.close();
        }

        public void add_doc_detail(int mat_no, int order_no, int qte, double price, double amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@mat_no", SqlDbType.Int);
            param[0].Value = mat_no;

            param[1] = new SqlParameter("@doc_no", SqlDbType.Int);
            param[1].Value = order_no;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@price", SqlDbType.Money);
            param[3].Value = price;

            param[4] = new SqlParameter("@amount", SqlDbType.Money);
            param[4].Value = Convert.ToDouble(amount);





            DAL.Executecmd("add_doc_detail", param);
            DAL.close();
        }



        public DataTable fetchDocInfo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("fetchDocInfo", null);
            accessobject.close();

            return Dt;

        }


        public DataTable listDoc()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("listDoc", null);
            accessobject.close();


            return Dt;
        }






        public DataTable searchinDoc(string reference)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ref", SqlDbType.NVarChar, 64);
            param[0].Value = reference;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("searchinDoc", param);
            accessobject.close();

            return Dt;

        }





    }

}

