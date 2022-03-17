using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class User
    {
        public string nev;
        public List<Megrendeles> megrend_list;
        public int db;
        public int sum_ar;
        public int sum_kedv;
        public int sum_fiz;

        public User(string nev, List<Megrendeles> order_list)
        {
            this.nev = nev;
            this.megrend_list = Listaz(order_list);
            this.db = megrend_list.Count;
            this.sum_ar = Szamol_ar(order_list);
            this.sum_kedv = Szamol_kedv(order_list);
            this.sum_fiz = Szamol_fiz(order_list);
        }

        public List<Megrendeles> Listaz(List<Megrendeles> order_list)
        {
            List<Megrendeles> lista = new List<Megrendeles>();
            foreach (var item in order_list)
            {
                if (item.userName == nev)
                    lista.Add(item);
            }
            return lista;
        }

        public int Szamol_ar(List<Megrendeles>order_list) 
        {
            int sum = 0;
            foreach (var item in order_list)
                if (item.userName == nev)
                    sum += item.ar;
            return sum;
        }
        public int Szamol_fiz(List<Megrendeles> order_list)
        {
            int sum = 0;
            foreach (var item in order_list)
                if (item.userName == nev)
                    sum += item.fizetendo;
            return sum;
        }
        public int Szamol_kedv(List<Megrendeles> order_list)
        {
            int sum = 0;
            foreach (var item in order_list)
                if (item.userName == nev)
                    sum += item.kedv;
            return sum;
        }
    }
}
