/*TAD Arbol binario
ESTRUCTURAS DE DATOS 1CM7
ABRIL 2017
*/
#include <stdlib.h>
#include "Arbol.h"


/*
recibe<-árbol(A); 
InicializarArbol (A)
Efecto: Recibe un árbol binario A y lo inicializa para su trabajo normal.
*/
void InicializarArbol (arbolBinario * A)
{
	*A = NULL;
	return;
}

/*
recibe<-árbol(A); 
Elimina (A)
Efecto: Recibe un árbol binario A y lo libera completamente.
*/
void Elimina (arbolBinario * A)
{
	if(*A == NULL)
		return;
	else
	{
		if ((*A) -> izq != NULL)
			Elimina (&((*A) -> izq));
		if ((*A) -> der != NULL)
			Elimina (&((*A) -> der));
		free (*A);
		return;
	}
}

/*
recibe<-árbol(A); retorna -> posición
Raiz (A)
Efecto: Recibe un árbol binario A y retorna la posición de la raíz de A, si el árbol es vacío devuelve una posición nula.
*/
posicion Raiz (arbolBinario * A)
{
	return * A;
}


/*
recibe<-árbol(A), posición(P); retorna -> posición
Padre (A,P)
Efecto: Recibe un árbol binario  A y una posición P, devuelve la posición de padre de p. 
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida. Si P es la raíz se devuelve una posición nula.
*/
posicion Padre (arbolBinario * A, posicion p)
{
	posicion r = NULL;
	if (*A == NULL || *A == p)
		return NULL;
	else if ((*A) -> izq == p || (*A) -> der == p)
		return * A;
	else 
	{
		r = Padre (&((*A) -> izq), p);
		if(r == NULL)
			r = Padre (&((*A) -> der), p);
		return r;
	}
}

/*
recibe<-árbol(A), posición(P); retorna -> posición
HijoDerecho (A,P)
Efecto: Recibe un árbol binario A y una posición P, devuelve la posición del hijo derecho de p. 
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida. Si P no tiene hijo derecho devuelve una posición nula.
*/
posicion HijoDerecho (arbolBinario * A, posicion P)
{
	posicion r = NULL;
	if (!PosicionNula (A, P))
		r = P -> der;
	return r;
}

/*
recibe<-árbol(A), posición(P); retorna -> posición
HijoIzquierdo (A,P)
Efecto: Recibe un árbol binario A y una posición P, devuelve la posición del hijo izquierdo de p. 
Requerimientos: El árbol A es no vacío y la posición P es una posición valida. Si P no tiene hijo izquierdo devuelve una posición nula.
*/
posicion HijoIzquierdo (arbolBinario * A, posicion P)
{
	posicion r = NULL;
	if (!PosicionNula (A, P))
		r = P -> izq;
	return r;
}


/*
recibe<-árbol(A), elemento (E); retorna -> posición
BuscaPosicion (A,E)
Efecto: Recibe un árbol binario A y un elemento E, devuelve la posición del elemento E en el árbol  A.
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida. Si E no es encontrado devuelve una posición nula.
*/
posicion BuscaPosicion (arbolBinario * A, elemento e)
{
	
	posicion r = NULL;
	if(* A == NULL)
		return NULL;
	else if (memcmp (&((* A) -> e), &e,sizeof (elemento)) == 0)
		return * A;
	else 
	{
		r = BuscaPosicion (&((*A) -> izq), e);
		if (r == NULL)
			r = BuscaPosicion (&((*A) -> der), e);
		return r;
	}
}

/*
recibe<-árbol(A); retorna -> booleano
Vacio (A)
Efecto: Recibe un árbol binario A y devuelve verdadero en caso de que el árbol A este vacío, devuelve falso en caso contrario.
*/
boolean Vacio (arbolBinario * A)
{
	boolean r;
	if(* A == NULL)
		r = TRUE;
	else 
		r = FALSE;
	return r;
}

/*
recibe<-árbol(A), posición (P); retorna -> booleano
PosicionNula (A,P)
Efecto: Recibe un árbol binario A y una posición P, devuelve verdadero si la posición P del árbol A es nula o incorrecta y devuelve falso en 
caso contrario.
*/
boolean PosicionNula (arbolBinario * A, posicion p)
{
	boolean r;
	if (* A == NULL)
		return TRUE;
	else if (* A == p)
		return FALSE;
	else 
	{
		r = PosicionNula (&((* A) -> izq), p);
		if(r == TRUE)
			r = PosicionNula (&((* A) -> der), p);
		return r;
	}
}

