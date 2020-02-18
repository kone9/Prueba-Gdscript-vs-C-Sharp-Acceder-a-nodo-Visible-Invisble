extends Spatial


# Declare member variables here. Examples:
# var a = 2
# var b = "text"

var started
var contador = 0
var limitador = 1000000
var tiempoTranscurrido #representa un double de 64 bits
var cubo
var triangulo


# Called when the node enters the scene tree for the first time.
func _ready():
	started = OS.get_system_time_msecs()
	cubo = $cubo
	triangulo = $triangulo
	#cubo = get_tree().get_nodes_in_group("cubo")[0]
	#triangulo= get_tree().get_nodes_in_group("triangulo")[0]
	
	#esto es para probar el rendimiento
	while(contador < limitador):
		prueba()
		
	var tiempoTranscurrido = OS.get_system_time_msecs() - started;
	print("Result Gdscript#: ", tiempoTranscurrido);
	get_tree().quit()

	
#para probar si se hace visible/invisible
"""func _process(delta):
	if Input.is_action_just_pressed("w"):
		prueba()
		pass#"""	

#en esta funcion uso la variable donde ya esta pre cargado el nodo
func prueba():
	cubo.visible = !cubo.visible
	triangulo.visible = !triangulo.visible 
	contador += 1 #"""

#en esta función llamo al nodo directamente		
"""func prueba():
	$cubo.visible = !$cubo.visible
	$triangulo.visible = !$triangulo.visible 
	contador += 1#"""

#en esta funcion uso los grupos para hacerlos visible/invisible
"""func prueba():
	get_tree().get_nodes_in_group("cubo")[0].visible = !get_tree().get_nodes_in_group("cubo")[0].visible
	get_tree().get_nodes_in_group("triangulo")[0].visible = !get_tree().get_nodes_in_group("triangulo")[0].visible
	contador += 1"""
