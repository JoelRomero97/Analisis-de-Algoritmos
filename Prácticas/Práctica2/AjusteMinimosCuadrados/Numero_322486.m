clc

%%VALORES DE X
x =[100 1000 5000 10000 50000 100000 200000 400000 600000 800000 1000000 2000000 3000000 4000000 5000000 6000000 7000000 8000000 9000000 10000000];
 
%%VALORES DE Y = F(x) = Algoritmo de busqueda
lineal = [0.0000050068 0.0000069141 0.0000090599 0.0000109673 0.0000119209 0.0000119209 0.0000109673 0.0000162125 0.0000171661 0.0000159740 0.0000171661 0.0000131130 0.0000162125 0.0000159740 0.0000138283 0.0000169277 0.0000131130 0.0000138283 0.0000150204 0.0000140667];
binaria =[0.0000071526 0.0000059605 0.0000059605 0.0000071526 0.0000069141 0.0000050068 0.0000090599 0.0000150204 0.0000100136 0.0000100136 0.0000119209 0.0000088215 0.0000100136 0.0000100136 0.0000100136 0.0000128746 0.0000131130 0.0000140667 0.0000100136 0.0000100136];
arbol = [0.0000488758 0.0000469685 0.0002789497 0.0004510880 0.0014469624 0.0035879612 0.0099511147 0.0247130394 0.0411710739 0.0594179630 0.0754919052 0.1675100327 0.2640590668 0.3546788692 0.4671590328 0.5556690693 0.6655550003 0.7462921143 0.0008251667 0.0009911060];

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
