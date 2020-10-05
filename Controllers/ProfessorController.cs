using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProvaWeb2Ex4.Data;
using ProvaWeb2Ex4.Models;

namespace ProvaWeb2Ex4.Controllers
{
    public class ProfessorController : Controller
    {
        private DataContext db = new DataContext();
       

        // GET: Professor/Create
        public ActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nome,Endereco,Telefone,Email,Disciplina")] Professor professor)
        {
            if (ModelState.IsValid)
            {
                db.Professors.Add(professor);
                await db.SaveChangesAsync();
            }

            return View(professor);
        }
        
    }
}
