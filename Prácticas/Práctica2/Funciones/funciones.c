#include <stdio.h>
#include <stdlib.h>
#include "funciones.h"
//#include "../Arbol/Arbol.c"
#include "../MedirTiempo/tiempo.c"
#include <string.h>

int i, contador;
double utime0, stime0, wtime0, utime1, stime1, wtime1;

void SeleccionarAlgoritmo (int n, int AlgoritmoBusqueda, int NumeroBuscar)
{
	int * numeros = (int *) malloc (sizeof (int) * n);
	numeros = LecturaArchivo (numeros, n);
	switch (AlgoritmoBusqueda)
	{
		case 1: 
				BusquedaLineal (numeros, n, NumeroBuscar);
				break;
		case 2: 
				BusquedaBinaria (numeros, n, NumeroBuscar);
				break;
		/*case 3: 
				BusquedaArbol (numeros, n, NumeroBuscar);
				break;*/
		default: 
				printf ("Opcion Incorrecta\n");
				 exit (0);
	}
}

int * LecturaArchivo (int * numeros, int n)
{
	FILE * numerosOrdenados;
	numerosOrdenados = fopen ("numerosOrdenados.txt", "r");
	if (numerosOrdenados == NULL)
	{
		printf("Error al abrir el archivo\n");
		exit(1);
	}
	else
	{
		for (i = 0; i < n; i ++)
			fscanf (numerosOrdenados, "%d", &numeros [i]);
		numeros [i] = '\0';
		fclose (numerosOrdenados);
		return numeros;
	}
}

void BusquedaLineal (int * numeros, int n, int NumeroBuscar)
{
	contador = 0;
	uswtime (&utime0, &stime0, &wtime0);
	for (i = 0; i < n; i ++)
	{
		if (numeros[i] == NumeroBuscar)
		{
			printf("Numero %d LOCALIZADO\n", NumeroBuscar);
			contador ++;
		}
	}
	if (contador == 0)
			printf("Numero %d NO LOCALIZADO\n",NumeroBuscar);
	uswtime (&utime1, &stime1, &wtime1);
	calculaTiempo (utime0, stime0, wtime0, utime1, stime1, wtime1, n, 1, NumeroBuscar);
}

void BusquedaBinaria (int * numeros, int n, int NumeroBuscar)
{
	int inferior = 0, superior = n;
	i = 0;
	contador = 0;
	uswtime (&utime0, &stime0, &wtime0);
	while ((inferior <= superior) && (i < n))
	{
		mitad = ((inferior + superior) / 2);
		if(numeros [mitad] == NumeroBuscar)
		{
			printf("Numero %d LOCALIZADO\n", NumeroBuscar);
			contador ++;
		}else if (numeros [mitad] > NumeroBuscar)
		{
			superior = mitad;
			mitad = ((inferior + superior) / 2);
		}else
		{
			inferior = mitad;
			mitad = ((inferior + superior) / 2);
		}
		i++;
	}
	if (contador == 0)
		printf("Numero %d NO LOCALIZADO\n", NumeroBuscar);
	uswtime(&utime1, &stime1, &wtime1);
	calculaTiempo (utime0, stime0, wtime0, utime1, stime1, wtime1, n, 2, NumeroBuscar);
}

void calculaTiempo (double utime0, double stime0, double wtime0, double utime1, double stime1, double wtime1, int n, int AlgoritmoBusqueda, int NumeroBuscar)
{
	char * algorithm = (char *) malloc (sizeof (char));
	switch (AlgoritmoBusqueda)
	{
		case 1:
			strcpy (algorithm, "Linear Search");
			break;
		case 2:
			strcpy (algorithm, "Binary Search");
			break;
		case 3:
			strcpy (algorithm, "Binary Search Tree");
			break;
	}
	printf("Time with %s algorithm searching the number '%d' with n = %d\n\n", algorithm, NumeroBuscar, n);
	printf("Tiempo total:  %.10f s\n",  wtime1 - wtime0);
	printf("Tiempo de procesamiento en CPU: %.10f s\n",  utime1 - utime0);
	printf("Tiempo en acciónes de E/S:  %.10f s\n",  stime1 - stime0);
	printf("CPU/Wall:   %.10f %% \n",100.0 * (utime1 - utime0 + stime1 - stime0) / (wtime1 - wtime0));
	printf("\n\n");
	
	//Mostrar los tiempos en formato exponecial
	printf("Tiempo total:  %.10e s\n",  wtime1 - wtime0);
	printf("Tiempo de procesamiento en CPU: %.10e s\n",  utime1 - utime0);
	printf("Tiempo en acciónes de E/S:  %.10e s\n",  stime1 - stime0);
	printf("CPU/Wall:   %.10f %% \n",100.0 * (utime1 - utime0 + stime1 - stime0) / (wtime1 - wtime0));
	printf("\n\n\n\n");
}