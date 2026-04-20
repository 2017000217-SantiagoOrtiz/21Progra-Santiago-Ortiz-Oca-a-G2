Algoritmo Act4_Casa
	Definir n Como Real
	Definir Uni Como Cadena
	Escribir "Digame un numero"
	Leer n
	Escribir "Sellecione una medida"
	Escribir "a - Metros"
	Escribir "b - Pies"
	Escribir "c - Centimetros"
	Escribir "d - Pulgadas"
	Leer uni
	Segun uni Hacer
		'a','A':Escribir "La convercion es, ',n,' Metros'
		'b','B':Escribir "La convercion es, ',n,' Pies'
		'c','C':Escribir "La convercion es, ',n,' Centimetros'
		'd','D':Escribir "La convercion es, ',n,' Pulgadas'
		De Otro Modo:
			Escribir "Numero no valido"
	FinSegun
	
FinAlgoritmo
