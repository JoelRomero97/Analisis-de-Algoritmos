#define TRUE 1
#define FALSE 0


typedef struct nodo
{
	struct nodo *izq, *der;
	int dato;
}nodo;

typedef nodo arbolBinario;


int * InsertarABB(int *numeros, int n);
/*
recibe<-�rbol(A), elemento (E);
InsertarABB (A, E);
Efecto: Recibe un �rbol binario A y un elemento E, compara si E es menor o mayor a la raiz, si E es menor lo inserta a la izquierda, y si es
mayor inserta a E a la derecha.
Requerimientos: El �rbol binario A es no vac�o y el elemento E tiene un numero a ser comparado.
*/


void Insertar(arbolBinario **Raiz,int DatoRecibido);


arbolBinario * InicializarArbol (int numDato);
/*
recibe<-�rbol(A); 
Initialize (A)
Efecto: Recibe un �rbol binario A y lo inicializa para su trabajo normal.
*/


int * Inorden (arbolBinario *Raiz, int *numeros);
/*
recibe<-�rbol(A), posici�n (P);
Inorden (A,P)
Efecto: Recibe un �rbol binario A y una posici�n P, realiza el recorrido izquierdo -> raiz -> derecho a partir de la posicion P.
Requerimientos: El �rbol binario A es no vac�o y la posici�n P es una posici�n valida.
*/
