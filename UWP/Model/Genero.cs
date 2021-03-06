﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.Auxiliar;

namespace UWP.Model
{
    public class Genero : NotifyBase
    {
        private int _generoId;
        private string _descripcion;

        public int GeneroId
        {
            get => _generoId;
            set
            {
                _generoId = value;
                NotificarCambio("GeneroId");
            }
        }
        public string Descripcion
        {
            get => _descripcion;
            set
            {
                _descripcion = value;
                NotificarCambio("Descripcion");
            }
        }
    }
}
