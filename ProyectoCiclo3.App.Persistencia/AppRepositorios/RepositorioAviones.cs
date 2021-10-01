using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        List<Aviones> aviones;
 
    public RepositorioAviones()
        {
            aviones= new List<Aviones>()
            {
                new Aviones{id=1,marca="Audi",modelo= 2020,kilometraje= 100000,numero_asientos= 4,placa= "POP678"},
                new Aviones{id=2,marca="Toyota",modelo= 2021,kilometraje= 90000,numero_asientos= 16,placa= "OIU859"},
                new Aviones{id=3,marca="Mazda",modelo= 2000,kilometraje= 150000,numero_asientos= 24,placa= "YUH859"}
 
            };
        }
 
        public IEnumerable<Aviones> GetAll()
        {
            return aviones;
        }
 
        public Aviones GetBusWithId(int id){
            return aviones.SingleOrDefault(b => b.id == id);
        }
    }
}