/*
recibe<-árbol(A), posición (P); retorna -> elemento
BuscaElemento (A,P)
Efecto: Recibe un árbol binario A y una posición P, devuelve el elemento en la posición P del árbol A.
Requerimientos: El árbol A es no vacío y la posición P es una posición valida..
*/
elemento BuscaElemento (arbolBinario * A, posicion p)
{
	elemento r;
	if (!PosicionNula (A, p))
		r = p -> e;
	else
	{
		printf ("Error: BuscaElemento");
		exit (1);
	}
	return r;
}

/*
recibe<-árbol(A), posición (P), elemento E; 
NuevoHijoDerecho (A,P,E)
Efecto: Recibe un árbol binario A, una posición P y un elemento E, se añade un nodo que contenga E como hijo derecho del nodo con posición P.
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida. Si el árbol A es vacío se agrega a un nodo raíz con E. si P ya tiene un hijo derecho, se cancela la operación.
*/
void NuevoHijoDerecho (arbolBinario * A, posicion p, elemento e)
{
	if (Vacio (A))
	{
		* A = malloc (sizeof (nodo));
		(*A) -> e = e;
		(*A) -> izq = NULL;
		(*A) -> der = NULL;
	}else if (!PosicionNula (A, p))
	{
		if (p -> der != NULL)
		{
			printf ("Error: NuevoHijoDerecho: ya existe");
			exit (1);
		}else
		{
			p -> der = malloc (sizeof (nodo));
			p -> der -> e = e;
			p -> der -> izq = NULL;
			p -> der -> der = NULL;
		}
	}else
	{
		printf("Error: NuevoHijoDerecho ");
		exit(1);
	}
	return;
}

/*
recibe<-árbol(A), posición (P), elemento E; 
NuevoHijoIzquierdo (A,P,E)
Efecto: Recibe un árbol binario A, una posición P y un elemento E, se añade un nodo que contenga E como hijo izquierdo del nodo con posición P.
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida. Si el árbol A es vacío se agrega a un nodo raíz con E; si P ya tiene un hijo Izquierdo, se cancela la operación.
*/
void NuevoHijoIzquierdo (arbolBinario * A, posicion p, elemento e)
{
	if (Vacio (A))
	{
		* A = malloc (sizeof (nodo));
		(*A) -> e = e;
		(*A) -> izq = NULL;
		(*A) -> der = NULL;
	}else if (!PosicionNula (A, p))
	{
		if (p -> izq != NULL)
		{
			printf ("Error: NuevoHijoIzquierdo: ya existe");
			exit (1);
		}else
		{
			p -> izq = malloc (sizeof (nodo));
			p -> izq -> e = e;
			p -> izq -> izq = NULL;
			p -> izq -> der = NULL;
		}
	}else
	{
		printf ("Error: NuevoHijoIzquierdo ");
		exit (1);
	}
	return;
}

/*
recibe<-árbol(A), posición (P);
BorraHijoDerecho (A,P)
Efecto: Recibe un árbol binario A y una posición se elimina al hijo derecho y todos sus descendientes del nodo con posición P.
Requerimientos: El árbol A es no vacío y la posición P es una posición valida y tiene un hijo derecho.
*/
void BorraHijoDerecho (arbolBinario * A, posicion p)
{
	if (!PosicionNula (A, p))
		Elimina (& (p -> der));
	else
	{
		printf ("Error: BorraHijoDerecho ");
		exit (1);
	}
	return;
}

/*
recibe<-árbol(A), posición (P);
BorraHijoIzquierdo (A,P)
Efecto: Recibe un árbol binario A y una posición se elimina al hijo izquierdo y todos sus descendientes del nodo con posición P.
Requerimientos: El árbol A es no vacío y la posición P es una posición valida y tiene un hijo izquierdo.
*/
void BorraHijoIzquierdo (arbolBinario * A, posicion p)
{
	if (!PosicionNula (A, p))
		Elimina (& (p -> izq));
	else
	{
		printf ("Error: BorraHijoIzquierdo ");
		exit (1);
	}
	return;
}


