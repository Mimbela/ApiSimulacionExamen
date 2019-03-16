using ApiSimulacionExamen.Models;
using ApiSimulacionExamen.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiSimulacionExamen.Controllers
{
    public class HomeController : ApiController
    {
        IRepository repo;

        public HomeController(IRepository repo)
        {
            this.repo = repo;
        }

        //-------------------
        [HttpGet]
        [Route("api/ListaHospitales")]
        public List<Hospital> ListaHospitales()
        {
            return this.repo.ListaHospitales();
        }

        [HttpGet]
        [Route("api/VerTodosDatos")]
        public List<Mezcla> VerTodosDatos()
        {
            return this.repo.VerTodosDatos();
        }




        //POST-->INSERTAR
        //[HttpPost]
        [Route("api/InsertarHospital")]
        public void Post(Hospital hosp)
        {
            this.repo.InsertarHospital(hosp);
        }


        [HttpGet]
        [Route("api/BuscarHospital/{id}")]
        public Hospital BuscarHospital(int id)
        {
            return this.repo.BuscarHospital(id);
        }

       



        [Route("api/ModificarHospital/{id}")]
        public void Put(Hospital h,int id)
        {
            this.repo.ModificarHospital(h,id);
        }


        //-----------------------------------
        [Route("api/EliminarHospital/{id}")]
        public void Delete(int id)
        {
            this.repo.EliminarHospital(id);
        }
       

    }
}
