#!/bin/bash
 
echo Ejecutando Algoritmo Seleccion

#Seleccion

cd /home/joel/Escritorio
gcc Ordenamiento.c -o Ordenamiento

./Ordenamiento 100 4 >> AnalizadorTiempos.txt

./Ordenamiento 1000 4 >> AnalizadorTiempos.txt

./Ordenamiento 5000 4 >> AnalizadorTiempos.txt

./Ordenamiento 10000 4 >> AnalizadorTiempos.txt

./Ordenamiento 50000 4 >> AnalizadorTiempos.txt

./Ordenamiento 100000 4 >> AnalizadorTiempos.txt

./Ordenamiento 200000 4 >> AnalizadorTiempos.txt

./Ordenamiento 400000 4 >> AnalizadorTiempos.txt

./Ordenamiento 600000 4 >> AnalizadorTiempos.txt

./Ordenamiento 800000 4 >> AnalizadorTiempos.txt

./Ordenamiento 1000000 4 >> AnalizadorTiempos.txt

./Ordenamiento 2000000 4 >> AnalizadorTiempos.txt

./Ordenamiento 3000000 4 >> AnalizadorTiempos.txt

cd /home/joel/Escritorio/Scripts

chmod 777 Shell.sh

./Shell.sh











