clc

%%VALORES DE X
x =[100 1000 5000 10000 50000 100000 200000 400000 600000 800000 1000000 2000000 3000000 4000000 5000000 6000000 7000000 8000000 9000000 10000000];
 
%%VALORES DE Y = F(x) = Algoritmo de busqueda
lineal = [0.0000059605 0.0000069141 0.0000200272 0.0000360012 0.0000510216 0.0000538826 0.0000529289 0.0000500679 0.0000839233 0.0000519753 0.0000541210 0.0000548363 0.0000519753 0.0000519753 0.0000548363 0.0000531673 0.0000510216 0.0000531673 0.0000531673 0.0000550747];
binaria = [0.0000059605 0.0000040531 0.0000131130 0.0000069141 0.0000100136 0.0000090599 0.0000100136 0.0000240803 0.0000109673 0.0000100136 0.0000100136 0.0000140667 0.0000109673 0.0000140667 0.0000131130 0.0000431538 0.0000100136 0.0000150204 0.0000128746 0.0000119209];
arbol = [0.0000090599 0.0000300407 0.0001220703 0.0002429485 0.0014050007 0.0036268234 0.0099599361 0.0246081352 0.0417649746 0.0563118458 0.0757768154 0.0017929077 0.0029718876 0.0041809082 0.0055239201 0.0068159103 0.0081989765 0.0095999241 0.0112879276 0.0133268833];

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
