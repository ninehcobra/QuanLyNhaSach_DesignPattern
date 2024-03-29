﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CNPM.DataAccessTier;

namespace CNPM
{
    class SachBLT
    {
        SachDAT objSach = new SachDAT();

        public DataTable getTable(Sach sach = null)
        {
            if (sach == null)
                return objSach.getSachTable();
            else
                return objSach.getTraCuuSachTable(sach);
        }

        public Sach getSachbyID(int ma_sach)
        {
            return objSach.getSach(ma_sach);
        }

        public int Them(Sach sach)
        {
            return objSach.Them(sach);
        }

        public bool Sua(Sach sach)
        {
            if (objSach.Check(sach.MaSach))
                return objSach.Sua(sach);
            return false;
        }
    }
}
