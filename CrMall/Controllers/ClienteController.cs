using CrMall.Models;
using CrMall.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrMall.Controllers
{
    public class ClienteController : Controller
    {

        private Context data = new Context();

        // GET: Cliente
        public ActionResult Index()
        {
            var clientes = data.Clientes.ToList();

            return View(clientes);
        }

        //GET
        public ActionResult Edit(int id)
        {
            ClienteViewModel clienteViewModel = new ClienteViewModel();
            try
            {
                Cliente cliente = data.Clientes.Find(id);

                clienteViewModel.Id = cliente.Id;
                clienteViewModel.Nome = cliente.Nome;
                clienteViewModel.Nascimento = cliente.Nascimento;
                clienteViewModel.Sexo = cliente.Sexo;
                clienteViewModel.Cep = cliente.Cep;
                clienteViewModel.Endereco = cliente.Endereco;
                clienteViewModel.Numero = cliente.Numero;
                clienteViewModel.Complemento = cliente.Complemento;
                clienteViewModel.Bairro = cliente.Bairro;
                clienteViewModel.Estado = cliente.Estado;
                clienteViewModel.Cidade = cliente.Cidade;
            }
            catch (Exception e)
            {
                throw;
            }
            
            return View("Edit", clienteViewModel);
        }

        [HttpPost]
        public ActionResult Edit(ClienteViewModel clienteViewModel) 
        {
            if (!ModelState.IsValid)
            {
                return View(clienteViewModel);
            }

            try
            {
                Cliente cliente = data.Clientes.Find(clienteViewModel.Id);

                cliente.Nome = clienteViewModel.Nome;
                cliente.Sexo = clienteViewModel.Sexo;
                cliente.Cep = clienteViewModel.Cep;
                cliente.Endereco = clienteViewModel.Endereco;
                cliente.Numero = clienteViewModel.Numero;
                cliente.Complemento = clienteViewModel.Complemento;
                cliente.Bairro = clienteViewModel.Bairro;
                cliente.Estado = clienteViewModel.Estado;
                cliente.Cidade = clienteViewModel.Cidade;

                data.SaveChanges();
            }
            catch (Exception e)
            {

                throw;
            }

            return RedirectToAction("Index");
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ClienteViewModel clienteViewModel) 
        {
            if (!ModelState.IsValid)
            {
                return View(clienteViewModel);
            }

            try
            {
                Cliente cliente = new Cliente();

                cliente.Nome = clienteViewModel.Nome;
                cliente.Nascimento = clienteViewModel.Nascimento ?? DateTime.Now;
                cliente.Sexo = clienteViewModel.Sexo;
                cliente.Cep = clienteViewModel.Cep;
                cliente.Endereco = clienteViewModel.Endereco;
                cliente.Numero = clienteViewModel.Numero;
                cliente.Complemento = clienteViewModel.Complemento;
                cliente.Bairro = clienteViewModel.Bairro;
                cliente.Estado = clienteViewModel.Estado;
                cliente.Cidade = clienteViewModel.Cidade;

                data.Clientes.Add(cliente);
                data.SaveChanges();
            }
            catch (Exception e)
            {

                throw;
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Cliente cliente = data.Clientes.Find(id);
            try
            {
                data.Clientes.Remove(cliente);
                data.SaveChanges();
            }
            catch (Exception e)
            {

                throw;
            }

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Cliente cliente = data.Clientes.Find(id);

            return View(cliente);
        }
    }
}