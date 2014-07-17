using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace virtualMaze3C
{
    public class analizarMuros
    {
        Bitmap imagen;
        int x, y,casilla;
        String[,] filas = new String[24, 9];
        String[,] columnas = new String[24, 9];

      public  analizarMuros(Bitmap analizar, int casilla)
        {
           
            this.casilla = casilla;
            imagen = analizar;
        }

        public String[,] analizarFilas(Point inicio)
        {
            int i, j;
            j = 0;

            for (y = inicio.Y; y < (inicio.Y + (casilla * 9)); y += casilla)
            {
                i = 0;
                for (x = inicio.X + (casilla / 2); x < (inicio.X + (casilla * 24)); x += casilla)
                {
                    if (imagen.GetPixel(x, y).Name.ToString() == "ff808080")
                    {
                        filas[i, j] = "0";
                    }
                    else
                    {
                        filas[i, j] = "1";
                    }
                    i++;
                }
                j++;
            }
            return filas;
            
        }

        public String[,] analizarColumnas(Point inicio)
        {
            int i, j;
            j = 0;

            for (x = inicio.X; x < (inicio.X + (casilla * 24)); x += casilla)
            {
                i = 0;
                for (y = inicio.Y + (casilla / 2); y < (inicio.Y + (casilla * 9)); y += casilla)
                {
                    if (imagen.GetPixel(x, y).Name.ToString() == "ff808080")
                    {
                        columnas[j, i] = "0";
                    }
                    else
                    {
                        columnas[j, i] = "1";
                    }
                    i++;
                }
                j++;
            }
             return columnas;
            
        }
    }
}
