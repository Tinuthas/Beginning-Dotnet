using System;
using System.Collections.Generic;
using System.Text;

namespace _01_HelloWorld.Model
{
    class Pessoa
    {
        //Atributo - Field / Campos
        private string _name;

        // Métodos Gets/Sets - Propriedades
        public int Codigo { get; set; }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}
