using Parcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial1.Negocio
{
    public class ClsUser
    {
        public int singIn(User data)
        {


            if ((data.user == "jhonatan" || data.user == "kimberli" || data.user == "katherin") && data.pass == "1234")
            {
                Console.WriteLine("Inicio de sesión correcto");
                return 1;

            }
            else {
                Console.WriteLine("¡Contraseña o usuario incorrecto!");
                return 0;
            }


        } 
    }
}
