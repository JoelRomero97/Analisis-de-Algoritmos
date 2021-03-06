clc

%%VALORES DE X
x =[100 1000 5000 10000 50000 100000 200000 400000 600000 800000 1000000 2000000 3000000 4000000 5000000 6000000 7000000 8000000 9000000 10000000];
 
%%VALORES DE Y = F(x) = Algoritmo de busqueda
lineal = [0.0000038147 0.0000078678 0.0000200272 0.0000350475 0.0001530647 0.0002899170 0.0005879402 0.0011482239 0.0017209053 0.0026638508 0.0028629303 0.0057220459 0.0087909698 0.0166759491 0.0146250725 0.0172300339 0.0201048851 0.0202190876 0.0203809738 0.0201461315];
binaria = [0.0000059605 0.0000050068 0.0000038147 0.0000090599 0.0000121593 0.0000090599 0.0000119209 0.0000090599 0.0000109673 0.0000121593 0.0000140667 0.0000100136 0.0000112057 0.0000097752 0.0000128746 0.0000100136 0.0000109673 0.0000100136 0.0000128746 0.0000112057];
arbol = [0.0000150204 0.0001080036 0.0010390282 0.0025479794 0.0193908215 0.0497169495 0.1700649261 0.4666669369 0.7476551533 1.0288090706 1.3310630322 2.8927481174 4.3603789806 5.9848749638 7.6789641380 9.7891519070 10.2568910122 12.1159861088 13.5789129734 14.6898989677];

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
