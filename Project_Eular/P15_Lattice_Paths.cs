using System;

namespace Project_Eular
{
	public class P15_Lattice_Paths
	{
		public P15_Lattice_Paths(int size)
		{
			int dimension = size + 1;
			long[,] lattice = new long[dimension, dimension];
			for (int i = 0; i < lattice.GetLength(0); i++) {
				lattice [i, 0] = 1;
				lattice [0, i] = 1;
			}
			for (int i = 1; i < lattice.GetLength(0); i++) {
				for (int j = 1; j < lattice.GetLength(1); j++) {
					lattice [i, j] = lattice [i - 1, j] + lattice [i, j - 1];
				}
			}
			Console.WriteLine (lattice [size,size]);
		}
	}

}
