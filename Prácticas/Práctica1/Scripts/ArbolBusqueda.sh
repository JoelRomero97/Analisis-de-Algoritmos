#!/bin/bash
 
echo Ejecutando Algoritmo Arbol de Busqueda

#Arbol Busqueda

cd /home/joel/Escritorio
gcc Ordenamiento.c -o Ordenamiento

./Ordenamiento 100 6 >> AnalizadorTiempos.txt
./Ordenamiento 1000 6 >> AnalizadorTiempos.txt
./Ordenamiento 5000 6 >> AnalizadorTiempos.txt
./Ordenamiento 10000 6 >> AnalizadorTiempos.txt
./Ordenamiento 50000 6 >> AnalizadorTiempos.txt
./Ordenamiento 100000 6 >> AnalizadorTiempos.txt
./Ordenamiento 200000 6 >> AnalizadorTiempos.txt
./Ordenamiento 400000 6 >> AnalizadorTiempos.txt
./Ordenamiento 600000 6 >> AnalizadorTiempos.txt
./Ordenamiento 800000 6 >> AnalizadorTiempos.txt
./Ordenamiento 1000000 6 >> AnalizadorTiempos.txt
./Ordenamiento 2000000 6 >> AnalizadorTiempos.txt
./Ordenamiento 3000000 6 >> AnalizadorTiempos.txt
./Ordenamiento 4000000 6 >> AnalizadorTiempos.txt
./Ordenamiento 5000000 6 >> AnalizadorTiempos.txt
./Ordenamiento 6000000 6 >> AnalizadorTiempos.txt
./Ordenamiento 7000000 6 >> AnalizadorTiempos.txt
./Ordenamiento 8000000 6 >> AnalizadorTiempos.txt
./Ordenamiento 9000000 6 >> AnalizadorTiempos.txt
./Ordenamiento 10000000 6 >> AnalizadorTiempos.txt