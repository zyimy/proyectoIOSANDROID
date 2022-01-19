using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ProyectoIOS
{
    class BlogViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private ObservableCollection<Blog> Blog;
        public ObservableCollection<Blog> blog
        {
            get { return Blog; }
            set
            {
                Blog = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("blog"));
            }
        }
        public BlogViewModel()
        {
            blog = new ObservableCollection<Blog>();
            addData();
        }
        private void addData()
        {
            blog.Add(new Blog
            {

                id = 0,
                title = " Receta: Deliciosa Tarta de pan!  ",
                nombre = "Gisela Casanova",
                imgSource = "tarta.jpg"
            });
            blog.Add(new Blog
            {

                id = 0,
                title = "Desayuna como un campeon tortitas con fresa y arandanos",
                nombre= "Ramon VelazqueZ",
                imgSource = "tortitas.jpg"
            });
            blog.Add(new Blog
            {

                id = 0,
                title = "No te pierdas las mejores verduras para cocinar",
                nombre = "Sonia Fuente",
                imgSource = "verduras.jpg"
            });
            blog.Add(new Blog
            {

                id = 0,
                title = "Zumos energeticos de frutas y verduuras",
                nombre = "julian Reguero",
                imgSource = "sumos.jpg"
            });
            blog.Add(new Blog
            {

                id = 0,
                title = "Todos Podemos Contribuir a un tener un mundo mejor",
                nombre = "Javier Caseres",
                imgSource = "salvando.jpg"
            });
        }

    }
}
