using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace virtualMaze3C
{
    public class EfectosSonido 
    {
       public SoundPlayer efecto = new SoundPlayer();

        public void sobreBoton()
        {
            if (efecto.SoundLocation != "./Sonidos/sobreBoton.wav")
            {
                efecto.SoundLocation = "./Sonidos/sobreBoton.wav";
                efecto.Load();
                efecto.Play();
            }
            else
            {
                efecto.Play();
            }
        }

        public void clickBoton()
        {
            if (efecto.SoundLocation != "./Sonidos/clickBoton.wav")
            {
                efecto.SoundLocation = "./Sonidos/clickBoton.wav";
                efecto.Load();
                efecto.Play();
            }
            else
            {
                efecto.Play();
            }
        }

        public void pasos()
        {
            if (efecto.SoundLocation != "./Sonidos/pasos.wav")
            {
                efecto.SoundLocation = "./Sonidos/pasos.wav";
                efecto.Load();
                efecto.Play();
            }
            else
            {
                efecto.Play();
            }
        }

        public void choque()
        {
            if (efecto.SoundLocation != "./Sonidos/Error.wav")
            {
                efecto.SoundLocation = "./Sonidos/Error.wav";
                efecto.Load();
                efecto.Play();
            }
            else
            {
                efecto.Play();
            }
        }
    }
}
