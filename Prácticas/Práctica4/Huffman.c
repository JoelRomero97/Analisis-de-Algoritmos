#include <stdio.h>
#include <stdlib.h>
#include "Funciones/Frecuencia.c"
//#include "Arbol/Arbol.c"

int main(int argc, char const *argv[])
{
	char * archivo = (char *) malloc (sizeof (char));					//Nombre del archivo a codificar/decodificar
	char * nuevo = (char *) malloc (sizeof (char));						//Nombre del archivo codificado/decodificado
	int opcion_seleccionada;											//1 para codificar, 2 para decodificar
	system ("cls");
	if (argc < 4)
	{
		printf ("\n\nError al ejecutar: faltan argumentos.\n\n\n");
		printf ("Ejemplo (Codificacion): '%s archivo_original archivo_codificado 1'\n\n", argv [0]);
		printf ("Ejemplo (Decodificacion): '%s archivo_codificado archivo_decodificado 2'\n\n", argv [0]);
		return 0;
	}else
	{
		archivo = (char *) argv [1];
		nuevo = (char *) argv [2];
		opcion_seleccionada = atoi (argv [3]);
	}
	if (opcion_seleccionada == 1)
		codificar_archivo (archivo, nuevo);
	//else if (opcion_seleccionada == 2)
	//	decodificar_archivo (archivo, nuevo);
	//else
	//	printf ("\n\nOpcion invalida :(\n\n");
	return 0;
}
