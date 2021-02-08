using System;

class Teste{

        interface AreaCalculavel
        {
        double calcularArea();
        }

        class Quadrado : AreaCalculavel
        {
            public double Lado;


            public Quadrado(double lado)
            {
                Lado = lado;
            }


            double AreaCalculavel.calcularArea()
            {
                return Lado * Lado;
            }
        }
       
        class Retangulo : AreaCalculavel
        {
            public double Largura;
            public double Altura;
            

            public Retangulo(double altura, double largura)
            {
                Largura = largura;
                Altura = altura;
            }

            double AreaCalculavel.calcularArea()
            {
                return Largura * Altura;
            }
        }

        class Circulo : AreaCalculavel
        {
            public double R;
            private double PI = 3.1416;

            public Circulo(double r){
                R  = r;
            }

            double AreaCalculavel.calcularArea()
            {
                return PI*(R*R);
            }
        }
            
        Console.Writeline (AreaCalculavel,Quadrado(5));
        Console.Writeline (AreaCalculavel,Retangulo(5,3));
        Console.Writeline (AreaCalculavel,Circulo(5));
        
}
