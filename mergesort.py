def main():
	vetor = [ 6, 3, 2, 4, 5, 1, 0, 7, 8, 9 ];
	merge( vetor, 0, len( vetor ) - 1);
	print( vetor );

def merge( vetor, start, end ):
	if start < end:
		meio = int( (start + end ) / 2 );
		merge( vetor, start, meio );
		merge( vetor, meio + 1, end );

		intercala( vetor, start, end, meio );

def intercala( vetor, inicio, fim, meio ):
	aux = [ 0 ] * 10;
	inicio_vetor_um = inicio;
	inicio_vetor_dois = meio + 1;
	poslivre = inicio;

	while inicio_vetor_um <= meio and inicio_vetor_dois <= fim:
		if vetor[ inicio_vetor_um] < vetor[ inicio_vetor_dois ]:
			aux[ poslivre ] = vetor[ inicio_vetor_um ];
			inicio_vetor_um = inicio_vetor_um + 1;
		else:
			aux[ poslivre ] = vetor[ inicio_vetor_dois ];
			inicio_vetor_dois = inicio_vetor_dois + 1;
		poslivre = poslivre + 1;

	for i in range( inicio_vetor_um, meio + 1 ):
		aux[ poslivre ] = vetor[ i ];
		poslivre = poslivre + 1;
	for i in range( inicio_vetor_dois, fim + 1 ):
		aux[ poslivre ] = vetor[ i ];
		poslivre = poslivre + 1;

	for i in range( inicio, fim + 1 ):
		vetor[ i ] = aux[ i ];

main();