Algoritmo Act5_Casa
	Definir cant, p,sinIva, conIva, tsd, d, tp, pd Como Real
	Definir fp Como Caracter
	sinIva <-650.00
	conIva <- sinIva*1.12
	pd <- 0
	fp <- ""
	Escribir "Cantidad de impresoras"
	Leer cant
	Escribir "Elija su metodo de pago"
	Escribir "1 Efectivo - 10% desc"
	Escribir "2 Tarjeta de credito - 5% desc"
	Escribir "3 Vale de regalo - 15% desc"
	Leer p
	Segun p Hacer
		1:pd<-0.10
			fp <-"Efectivo"
		2:pd <-0.05
			fp<-"Tarjeta de credito"
		3:pd<-0.15
			fp<-"Vale de regalo"
		De Otro Modo:
			pd<-0
			fp<-"No valida, Sin descuento"
	FinSegun
	tsd<- conIva*cant
	d<- tsd*pd
	tp<- tsd-d
	Escribir "Detalles de Pago"
	Escribir "Cantidad comprada:          ",cant
	Escribir "Precio unitario (con IVA): Q",conIva
	Escribir "Total sin descuento:       Q",tsd
	Escribir "Forma de pago elegid:       ",fp
	Escribir "Descuento Realizado:      -Q",d
	Escribir "Total a pagar:             Q",tp
	
FinAlgoritmo
