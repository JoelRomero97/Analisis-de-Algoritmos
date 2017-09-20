/*TAD Arbol binario
ESTRUCTURAS DE DATOS 1CM7
ABRIL 2017
*/
#include <stdlib.h>
#include "Arbol.h"


int * InsertarABB (int * numeros, int n)
{
	arbolBinario *miRaiz; //Se declara la Ra�z de arbolBinario
	miRaiz = (arbolBinario *) malloc (sizeof(arbolBinario)); //Se reserva espacio de memoria para la variable 
	miRaiz = NULL;
	for (int i = 0; i < n; ++i)
		Insertar(&miRaiz,numeros[i]);
	numeros = Inorden(miRaiz,numeros);
}

void Insertar(arbolBinario **Raiz,int DatoRecibido)
{
	arbolBinario **Auxiliar = NULL; //Se crea un nodo auxiliar
	Auxiliar = Raiz; //Se iguala el auxiliar numeros la raiz
	if (*Raiz == NULL) // si no hay dato se crea un nodo nuevo
		*Raiz = InicializarArbol(DatoRecibido);
	else
	{
		while(*Auxiliar != NULL) //Hasta que se encuentra el nodo vacio
		{
			if (DatoRecibido < (*Auxiliar)->dato) // Si el numero a ingresar es menor en Auxiliar
				Auxiliar = &((*Auxiliar)->izq); // Se va al nodo izquierdo
			else if (DatoRecibido > (*Auxiliar)->dato) //Si el numero a ingresar es mayor en Auxiliar
				Auxiliar = &((*Auxiliar)->der); //Se va al nodo derecho
		}
		*Auxiliar = InicializarArbol (DatoRecibido);// Ya se llego a la posicion adecuada, agrega el nuevo nodo
	}
}


/*
recibe<-�rbol(A), posici�n (P);
Inorden (A,P)
Efecto: Recibe un �rbol binario A y una posici�n P, realiza el recorrido izquierdo -> raiz -> derecho a partir de la posicion P.
Requerimientos: El �rbol binario A es no vac�o y la posici�n P es una posici�n valida.
*/
int * Inorden (arbolBinario * Raiz, int *numeros)
{
	int i = 0;
	arbolBinario *Auxiliar,*Recorrido;
	Auxiliar = Raiz;
	while (Auxiliar !=NULL)
	{
		if (Auxiliar->izq == NULL)
		{
			numeros[i] = Auxiliar->dato;
			Auxiliar = Auxiliar->der;
			i++;
		}
		else
		{
			Recorrido = Auxiliar->izq;
			while(Recorrido->der !=NULL && Recorrido->der != Auxiliar)
				Recorrido = Recorrido->der;
			if(Recorrido->der == NULL)
			{
				Recorrido->der = Auxiliar;
				Auxiliar = Auxiliar->izq;
			}
			else
			{
				Recorrido->der = NULL;
				numeros[i] = Auxiliar->dato;
				Auxiliar = Auxiliar->der;
				i++;
			}
		}
	}
	return numeros;
}



arbolBinario * InicializarArbol (int numDato)
{
	arbolBinario *A = malloc(sizeof(nodo)); //Se reserva memoria paara el arbol
	A->dato= numDato;
	A->izq=NULL;  //Sin nodo izquierdo
	A->der=NULL; //Sin nodo derecho
	return A;
}
