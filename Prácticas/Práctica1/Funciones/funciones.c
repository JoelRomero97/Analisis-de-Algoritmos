#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "../Arbol/Arbol.c"
#include "../MedirTiempo/tiempo.c"
#include "funciones.h"

int i, j, temp;																//Variables globales para manejar los ciclos y temporal
double utime0, stime0, wtime0,utime1, stime1, wtime1;						//Variables para medir el tiempo

void seleccionarAlgoritmo (int algoritmo, int n)
{
	int * numeros = (int *) malloc (sizeof (int) * n);						//Creamos un arreglo dinámico de tamaño n para los numeros
	numeros = leerArchivo (numeros, n);										//Obtenemos los n numeros en un arreglo dinamico
	switch (algoritmo)
	{
		case 1:
			BurbujaSimple (numeros, n);										//Ordenamos los numeros con el primer algoritmo
			break;
		case 2:
			BurbujaOptimizada (numeros, n);									//Ordenamos los numeros con el segundo algoritmo
			break;
		case 3:
			Insercion (numeros, n);											//Ordenamos los numeros con el tercer algoritmo
			break;
		case 4:
			Seleccion (numeros, n);											//Ordenamos los numeros con el cuarto algoritmo
			break;
		case 5:
			Shell (numeros, n);												//Ordenamos los numeros con el quinto algoritmo
			break;
		case 6:
			ArbolBinario (numeros, n);										//Ordenamos los numeros con el sexto algoritmo
			break;
		default:
			printf("Opción invalida.\n\n");
			exit (0);
	}
}

int * leerArchivo (int * numeros, int n)
{
	FILE * archivo;
	archivo = fopen ("numeros.txt", "r");									//Abrimos el archivo de numeros para lectura
	if (archivo == NULL)
	{
		printf("Error al abrir el archivo con los numeros desordenados .\n\n\n");
		exit (0);
	}
	for (i = 0; i < n; i ++)
		fscanf (archivo, "%d", &numeros [i]);								//Guardamos los n numeros en un arreglo dinamico
	numeros [i] = '\0';
	fclose (archivo);
	return numeros;
}

void BurbujaSimple (int * numeros, int n)
{
	uswtime(&utime0, &stime0, &wtime0);										//Comenzamos a tomar el tiempo del algoritmo
	for (i = 1; i < n; i ++)
		for (j = 0; j < (n - 1); j ++)
		{
			if (numeros [j] > numeros [j + 1])
			{
				temp = numeros [j];
				numeros [j] = numeros [j + 1];
				numeros [j + 1] = temp;
			}
		}
	uswtime(&utime1, &stime1, &wtime1);										//Terminamos de tomar el tiempo del algoritmo
	calculaTiempo (utime0, stime0, wtime0, utime1, stime1, wtime1, n, 1);	//Calculamos el tiempo del algoritmo y lo mostramos
	numerosOrdenados (numeros, n);											//Mostramos los numeros ordenados por el algoritmo
}

void BurbujaOptimizada (int * numeros, int n)
{
	char cambios [2] = "si";
	uswtime(&utime0, &stime0, &wtime0);										//Comenzamos a tomar el tiempo del algoritmo
	for (i = 1; ((i < n) && strcmp (cambios, "si") == 0); i ++)
		for (j = 0; j < n; j ++)
		{
			if (numeros [i] < numeros [j])
			{
				temp = numeros [j];
				numeros [j] = numeros [i];
				numeros [i] = temp;
				strcpy (cambios, "si");
			}
		}
	uswtime(&utime1, &stime1, &wtime1);										//Terminamos de tomar el tiempo del algoritmo
	calculaTiempo (utime0, stime0, wtime0, utime1, stime1, wtime1, n, 2);	//Calculamos el tiempo del algoritmo y lo mostramos
	numerosOrdenados (numeros, n);											//Mostramos los numeros ordenados por el algoritmo
}

void Insercion (int * numeros, int n)
{
	uswtime(&utime0, &stime0, &wtime0);										//Comenzamos a tomar el tiempo del algoritmo
	for (i = 1; i < n; i ++)
	{
		temp = numeros [i];
		j = i - 1;
		while ((numeros [j] > temp) && (j >= 0))
		{
			numeros [j + 1] = numeros [j];
			j --;
		}
		numeros [j + 1] = temp;
	}
	uswtime(&utime1, &stime1, &wtime1);										//Terminamos de tomar el tiempo del algoritmo
	calculaTiempo (utime0, stime0, wtime0, utime1, stime1, wtime1, n, 3);	//Calculamos el tiempo del algoritmo y lo mostramos
	numerosOrdenados (numeros, n);											//Mostramos los numeros ordenados por el algoritmo
}

