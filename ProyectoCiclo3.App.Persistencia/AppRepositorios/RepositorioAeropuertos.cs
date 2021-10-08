using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos
    {
        List<Aeropuertos> aeropuertos;
 
        public RepositorioAeropuertos()
        {
            aeropuertos= new List<Aeropuertos>()
            {
                new Aeropuertos{id=1,sigla="SKAR - AXM",nombre= "ARMENIA - El Eden",pais= "Colombia", tipo= "Internacional"},
                new Aeropuertos{id=2,sigla="SKBG - BGA",nombre= "BUCARAMANGA - Palonegro",pais= "Colombia", tipo= "Internacional"},
                new Aeropuertos{id=3,sigla="SKBO -BOG",nombre= "BOGOTA - El Dorado",pais= "Colombia", tipo= "Internacional"},
                new Aeropuertos{id=4,sigla="SKBQ - BAQ",nombre= "BARRANQUILLA - Ernesto Cortissoz",pais= "Colombia", tipo= "Internacional"},
                new Aeropuertos{id=5,sigla="SKCC - CUC",nombre= "CUCUTA - Camilo Daza",pais= "Colombia", tipo= "Internacional"},
                new Aeropuertos{id=6,sigla="SKCG - CTG",nombre= "CARTAGENA - Rafael Nunez",pais= "Colombia", tipo= "Internacional"},
                new Aeropuertos{id=7,sigla="SKCL - CLO",nombre= "CALI - Alfonso Bonilla Aragon",pais= "Colombia", tipo= "Internacional"},
                new Aeropuertos{id=8,sigla="SKCO - TCO",nombre= "TUMACO - La Florida",pais= "Colombia", tipo= "Nacional"}
            };
        }
 
        public IEnumerable<Aeropuertos> GetAll()
        {
            return aeropuertos;
        }
 
        public Aeropuertos GetAeropuertoWithId(int id){
            return aeropuertos.SingleOrDefault(b => b.id == id);
        }

    public Aeropuertos Update(Aeropuertos newAeropuerto){
            var aeropuerto= aeropuertos.SingleOrDefault(b => b.id == newAeropuerto.id);
            if(aeropuerto != null){
                aeropuerto.sigla = newAeropuerto.sigla;
                aeropuerto.nombre = newAeropuerto.nombre;
                aeropuerto.pais = newAeropuerto.pais;
                aeropuerto.tipo = newAeropuerto.tipo;
            }
        return aeropuerto;
        }

    }
}
