using System;
using System.Collections.Generic;
using System.Text;

namespace Ordenamiento {
	public class Burbuja { 
		public void Ordenar(int[] arr) { 
			for (int i = 0; i < arr.Length - 1; i++) {
				for(int j=0; j<arr.Length-i-1;j++){
					if (arr[j] > arr[j + 1]) {
						int aux = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = aux;
					}
				}
			}
		}
	}
}	
