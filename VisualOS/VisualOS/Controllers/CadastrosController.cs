using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VisualOS.DAL;
using VisualOS.Models;
using System.Data.Entity.Infrastructure;

namespace VisualOS.Controllers
{
    public class CadastrosController : Controller
    {
        private tb_servico servico = new tb_servico();

        private tb_ordemservico OS = new tb_ordemservico();

        private tb_cargo cargo = new tb_cargo();

        // GET: Cadastros
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cadastros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cadastros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cadastros/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private Model1Container db = new Model1Container();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarServico(tb_servico servico)
        {
            db.tb_servico.Add(servico);
            db.SaveChanges();
            return View();
        }

        public ActionResult CadastrarServico()
        {
           
            
                return View();
          

          
        }

        public ActionResult CadastrarOS()
        {
            return View();
        }

        // GET: Cadastros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cadastros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cadastros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cadastros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CadastrarCargo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarOS(tb_ordemservico OSModel)
        {
            if (ModelState.IsValid)
            {
                Model1Container context = new Model1Container();
                context.tb_ordemservico.Add(OSModel);
                context.SaveChanges();
                return RedirectToAction("CadastrarOS");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarCargo(tb_cargo Cadastro)
        {
            if (ModelState.IsValid)
            {
                Model1Container context = new Model1Container();
                context.tb_cargo.Add(Cadastro);
                context.SaveChanges();
                return RedirectToAction("CadastrarCargo");
            }

            return View();
        }
    }
}
