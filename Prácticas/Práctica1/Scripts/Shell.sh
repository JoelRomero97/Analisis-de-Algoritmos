#!/bin/bash
 
echo Ejecutando Algoritmo Shell

#Shell

cd /home/joel/Escritorio
gcc Ordenamiento.c -o Ordenamiento

./Ordenamiento 100 5 >> AnalizadorTiempos.txt

./Ordenamiento 1000 5 >> AnalizadorTiempos.txt

./Ordenamiento 5000 5 >> AnalizadorTiempos.txt

./Ordenamiento 10000 5 >> AnalizadorTiempos.txt

./Ordenamiento 50000 5 >> AnalizadorTiempos.txt

./Ordenamiento 100000 5 >> AnalizadorTiempos.txt

./Ordenamiento 200000 5 >> AnalizadorTiempos.txt

./Ordenamiento 400000 5 >> AnalizadorTiempos.txt

./Ordenamiento 600000 5 >> AnalizadorTiempos.txt

./Ordenamiento 800000 5 >> AnalizadorTiempos.txt

./Ordenamiento 1000000 5 >> AnalizadorTiempos.txt

./Ordenamiento 2000000 5 >> AnalizadorTiempos.txt

./Ordenamiento 3000000 5 >> AnalizadorTiempos.txt

./Ordenamiento 4000000 5 >> AnalizadorTiempos.txt

./Ordenamiento 5000000 5 >> AnalizadorTiempos.txt

./Ordenamiento 6000000 5 >> AnalizadorTiempos.txt

./Ordenamiento 7000000 5 >> AnalizadorTiempos.txt

./Ordenamiento 8000000 5 >> AnalizadorTiempos.txt

./Ordenamiento 9000000 5 >> AnalizadorTiempos.txt

./Ordenamiento 10000000 5 >> AnalizadorTiempos.txt

cd /home/joel/Escritorio/Scripts

chmod 777 ArbolBusqueda.sh

./ArbolBusqueda.sh














