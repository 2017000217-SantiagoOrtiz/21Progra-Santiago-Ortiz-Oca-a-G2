Algoritmo Act1_Casa
	Definir ag, pii, res Como Real
	Definir op Como Entero
	pii=3.1416
	Escribir "Escriba un angulo"
	leer a
	Escribir "Diga una funcion trigonometrica"
	Escribir "1 Seno"
	Escribir "2 Coseno"
	Escribir "3 Tangente"
	Leer op
	Segun op Hacer
		1:res= sen(ag*pii/180)
			Escribir "El seno es: ",res
		2:res= cos(ag*pii/180)
			Escribir "El coseno es: ",res
		3:res= tan(ag*pii/180)
			Escribir "El tangente es: ",res
		De Otro Modo:
			Escribir "Funcion invalida"
	FinSegun
FinAlgoritmo
