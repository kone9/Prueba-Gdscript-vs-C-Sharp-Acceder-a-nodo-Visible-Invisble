# Prueba-Gdscript-vs-C-Sharp-Acceder-a-nodo-Visible-Invisible
Prueba para ver el rendimiento entre c# y Gdscript al acceder a los nodos y hacerlos visibles/invisibles
1.000.000 de veces 


# GDscript 
Guardando el nodo en una variable en ready y luego llamar a la función que hace visible invisible
Result Gdscript#: 1985

#llamando al nodo directamente desde la función y haciendolo visible
Result Gdscript#: 4613

usando grupos y guardando el nodo en una variable en ready y luego llamar a la función que hace visible invisible
Result Gdscript#: 1976

Usando grupos y llamando al nodo directamente desde la función y haciendolo visible
Result Gdscript#: 11143

Resultado Final en Gdscript: guardando el nodo en una variable en ready tuvo el mejor rendimiento.


# c sharp
Guardando el nodo en una variable en ready y luego llamar a la función que hace visible invisible
Result C#: 775

#llamando al nodo directamente desde la función y haciendolo visible
Result C#: 14036

usando grupos y guardando el nodo en una variable en ready y luego llamar a la función que hace visible invisible
Result C#: 794

Usando grupos y llamando al nodo directamente desde la función y haciendolo visible
Result C#: 15521


Resultado Final en C#: guardando el nodo en una variable en ready tuvo el mejor rendimiento.


# NOTA FINAL:
# Guardar los nodos en una variable para luego modificar sus valores mejora notablemente el rendimiento del juego
# C# tiene un mejor rendimineto cuando precargamos los nodos en variables
# sin embargo Gdscript demostro tener un mejor rendimiento al acceder a los nodos
# o grupos directamente.







