using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Viaje
    {
        string nombre;
        Destino origen;
        Destino destino;
        Grafo grafo;
        int cant_horarios;
        List<Horario> horarios = new List<Horario>();

        public Viaje(string nombre, Destino origen, Destino destino)
        {
            this.nombre = nombre;
            this.origen = origen;
            this.destino = destino;
        }

        public Viaje(string nombre, Destino origen, Destino destino, Horario horario)
        {
            this.nombre = nombre;
            this.origen = origen;
            this.destino = destino;
            horarios.Add(horario);
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Destino Origen
        {
            get { return origen; }
            set { origen = value; }
        }

        public Destino Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        public void AddHorario(string tiempo, bool[] frecuencia, Distribucion distribucion)
        {
            Horario horario = new Horario(tiempo, frecuencia, distribucion);
            horarios.Add(horario);
            cant_horarios = horarios.Count;
        }

        public void RemoveHorario(Horario horario)
        {
            if(horario != null)
            {
                horarios.Remove(horario);
                cant_horarios = horarios.Count;
            }
        }

        public List<Horario> ListaHorarios
        {
            get { return horarios; }
        }

        public int CantidadHorarios
        {
            get { return cant_horarios; }
        }

        public Grafo Grafo
        {
            get { return grafo; }
            set { grafo = value; }
        }

        public void CrearGrafo(Grafo grafo, string directorio)
        {
            if(Grafo == null)
            {
                string full_name_rec = directorio + "\\recorridos\\" + Nombre;
                Grafo = new Grafo(full_name_rec, "\\vertices.dat", "\\arcos.dat");
                foreach(Vertice v in grafo.Lista)
                {
                    if(v.Destino != null)
                    {
                       Grafo.AgregarVertice(v.Destino);
                    }
                }
                //Grafo.Guardar();
            }
        }
        public void EliminarGrafo()
        {
            if(Grafo != null)
            {

            }
        }

    }
}
