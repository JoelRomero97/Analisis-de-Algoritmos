#include <stdio.h>
#include "Funciones/funciones.c"

int main(int argc, char const *argv[])
{
	int n, algoritmo;
	if (argc < 3)
		printf("Error, faltan argumentos.\n");
	else
	{
		n = atoi (argv [1]);
		algoritmo = atoi (argv [2]);
	}
	seleccionarAlgoritmo (algoritmo, n);
	return 0;
}