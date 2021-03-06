clc

%%VALORES DE X
x=[100 1000 5000 10000 50000 100000 200000 400000 600000 800000 1000000 2000000 3000000];
 
%%VALORES DE Y = F(x)
y=[0.0000548363 0.0037639141 0.0721418858 0.1217761040 2.8687360287 11.2186019421 44.5749659538 178.3393950462 449.9961271286 716.2357299328 1274.4558458328 5533.8197259903 12870.9760580063];

%%OBTENER UN POLINOMIO QUE SE AJUSTE A LOS PUNTOS X Y Y
n=3; 				%%GRADO DEL POLINOMIO DE AJUSTE
p=polyfit(x,y,n)	%%FUNCION QUE REALIZA EL AJUSTE POLINOMIAL

%%SE CREA UN ESPACIO PARA REALIZAR UNA GRAFICA EN 
%%DONDE SE COMPARA LA CURVA AJUSTADA CONTRA LOS 
%%VALORES EXPERIMENTALES
xi=linspace(0.72,1.45,1000);	%%ESPACIO DE PUNTOS PARA Xi
z=polyval(p,xi);				%%EVALUACION DEL POLINOMIO P EN EL ESPACIO Xi

%%SE REALIZA LA FIGURA CORRESPONDIENTE
figure(1);
plot(x,y,'go-',xi,z,'-'),grid;
ylabel('Segundos');
xlabel('Numeros a ordenar');
title('Ajuste de minimos cuadrados (Seleccion)');
