clc

%%VALORES DE X
x =[100 1000 5000 10000 50000 100000 200000 400000 600000 800000 1000000 2000000 3000000 4000000 5000000 6000000 7000000 8000000 9000000 10000000];
 
%%VALORES DE Y = F(x) = Algoritmo de busqueda
lineal = [0.0000038147 0.0000069141 0.0000200272 0.0000331402 0.0000901222 0.0000901222 0.0000948906 0.0000939369 0.0000960827 0.0000989437 0.0000939369 0.0000948906 0.0000970364 0.0000939369 0.0001301765 0.0000939369 0.0000979900 0.0000939369 0.0001292229 0.0000967979];
binaria = [0.0000050068 0.0000040531 0.0000059605 0.0000040531 0.0000050068 0.0000081062 0.0000100136 0.0000109673 0.0000100136 0.0000100136 0.0000128746 0.0000138283 0.0000128746 0.0000100136 0.0000119209 0.0000100136 0.0000150204 0.0000109673 0.0000128746 0.0000140667];
arbol = [0.0000090599 0.0000269413 0.0001177788 0.0002460480 0.0013828278 0.0035839081 0.0103220940 0.0252120495 0.0418388844 0.0598258972 0.0768740177 0.1698181629 0.2719590664 0.3646900654 0.4711470604 0.5679500103 0.0224559307 0.0262031555 0.0322220325 0.0367138386];

%%OBTENER UN POLINOMIO QUE SE AJUSTE A LOS PUNTOS X Y Y
n=3;                                    %%GRADO DEL POLINOMIO DE AJUSTE
polinomioLineal=polyfit(x,lineal,n)     %%FUNCION QUE REALIZA EL AJUSTE POLINOMIAL
polinomioBinario=polyfit(x,binaria,n)   %%FUNCION QUE REALIZA EL AJUSTE POLINOMIAL
polinomioArbol=polyfit(x,arbol,n)       %%FUNCION QUE REALIZA EL AJUSTE POLINOMIAL

%%SE CREA UN ESPACIO PARA REALIZAR UNA GRAFICA EN 
%%DONDE SE COMPARA LA CURVA AJUSTADA CONTRA LOS 
%%VALORES EXPERIMENTALES
xi=linspace(0.72,1.45,100000);                      %%ESPACIO DE PUNTOS PARA Xi
zLineal=polyval(polinomioLineal,xi);				%%EVALUACION DEL POLINOMIO P EN EL ESPACIO Xi
zBinaria=polyval(polinomioBinario,xi);				%%EVALUACION DEL POLINOMIO P EN EL ESPACIO Xi
zArbol=polyval(polinomioArbol,xi);                  %%EVALUACION DEL POLINOMIO P EN EL ESPACIO Xi

%%SE REALIZA LA FIGURA CORRESPONDIENTE
figure(1);

%subplot (Numero_Filas, Numero_Columnas, Numero_Grafica)
subplot (3, 1, 1),plot(x,lineal,'go-',xi,zLineal,'-'),grid, ylabel('Segundos'), xlabel('Tama�o de arreglo'), title('Algoritmo de Busqueda Lineal');
subplot (3, 1, 2),plot(x,binaria,'bo-',xi,zBinaria,'-'),grid, ylabel('Segundos'), xlabel('Tama�o de arreglo'), title('Algoritmo de Busqueda Binaria');
subplot (3, 1, 3),plot(x,arbol,'ro-',xi,zArbol,'-'),grid, ylabel('Segundos'), xlabel('Tama�o de arreglo'), title('Algoritmo Arbol de Busqueda Binaria');