/*
recibe<-árbol(A), posición (P);
BorraNodo (A,P)
Efecto: Recibe un árbol binario A y una posición P, se elimina al nodo con posición P y todos sus descendientes.
Requerimientos: El árbol A es no vacío y la posición P es una posición valida. 
*/
void BorraNodo (arbolBinario * A, posicion p)
{
	if (!PosicionNula (A, p))
		Elimina (&p);
	else
	{
		printf ("Error: Delete");
		exit (1);
	}
	return;
}

/*
recibe<-árbol(A), posición (P), elemento (E);
ReemplazaNodo (A,P, E)
Efecto: Recibe un árbol binario A, una posición P y un elemento E, se remplaza a E del nodo con posición P en A.
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida.
*/
void ReemplazaNodo (arbolBinario * A, posicion p, elemento e)
{
	if (!PosicionNula (A, p))
		p -> e = e;
	else
	{
		printf ("Error: ReemplazaNodo ");
		exit (1);
	}
	return;
}

/*
recibe<-árbol(A), elemento (E);
InsertarABB (A, E);
Efecto: Recibe un árbol binario A y un elemento E, compara si E es menor o mayor a la raiz, si E es menor lo inserta a la izquierda, y si es
mayor inserta a E a la derecha.
Requerimientos: El árbol binario A es no vacío y el elemento E tiene un numero a ser comparado.
*/
void InsertarABB (arbolBinario * A, elemento e)
{
	if (Vacio (A))										//Si el arbol esta vacio creamos un nodo
	{
		* A = malloc (sizeof (nodo));					//Reservamos memoria para un nuevo nodo
		(*A) -> e = e;
		(*A) -> izq = NULL;								//Ponemos el hijo izquierdo a NULL
		(*A) -> der = NULL;								//Ponemos el hijo derecho a NULL
	}else if (e.numero < (*A) -> e.numero)			//Si el elemento insertado es menor a la raiz
		InsertarABB (&((*A) -> izq), e);				//Insertamos el elemento a la izquierda
	else
		InsertarABB (&((*A) -> der), e);				//Si no, lo insertamos a la derecha
}

/*
recibe<-árbol(A), posición (P);
Preorden (A,P)
Efecto: Recibe un árbol binario A y una posición P, realiza el recorrido raíz -> izquierdo -> derecho a partir de la posicion P.
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida.
*/
void Preorden (arbolBinario * a, posicion p)
{
	elemento e;
	if (!PosicionNula (a, p))
	{
		e = BuscaElemento (a, p);
		printf("%d\n", e.numero);
		Preorden (a, HijoIzquierdo (a, p));
		Preorden (a, HijoDerecho (a, p));
	}
	return;
}

/*
recibe<-árbol(A), posición (P);
Inorden (A,P)
Efecto: Recibe un árbol binario A y una posición P, realiza el recorrido izquierdo -> raiz -> derecho a partir de la posicion P.
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida.

void Inorden (arbolBinario * a, posicion p)
{
	elemento e;
	int i = 0;
	if (!PosicionNula (a, p))
	{
		Inorden (a, HijoIzquierdo (a, p));
		e = BuscaElemento (a, p);
		printf("%d\n", e.numero);
		Inorden (a, HijoDerecho (a, p));
	}
	return;
}
*/











/*
recibe<-árbol(A), posición (P);
Inorden (A,P)
Efecto: Recibe un árbol binario A y una posición P, realiza el recorrido izquierdo -> raiz -> derecho a partir de la posicion P.
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida.
*/
void Inorden (arbolBinario * a, posicion p)
{
	elemento e;
	posicion pos;
	int i = 0;
	if (!PosicionNula (a, p))
	{
		pos = HijoIzquierdo (a, p);
		e = BuscaElemento (a, pos);
		printf("%d\n", e.numero);
		pos = HijoDerecho (a, p);
	}
	return;
}






/*
recibe<-árbol(A), posición (P);
Postorden (A,P)
Efecto: Recibe un árbol binario A y una posición P, realiza el recorrido izquierdo -> derecho -> raiz a partir de la posicion P.
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida.
*/
void Postorden (arbolBinario * a, posicion p)
{
	elemento e;
	if (!PosicionNula (a, p))
	{
		Postorden (a, HijoIzquierdo (a, p));
		Postorden (a, HijoDerecho (a, p));
		e = BuscaElemento (a, p);
		printf ("%d\n", e.numero);
	}
	return;
}