using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIOS
{
    class FireBaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://proyectoios-59b14-default-rtdb.firebaseio.com/");

        public async Task<List<Ayuda>> GetAllComentario()
        {

            return (await firebase
              .Child("Ayuda")
              .OnceAsync<Ayuda>()).Select(item => new Ayuda
              {
                  nombre = item.Object.nombre,
                  apellido = item.Object.apellido,
                  comentario = item.Object.comentario
                 
              }).ToList();
        }
        public async Task AddAyuda(string nombre, string apellido, string comentario)
        {

            await firebase
              .Child("Ayuda")
              .PostAsync(new Ayuda() { nombre = nombre, apellido = apellido, comentario = comentario});
        }



    }
}
