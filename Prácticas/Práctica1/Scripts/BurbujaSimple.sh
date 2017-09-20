#!/bin/bash
 
echo Ejecutando Algoritmo Burbuja Simple

#Burbuja simple

cd /home/joel/Escritorio
gcc Ordenamiento.c -o Ordenamiento


./Ordenamiento 100 1 >> AnalizadorTiempos.txt
./Ordenamiento 1000 1 >> AnalizadorTiempos.txt
./Ordenamiento 5000 1 >> AnalizadorTiempos.txt
./Ordenamiento 10000 1 >> AnalizadorTiempos.txt
./Ordenamiento 50000 1 >> AnalizadorTiempos.txt
./Ordenamiento 100000 1 >> AnalizadorTiempos.txt
./Ordenamiento 200000 1 >> AnalizadorTiempos.txt
./Ordenamiento 400000 1 >> AnalizadorTiempos.txt
./Ordenamiento 600000 1 >> AnalizadorTiempos.txt
./Ordenamiento 800000 1 >> AnalizadorTiempos.txt


cd /home/joel/Escritorio/Scripts

chmod 777 BurbujaOptimizada.sh

./BurbujaOptimizada.sh