Algoritmo Ac3_Casa
	Definir sec,cant,tot Como Real
	Escribir "Diga la cantidad de entradas"
	Leer cant
	Escribir "Diga donde quiere estar"
	Escribir "1 Palco - Q300.00"
	Escribir "2 Tribuna - Q125.00"
	Escribir "3 Prefernecia - Q75.00"
	Escribir "4 Generales - Q50.00"
	Leer sec
	Segun sec Hacer
		1: tot= cant*300
			Escribir "Su total de las entradas es de: Q",tot
		2: tot= cant*125
			Escribir "Su total de las entradas es de: Q",tot
		3: tot= cant*75
			Escribir "Su total de las entradas es de: Q",tot
		4: tot= cant*50
			Escribir "Su total de las entradas es de: Q",tot
		De Otro Modo:
			Escribir "No esta esa opcion disponible"
	FinSegun
FinAlgoritmo
