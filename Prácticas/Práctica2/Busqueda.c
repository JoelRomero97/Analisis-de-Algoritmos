#include <stdio.h>
#include <stdlib.h>
#include "Funciones/funciones.c"

int main(int argc, char const *argv[])
{
	if (argc < 4)
	{
		printf("Hacen falta argumentos\n");
		exit(1);
	}
	int n = atoi(argv[1]); 										//Tamaño del arreglo
	int AlgoritmoBusqueda = atoi (argv [2]);					//Algoritmo seleccionado
	int NumeroBuscar = atoi (argv [3]);							//Numero que se desea buscar
	SeleccionarAlgoritmo (n, AlgoritmoBusqueda, NumeroBuscar);
	return 0;
}