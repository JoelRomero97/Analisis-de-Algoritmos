#include "Lista.c"
#include <stdio.h>
#include <stdlib.h>

#define TAM_ALPHABET 26

//Función para imprimir el elemento de la lista con base en mi estructura elemento
void ImprimeLista(lista *l);

int main (void)
{
	lista mi_lista; //Mi lista 
	posicion pos;	//Posición auxiliar para manejar la lista
	elemento e;		//Elemento e
	int i;			//Para manejar los ciclos
	Initialize(&mi_lista); //Inicializar la lista
	
	//Insertar 30 elementos al frente o atras de la lista "Caracteres 'A', 'B', 'C', ..."
	for(i=0;i<TAM_ALPHABET;i++)
	{
		//Llenar el elemento
		e.c='A'+i;

		//Insertar al final de la lista
		Add(&mi_lista,e);
	}
	
	//Ver la lista******************
	printf("\nLista Inicial");
	ImprimeLista(&mi_lista);

	//Eliminar el primero de la lista
	pos=First(&mi_lista);
	Remove(&mi_lista,pos);		

	//Eliminar el ultimo de la lista
	pos=Final(&mi_lista);
	Remove(&mi_lista,pos);		

	//Ver la lista
	printf("\nLista despues de eliminar al primero y al ultimo");
	ImprimeLista(&mi_lista);


	//Remover al elemento 10 de la lista si existe
	pos=First(&mi_lista);
	for(i=1;i<10;i++)
	{
		pos = Following(&mi_lista,pos);
	}	
	
	if(ValidatePosition(&mi_lista,pos))
		Remove(&mi_lista,pos);
	
	//Ver la lista
	printf("\nLista despues de remover al elemento 10 de la lista si existe");
	ImprimeLista(&mi_lista);

	//Remover al elemento 5 de la lista si existe
	e=Element(&mi_lista,5);
	printf("\nEl elemento 5 es:\t%c",e.c);	

	pos=ElementPosition(&mi_lista,5);
	if(ValidatePosition(&mi_lista,pos))
		Remove(&mi_lista,pos);

	//Ver la lista
	printf("\nLista despues de remover al elemento 5 de la lista si existe");
	ImprimeLista(&mi_lista);
	
	//Ver la lista después de eliminarla
	Destroy(&mi_lista);
	ImprimeLista(&mi_lista);
	return 0;
}

//Función para imprimir el elemento de la lista con base en mi estructura elemento
void ImprimeLista(lista *l)
{
	elemento e;
	int i,num_elem;
	num_elem = Size(l);
	if(num_elem>0)
	{
		//Mientras la posición sea valida
		for(i = 1; i <= num_elem; i++)
		{
			e = Element(l,i);
			printf("\nElemento %d\t%c", i, e.c);
		}
	}else
	{
		printf("\nLista Vacia");
	}
	return;	
}