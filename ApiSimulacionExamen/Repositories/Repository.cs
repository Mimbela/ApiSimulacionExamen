using ApiSimulacionExamen.Data;
using ApiSimulacionExamen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSimulacionExamen.Repositories
{
    public class Repository : IRepository
    {
        SimulacionContext context;

        public Repository(SimulacionContext context)
        {
            this.context = context;
        }

        public Hospital BuscarHospital(int num)
        {
            return this.context.Hospitales.SingleOrDefault(y=>y.Hospital_cod==num);
        }

        public void EliminarHospital(int id)
        {
            Hospital hosp = this.BuscarHospital(id);
            this.context.Hospitales.Remove(hosp);
            this.context.SaveChanges();
        }

        public void InsertarHospital(Hospital hospital)
        {
            int ultimoId = this.context.Hospitales.Max(x => x.Hospital_cod);//para que detecte el ultimo numero del codigo

            Hospital hosp = new Hospital();
            hosp.Direccion = hospital.Direccion;
            hosp.Hospital_cod = ultimoId + 9;//para que lo sume de 9 en 9
            hosp.NombreHospital = hospital.NombreHospital;
            hosp.Telefono = hospital.Telefono;
            hosp.num_cama = hospital.num_cama;

            this.context.Hospitales.Add(hosp);
            this.context.SaveChanges();

            //en postman ponemos: post
            //y esto en la rutahttp://localhost:7590/api/Home

        }

        

        public List<Hospital> ListaHospitales()
        {
            var consulta = from datos in context.Hospitales
                           select datos;

            return consulta.ToList();
                 
            //return this.context.Hospitales.Select(x => x.NombreHospital).ToList();

        }

        public void ModificarHospital(Hospital hospital,int id)
        {
            Hospital hosp = this.BuscarHospital(id);

            
            hosp.Direccion = hospital.Direccion;
          // hosp.Hospital_cod = hospital.Hospital_cod;
            hosp.NombreHospital = hospital.NombreHospital;
            hosp.num_cama = hospital.num_cama;
            hosp.Telefono = hospital.Telefono;

            this.context.SaveChanges();
        }

        public List<Mezcla> VerTodosDatos()
        {
            var consulta = from datos in this.context.Hospitales
                           join datos2 in this.context.Doctores on datos.Hospital_cod equals datos2.Hospital_cod
                           select new Mezcla
                           {
                               Hospital_cod = datos.Hospital_cod,
                               Apellido = datos2.Apellido,
                               Doctor_Numero = datos2.Doctor_Numero
                           ,
                               Direccion = datos.Direccion,
                               Especialidad = datos2.Especialidad,
                               NombreHospital = datos.NombreHospital,
                               Salario = datos2.Salario
                           ,
                               Telefono = datos.Telefono,
                               num_cama = datos.num_cama
                           };
            return consulta.ToList();
        }
    }
}