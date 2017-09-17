#define TRUE 1
#define FALSE 0

typedef unsigned char boolean;

typedef struct elemento
{
	int numero;
}elemento;

typedef struct nodo
{
	struct nodo *izq, *der;
	elemento e;
}nodo;

typedef nodo * posicion;
typedef posicion arbolBinario;

void InicializarArbol (arbolBinario * A);
/*
recibe<-árbol(A); 
Initialize (A)
Efecto: Recibe un árbol binario A y lo inicializa para su trabajo normal.
*/

void Elimina (arbolBinario * A);
/*
recibe<-árbol(A); 
Elimina (A)
Efecto: Recibe un árbol binario A y lo libera completamente.
*/

posicion Raiz (arbolBinario * A);
/*
recibe<-árbol(A); retorna -> posición
Raiz (A)
Efecto: Recibe un árbol binario A y retorna la posición de la raíz de A, si el árbol es vacío devuelve una posición nula.
*/

posicion Padre (arbolBinario * A, posicion p);
/*
recibe<-árbol(A), posición(P); retorna -> posición
Padre (A,P)
Efecto: Recibe un árbol binario  A y una posición P, devuelve la posición de padre de p. 
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida. Si P es la raíz se devuelve una posición nula.
*/

posicion HijoDerecho (arbolBinario * A, posicion P);
/*
recibe<-árbol(A), posición(P); retorna -> posición
HijoDerecho (A,P)
Efecto: Recibe un árbol binario A y una posición P, devuelve la posición del hijo derecho de p. 
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida. Si P no tiene hijo derecho devuelve una posición nula.
*/

posicion HijoIzquierdo (arbolBinario * A, posicion P);
/*
recibe<-árbol(A), posición(P); retorna -> posición
HijoIzquierdo (A,P)
Efecto: Recibe un árbol binario A y una posición P, devuelve la posición del hijo izquierdo de p. 
Requerimientos: El árbol A es no vacío y la posición P es una posición valida. Si P no tiene hijo izquierdo devuelve una posición nula.
*/

posicion BuscaPosicion (arbolBinario * A, elemento e);
/*
recibe<-árbol(A), elemento (E); retorna -> posición
BuscaPosicion (A,E)
Efecto: Recibe un árbol binario A y un elemento E, devuelve la posición del elemento E en el árbol  A.
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida. Si E no es encontrado devuelve una posición nula.
*/

boolean Vacio (arbolBinario * A);
/*
recibe<-árbol(A); retorna -> booleano
Vacio (A)
Efecto: Recibe un árbol binario A y devuelve verdadero en caso de que el árbol A este vacío, devuelve falso en caso contrario.
*/

boolean PosicionNula (arbolBinario * A, posicion p);
/*
recibe<-árbol(A), posición (P); retorna -> booleano
PosicionNula (A,P)
Efecto: Recibe un árbol binario A y una posición P, devuelve verdadero si la posición P del árbol A es nula o incorrecta y devuelve falso en 
caso contrario.
*/

elemento BuscaElemento (arbolBinario * A, posicion p);
/*
recibe<-árbol(A), posición (P); retorna -> elemento
BuscaElemento(A,P)
Efecto: Recibe un árbol binario A y una posición P, devuelve el elemento en la posición P del árbol A.
Requerimientos: El árbol A es no vacío y la posición P es una posición valida..
*/

void NuevoHijoDerecho (arbolBinario * A, posicion p, elemento e);
/*
recibe<-árbol(A), posición (P), elemento E; 
NuevoHijoDerecho (A,P,E)
Efecto: Recibe un árbol binario A, una posición P y un elemento E, se añade un nodo que contenga E como hijo derecho del nodo con posición P.
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida. Si el árbol A es vacío se agrega a un nodo raíz con E. 
si P ya tiene un hijo derecho, se cancela la operación.
*/

void NuevoHijoIzquierdo (arbolBinario * A, posicion p, elemento e);
/*
recibe<-árbol(A), posición (P), elemento E; 
NuevoHijoIzquierdo (A,P,E)
Efecto: Recibe un árbol binario A, una posición P y un elemento E, se añade un nodo que contenga E como hijo izquierdo del nodo con posición P.
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida. Si el árbol A es vacío se agrega a un nodo raíz con E, 
si P ya tiene un hijo Izquierdo, se cancela la operación.
*/

void BorraHijoDerecho (arbolBinario * A, posicion p);
/*
recibe<-árbol(A), posición (P);
BorraHijoDerecho (A,P)
Efecto: Recibe un árbol binario A y una posición se elimina al hijo derecho y todos sus descendientes del nodo con posición P.
Requerimientos: El árbol A es no vacío y la posición P es una posición valida y tiene un hijo derecho.
*/

void BorraHijoIzquierdo (arbolBinario * A, posicion p);
/*
recibe<-árbol(A), posición (P);
BorraHijoIzquierdo (A,P)
Efecto: Recibe un árbol binario A y una posición se elimina al hijo izquierdo y todos sus descendientes del nodo con posición P.
Requerimientos: El árbol A es no vacío y la posición P es una posición valida y tiene un hijo izquierdo.
*/

void BorraNodo (arbolBinario * A, posicion p);
/*
recibe<-árbol(A), posición (P);
BorraNodo (A,P)
Efecto: Recibe un árbol binario A y una posición P, se elimina al nodo con posición  P  y todos sus descendientes.
Requerimientos: El árbol A es no vacío y la posición P es una posición valida. 
*/

void ReemplazaNodo (arbolBinario * A, posicion p, elemento e);
/*
recibe<-árbol(A), posición (P), elemento (E);
ReemplazaNodo (A,P)
Efecto: Recibe un árbol binario A, una posición P y un elemento E, se remplaza a E del nodo con posición P en A.
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida. 
*/

void InsertarABB(arbolBinario * A, elemento e);
/*
recibe<-árbol(A), elemento (E);
InsertarABB (A, E);
Efecto: Recibe un árbol binario A y un elemento E, compara si E es menor o mayor a la raiz, si E es menor lo inserta a la izquierda, y si es
mayor inserta a E a la derecha.
Requerimientos: El árbol binario A es no vacío y el elemento E tiene un numero a ser comparado.
*/

void BuscarABB (arbolBinario * A, posicion p, int NumeroBuscar);
/*
recibe<-árbol(A), posición (P), int (NumeroBuscar);
BuscarABB (A, E);
Efecto: Recibe un árbol binario A, una posición y un número a buscar, y a partir del número a buscar, los busca dentro
del árbol.
Requerimientos: El árbol binario A es no vacío y la posicion P es una posición válida.
*/

void Preorden (arbolBinario * a, posicion p);
/*
recibe<-árbol(A), posición (P);
Preorden (A,P)
Efecto: Recibe un árbol binario A y una posición P, realiza el recorrido raíz -> izquierdo -> derecho a partir de la posicion P.
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida.
*/

void Inorden (arbolBinario * a, posicion p);
/*
recibe<-árbol(A), posición (P);
Inorden (A,P)
Efecto: Recibe un árbol binario A y una posición P, realiza el recorrido izquierdo -> raiz -> derecho a partir de la posicion P.
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida.
*/

void Postorden (arbolBinario * a, posicion p);
/*
recibe<-árbol(A), posición (P);
Postorden (A,P)
Efecto: Recibe un árbol binario A y una posición P, realiza el recorrido izquierdo -> derecho -> raiz a partir de la posicion P.
Requerimientos: El árbol binario A es no vacío y la posición P es una posición valida.
*/
