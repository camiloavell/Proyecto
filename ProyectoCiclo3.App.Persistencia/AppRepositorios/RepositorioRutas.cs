using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas;
 
        public RepositorioRutas()
        {
            rutas= new List<Rutas>()
            {
                new Rutas{id=1,origen=1,destino= 1,tiempo_estimado= 4},
                new Rutas{id=2,origen=1,destino= 2,tiempo_estimado= 6},
                new Rutas{id=3,origen=1,destino= 3,tiempo_estimado= 3},
                new Rutas{id=4,origen=2,destino= 1,tiempo_estimado= 4},
                new Rutas{id=5,origen=2,destino= 2,tiempo_estimado= 6},
                new Rutas{id=6,origen=2,destino= 3,tiempo_estimado= 3},
                new Rutas{id=7,origen=3,destino= 1,tiempo_estimado= 4},
                new Rutas{id=8,origen=3,destino= 2,tiempo_estimado= 6},
                new Rutas{id=9,origen=3,destino= 3,tiempo_estimado= 3},
            };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetRutaWithId(int id){
            return rutas.SingleOrDefault(b => b.id == id);
        }

        public Rutas Create(Rutas newRuta)
        {
            return newRuta;
        }

        public void Delete(int id)
        {

        }        

        public Rutas Update(Rutas newRuta){
                var ruta= rutas.SingleOrDefault(b => b.id == newRuta.id);
                if(ruta != null){
                    ruta.origen = newRuta.origen;
                    ruta.destino = newRuta.destino;
                    ruta.tiempo_estimado = newRuta.tiempo_estimado;
                }
            return ruta;
            }

        }
}
