using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsExercício2
{
    class Quadrado
    {
        double lado;
        double area;

        public Quadrado()
        {
            this.lado = 0;
        }

        public Quadrado(double lado)
        {
            this.lado = lado;
        }

        public void SetLado(double lado)
        {
            this.lado = lado;
        }

        public double GetLado()
        {
            return this.lado;
        }

        public double GetArea()
        {
            return this.area;
        }

        public double CalcularArea()
        {
            this.area = this.lado * this.lado;
            return this.area;
        }

    }
}
