using ResistenciaBR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResistenciaBR.Services
{
    public class TipService
    {
        public void Salvar(Tip tip)
        {
            using (var db = new MyContext())
            {
                if (tip.Codigo > 0)
                {
                    db.Tips.Attach(tip);
                    db.Entry(tip).State = System.Data.Entity.EntityState.Modified;
                }
                else
                    db.Tips.Add(tip);
                db.SaveChanges();
            }
        }

        public Tip Obter (int codigo)
        {
            using (var db = new MyContext())
            {
                return db.Tips.Find(codigo);
            }
        }

        public List<Tip> Listar()
        {
            using (var db = new MyContext())
            {
                return db.Tips.ToList();
            }
        }

        public void Deletar(int codigo)
        {
            using (var db = new MyContext())
            {
                var tip = db.Tips.Find(codigo);
               db.Tips.Attach(tip);
                db.Tips.Remove(tip);
                db.SaveChanges();
            }
        }

    }
}