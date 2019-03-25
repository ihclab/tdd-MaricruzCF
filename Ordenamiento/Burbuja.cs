using System;
using System.Collections.Generic;
using System.Text;

namespace Ordenamiento {
	public class Burbuja { 
		public void Ordenar(int[] arr) { 
			for (int i = 0; i < arr.Length - 1; i++) {
				if (arr[i] > arr[i + 1]) {
					int aux = arr[i];
					arr[i] = arr[i + 1];
					arr[i + 1] = aux;
				}
			}
		}
	}
}	
