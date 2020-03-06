using System;

namespace Matrix
{
    class Matrix
    {

        //buneo, esto es lo mejor qu ehe logrado hacer, se que es muy poco, pero ya no se que hacer. 
        //si algo se me ocurre lo implementare (basicamente TO DOES) 6:53 p.m.

        Objeto platano = new Objeto ("Platano", 80, "Pl");
        Objeto cuerda = new Objeto ("cuerda", 1,000, "C");
        Objeto botella = new Objeto ("Botella De Agua", 1,100, "Ba");
        Objeto manzana = new Objeto ("Manzana", 250, "M");
        Objeto pan = new Objeto ("Pan", 70, "P");
        Objeto brujula = new Objeto ("Brujula", 300, "B");
        Objeto papel = new Objeto ("Papel De Baño", 320, "Pb");

        private int[,] grid = new int [,];

        private int gridSize;

            public Matrix(int [,] gridValues, int gridSize)
            {
                this.grid = gridValues;
                this.gridSize = gridSize;
            }

            public void PritnMatrix()
            {
                //iterar filas
                for(int y = 0; y < this.gridSize; y++)
                {
                    for (int x = 0; x < this.gridSize; x++)
                    {   //imprimir
                        Console.Write(grid[y, x]);
                    }

                    Console.WriteLine();
                }
            }

            public  int MexicanStyleMatrix()
            {
                return this.grid[0, 0] + this.grid[1, 1] + this.grid[2, 2] + this.grid[0, 1] 
                     + this.grid[1, 2] + this.grid[2, 0] + this.grid[0, 2] + this.grid[1, 0] 
                     + this.grid[2, 1] + this.grid[0, 2] + this.grid[1, 1] + this.grid[2, 0]
                     + this.grid[0, 0] + this.grid[1, 2] + this.grid[2, 1] + this.grid[0, 1];
            }
    }
}
