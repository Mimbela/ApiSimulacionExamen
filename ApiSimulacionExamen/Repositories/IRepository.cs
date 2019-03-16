using ApiSimulacionExamen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSimulacionExamen.Repositories
{
    public interface IRepository
    {
        List<Hospital> ListaHospitales();

        void InsertarHospital(Hospital hospital);

        void ModificarHospital(Hospital hospital, int id);

        Hospital BuscarHospital(int num);

        void EliminarHospital(int id);

        List<Mezcla> VerTodosDatos();



    }
}
