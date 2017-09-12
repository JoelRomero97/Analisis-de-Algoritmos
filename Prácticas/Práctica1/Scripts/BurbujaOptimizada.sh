#!/bin/bash
 
echo Ejecutando Algoritmo Burbuja Optimizada

#Burbuja Optimizada

cd /home/joel/Escritorio
gcc Ordenamiento.c -o Ordenamiento

./Ordenamiento 100 2 >> AnalizadorTiempos.txt

./Ordenamiento 1000 2 >> AnalizadorTiempos.txt

./Ordenamiento 5000 2 >> AnalizadorTiempos.txt

./Ordenamiento 10000 2 >> AnalizadorTiempos.txt

./Ordenamiento 50000 2 >> AnalizadorTiempos.txt

./Ordenamiento 100000 2 >> AnalizadorTiempos.txt

./Ordenamiento 200000 2 >> AnalizadorTiempos.txt

./Ordenamiento 400000 2 >> AnalizadorTiempos.txt

./Ordenamiento 600000 2 >> AnalizadorTiempos.txt

./Ordenamiento 800000 2 >> AnalizadorTiempos.txt

cd /home/joel/Escritorio/Scripts

chmod 777 Insercion.sh

./Insercion.sh









