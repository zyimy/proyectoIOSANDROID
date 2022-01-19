using ProyectoIOS.Helpers;
using ProyectoIOS.Models;
using ProyectoIOS.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProyectoIOS.ViewModels
{
    public class RegistrosViewModel : ViewModelBase
    {
        HelperRegistro helper;

        public RegistrosViewModel()

       {

           helper = new HelperRegistro();

           Task.Run(async () =>
            {

               List<Restaurante> lista = await helper.GetRestaurantes();

                this.Restaurantes = new ObservableCollection<Restaurante>(lista);

            });

        }

        private ObservableCollection<Restaurante> _Restaurantes;
       public ObservableCollection<Restaurante> Restaurantes

        {

            get { return this._Restaurantes; }

           set

            {

               this._Restaurantes = value;

                OnPropertyChanged("Restaurantes");

            }

       }

      

        
    }

}