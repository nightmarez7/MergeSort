using System;

namespace Ed {
	class Programa {
		static void Main( string[] args ) {

			int[] vetor = new int[] { 5, 8, 6, 1, 0, 3, 2, 4, 7, 9 };
			merge( vetor, 0, 9 );

			for( int i = 0; i < 10; i++ ) {
				Console.Write( vetor[ i ] );
			} 
		}

		static void merge( int[] vetor, int start_pos, int end_pos ) {
			int middle_pos;

			if( start_pos < end_pos ){
				middle_pos = ( start_pos + end_pos ) / 2;
				merge( vetor, start_pos, middle_pos );
				merge( vetor, middle_pos + 1, end_pos );

				interleave( vetor, start_pos, end_pos, middle_pos );
			}
		}

		static void interleave( int[] vetor, int start_pos, int end_pos, int middle_pos) {
			int poslivre, start_vetor_left, start_vetor_right, i;
			int[] aux = new int[ 10 ];

			start_vetor_left = start_pos;
			start_vetor_right = middle_pos + 1;
			poslivre = start_pos;

			while( start_vetor_left <= middle_pos && start_vetor_right <= end_pos ) {
				if( vetor[ start_vetor_left] <= vetor[ start_vetor_right ] ) {
					aux[ poslivre ] = vetor[ start_vetor_left ];
					start_vetor_left = start_vetor_left + 1;
				} else {
					aux[ poslivre ] = vetor[ start_vetor_right ];
					start_vetor_right = start_vetor_right + 1;
				}
				poslivre = poslivre + 1;
			}

			for( i = start_vetor_left; i <= middle_pos; i++ ) {
				aux[ poslivre ] = vetor[ i ];
				poslivre = poslivre + 1;
			}

			for( i = start_vetor_right; i <= end_pos; i++ ) {
				aux[ poslivre ] = vetor[ i ];
				poslivre = poslivre + 1;
			}

			for( i = start_pos; i <= end_pos; i++ ) {
				vetor[ i ] = aux[ i ];
			}
		}
	}
}