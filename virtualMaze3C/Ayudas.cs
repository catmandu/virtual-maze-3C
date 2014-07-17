using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace virtualMaze3C
{
    public class Ayudas
    {
        ToolTip ayuda = new ToolTip();
       public  Ayudas()
        {
            
            ayuda.InitialDelay = 10;
            ayuda.Active = true;
        }
        public void escogerBoton(Control boton)
        {
          
            switch (boton.Name)
            {
                case "bInicio":
                    ayuda.SetToolTip(boton, "Regresa al menú principal del juego");

                    break;
                case "bGenerarLaberinto":
                    ayuda.SetToolTip(boton, "Genera un nuevo laberinto automatico");

                    break;
                case "bGuardar":
                    ayuda.SetToolTip(boton, "Si te gusto el diseño del laberinto, guardalo para usarlo despues");

                    break;
                case "bCambiarAvatar":
                    ayuda.SetToolTip(boton, "Cambia tu avatar o personaje por otro de los disponibles");

                    break;
                case "bModoDeJuego":
                    ayuda.SetToolTip(boton, "Elige uno de los 2 modos de juego");

                    break;
                case "bEnviarDatos":
                    ayuda.SetToolTip(boton, "Envia los datos del laberinto y el recorrido para ser usados en el laberinto fisico");

                    break;
                case "bPrincipalGenerar":
                    ayuda.SetToolTip(boton, "¡Genera un laberinto automaticamente y listo para resolver!");
                    
                    break;
                case "bPrincipalCrear":
                    ayuda.SetToolTip(boton, "¡Crea un laberinto desde 0 segun tus gustos y resuelvelo!");
                   
                    break;
                case "bPrincipalAbrir":
                    ayuda.SetToolTip(boton, "¡Abre uno de tus laberintos guardados anteriormente!");
                   
                    break;
                case "bPrincipalSalir":
                    ayuda.SetToolTip(boton, "Cierra el juego y regresa al escritorio de tu computadora");
                    
                    break;
                case "bCrearLaberinto":
                    ayuda.SetToolTip(boton, "Vuelve a llenar la matriz con todos los muros y empieza de nuevo");

                    break;
                case "bComenzar":
                    ayuda.SetToolTip(boton, "¡Comienza a recorrer el laberinto que creaste!");

                    break;

                case "bInvertir":
                    ayuda.SetToolTip(boton, "Los muros existentes desaparecen y los inexistentes aparecen");

                    break;
                case "bAbrirLaberinto":
                    ayuda.SetToolTip(boton, "Abre un laberinto que hayas guardado anteriormente y recorrelo");

                    break;
            }

        }
    }
}