void Seleccion (int * numeros, int n)
{
	int p;
	uswtime(&utime0, &stime0, &wtime0);										//Comenzamos a tomar el tiempo del algoritmo
	for (i = 0; i < (n - 1); i ++)
	{
		p = i;
		for (j = i + 1; j <= (n - 1); j ++)
		{
			if (numeros [j] < numeros [p])
				p = j;
		}
		if (p != i)
		{
			temp = numeros [p];
			numeros [p] = numeros [i];
			numeros [i] = temp;
		}
	}
	uswtime(&utime1, &stime1, &wtime1);										//Terminamos de tomar el tiempo del algoritmo
	calculaTiempo (utime0, stime0, wtime0, utime1, stime1, wtime1, n, 4);	//Calculamos el tiempo del algoritmo y lo mostramos
	numerosOrdenados (numeros, n);											//Mostramos los numeros ordenados por el algoritmo
}

void Shell (int * numeros, int n)
{
	int k = n / 2;
	uswtime(&utime0, &stime0, &wtime0);										//Comenzamos a tomar el tiempo del algoritmo
	while (k > 0)
	{
		for (i = k; i < n; i ++)
		{
			temp = numeros [i];
			j = i - k;
			while (j >= 0 && numeros [j] > temp)
			{
				numeros [j + k] = numeros [j];
				j -= k;
			}
			numeros [j + k] = temp;
		}
		k /= 2;
	}
	uswtime(&utime1, &stime1, &wtime1);										//Terminamos de tomar el tiempo del algoritmo
	calculaTiempo (utime0, stime0, wtime0, utime1, stime1, wtime1, n, 5);	//Calculamos el tiempo del algoritmo y lo mostramos
	numerosOrdenados (numeros, n);											//Mostramos los numeros ordenados por el algoritmo
}

void ArbolBinario (int *numeros,int n)
{
	uswtime(&utime0, &stime0, &wtime0);									//Comenzamos a tomar el tiempo del algoritmo
	numeros = InsertarABB(numeros,n);
	uswtime(&utime1, &stime1, &wtime1);									//Terminamos de tomar el tiempo del algoritmo											//Ordenamos y mostramos los numeros ordenados por el algoritmo
	calculaTiempo (utime0, stime0, wtime0, utime1, stime1, wtime1, n, 6);	//Calculamos el tiempo del algoritmo y lo mostramos
	numerosOrdenados (numeros, n);
}

void calculaTiempo (double utime0, double stime0, double wtime0, double utime1, double stime1, double wtime1, int n, int algoritmo)
{
	char * algorithm = (char *) malloc (sizeof (char));
	switch (algoritmo)
	{
		case 1:
			strcpy (algorithm, "Simple Bubble Sort");
			break;
		case 2:
			strcpy (algorithm, "Optimized Bubble Sort");
			break;
		case 3:
			strcpy (algorithm, "Insertion Sort");
			break;
		case 4:
			strcpy (algorithm, "Selection Sort");
			break;
		case 5:
			strcpy (algorithm, "Shell Sort");
			break;
		case 6:
			strcpy (algorithm, "Binary Tree Sort");
			break;
	}
	printf("Time with %s algorithm with n = %d\n", algorithm, n);
	printf("\n\n");
	printf("Tiempo total:  %.10f s\n",  wtime1 - wtime0);
	printf("Tiempo de procesamiento en CPU: %.10f s\n",  utime1 - utime0);
	printf("Tiempo en acciónes de E/S:  %.10f s\n",  stime1 - stime0);
	printf("CPU/Wall:   %.10f %% \n",100.0 * (utime1 - utime0 + stime1 - stime0) / (wtime1 - wtime0));
	printf("\n\n");
	
	//Mostrar los tiempos en formato exponecial
	printf("\n\n");
	printf("Tiempo total:  %.10e s\n",  wtime1 - wtime0);
	printf("Tiempo de procesamiento en CPU: %.10e s\n",  utime1 - utime0);
	printf("Tiempo en acciónes de E/S:  %.10e s\n",  stime1 - stime0);
	printf("CPU/Wall:   %.10f %% \n",100.0 * (utime1 - utime0 + stime1 - stime0) / (wtime1 - wtime0));
	printf("\n\n");
}

void numerosOrdenados (int * numeros, int n)
{
	FILE * archivoOrdenado;
	archivoOrdenado = fopen ("numerosOrdenados.txt", "w");
	if (archivoOrdenado == NULL)
	{
		printf("Error al crear el archivo con los %d numeros ordenados \n", n);
		exit (0);
	}
	for (i = 0; i < n; i ++)
		fprintf(archivoOrdenado, "%d\n", numeros [i]);						//Imprimimos el arreglo de numeros
	free (numeros);
	fclose (archivoOrdenado);
}