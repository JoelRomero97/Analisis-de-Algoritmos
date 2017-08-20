#include <stdio.h>
#include "Arbol.c"

void Preorden (arbolBinario *a, posicion p);
void Inorden (arbolBinario *a, posicion p);
void Postorden (arbolBinario *a, posicion p);

int main (void)
{
	arbolBinario a;
	elemento e;
	posicion p;
	
	InicializarArbol (&a);
	e.c = 'A';
	NuevoHijoDerecho (&a, p, e);
	
	p = Raiz (&a);
	
	e.c = 'C';
	NuevoHijoDerecho (&a, p, e);
		
	e.c = 'B';
	NuevoHijoIzquierdo (&a, p, e);
		
	p = HijoDerecho (&a, p);	
	e.c = 'D';
	NuevoHijoIzquierdo (&a, p, e);
	e.c = 'E';
	NuevoHijoDerecho (&a, p, e);
	
	p = Raiz (&a);
	Preorden (&a, p);
	printf("\n");
	Inorden (&a, p);
	printf("\n");
	Postorden (&a, p);
	
	Elimina (&a);
	
	return 0;
}

void Preorden (arbolBinario * a, posicion p)
{
	elemento e;
	if (!PosicionNula (a, p))
	{
		e = BuscaElemento (a, p);
		printf("\t%c", e.c);
		Preorden (a, HijoIzquierdo (a, p));
		Preorden (a, HijoDerecho (a, p));
	}
	return;
}

void Inorden (arbolBinario * a, posicion p)
{
	elemento e;
	if (!PosicionNula (a, p))
	{
		Inorden (a, HijoIzquierdo (a, p));
		e = BuscaElemento (a, p);
		printf("\t%c", e.c);
		Inorden (a, HijoDerecho (a, p));
	}
	return;
}

void Postorden (arbolBinario * a, posicion p)
{
	elemento e;
	if (!PosicionNula (a, p))
	{
		Postorden (a, HijoIzquierdo (a, p));
		Postorden (a, HijoDerecho (a, p));
		e = BuscaElemento (a, p);
		printf ("\t%c", e.c);
	}
	return;
}
