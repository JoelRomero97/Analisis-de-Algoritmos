#include <stdlib.h>
#include <stdio.h>
#include "Frecuencia.h"
#include "../Lista/Lista.c"

/*
	void codificar_archivo (char * archivo, char * nuevo)
	Descripción: Función principal del proceso de la codificación que manda a llamar al resto de las funciones
	Recibe: Dos apuntadores a char que contienen el nombre del archivo a codificar y el archivo que se va a crear
	Regresa: Apuntador al archivo que se abrió en modo binario
*/
void codificar_archivo (char * archivo, char * nuevo)
{
	FILE * descriptor;
	unsigned char caracter;
	int i, num_elem;
	lista list;
	elemento e;
	posicion pos;
	Initialize (&list);													//Se inicializa la lista
	descriptor = abre_archivo_original (archivo);						//Se abre el archivo en modo binario
	while (!feof (descriptor))
	{
		fread (&caracter, sizeof (char), 1, descriptor);
		e.c = caracter;
		
		//Obtenemos la posición del elemento que tenga el caracter leído
		pos = busca_elemento (&list, e);
		if (pos != NULL)												//Si el caracter leído ya se había leído antes
		{
			//Aumentamos la frecuencia de ese caracter que ya había aparecido
			(pos -> e).frecuencia ++;
		}else															//Si el caracter leído no se había insertado
		{
			e.frecuencia = 1;											//Inicializamos la frecuencia en 1
			Add (&list, e);												//Se agrega el elemento al final de la lista
		}
	}
	//Ya que tenemos la lista con todos los elementos y la frecuencia, los ordenamos para hacer la creación de nodos en el árbol
	imprimir_lista (&list);												//Imprimimos todos los caracteres que aparecieron con su frecuencia
}

/*
	FILE * abre_archivo_original (char * archivo)
	Descripción: Abre el nombre del archivo que se desea codificar y regresa un apuntador al inicio del mismo
	Recibe: Un apuntador a char que contiene el nombre del archivo a codificar
	Regresa: Apuntador al archivo que se abrió en modo binario
*/
FILE * abre_archivo_original (char * archivo)
{
	FILE * descriptor;
	descriptor = fopen (archivo, "rb");
	if (descriptor == NULL)
	{
		printf ("\n\nOcurrio un error al intentar abrir el archivo '%s'\n\n", archivo);
		exit (0);
	}
	return descriptor;
}
