#!/bin/bash
 
echo Ejecutando Algoritmo Insercion

#Insercion

cd /home/joel/Escritorio
gcc Ordenamiento.c -o Ordenamiento

./Ordenamiento 100 3 >> AnalizadorTiempos.txt

./Ordenamiento 1000 3 >> AnalizadorTiempos.txt

./Ordenamiento 5000 3 >> AnalizadorTiempos.txt

./Ordenamiento 10000 3 >> AnalizadorTiempos.txt

./Ordenamiento 50000 3 >> AnalizadorTiempos.txt

./Ordenamiento 100000 3 >> AnalizadorTiempos.txt

./Ordenamiento 200000 3 >> AnalizadorTiempos.txt

./Ordenamiento 400000 3 >> AnalizadorTiempos.txt

./Ordenamiento 600000 3 >> AnalizadorTiempos.txt

./Ordenamiento 800000 3 >> AnalizadorTiempos.txt

./Ordenamiento 1000000 3 >> AnalizadorTiempos.txt

./Ordenamiento 2000000 3 >> AnalizadorTiempos.txt

cd /home/joel/Escritorio/Scripts

chmod 777 Seleccion.sh

./Seleccion.sh












