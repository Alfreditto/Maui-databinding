using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Maui_databinding.Models
{
    public class Persona : INotifyPropertyChanged
    {
        private string nombre;
        private string telefono;
        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set
            {
                direccion = value;
                OnProppertyChanged();
            }
        }


        public string Telefono
        {
            get { return telefono; }
            set
            {
                telefono = value;
                OnProppertyChanged();
            }
        }


        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnProppertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnProppertyChanged([CallerMemberName] String propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}