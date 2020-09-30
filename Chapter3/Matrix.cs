using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Chapter3
{
	class Matrix
	{
		private int row;
		private int column;
		private int[,] matrx;
		public Matrix(){
		}
		public static bool matrixCheck(Matrix a, Matrix b) => a.row == b.row && a.column == b.column;
		public static bool multiableCheck(Matrix a, Matrix b) => a.row == b.column || a.column == b.row;
		public Matrix(int _row, int _column) {
			row = _row;
			column = _column;
			matrx = new int[row, column];
		}
		public static Matrix operator +(Matrix A, Matrix B)
		{
			Matrix result = new Matrix();
			if (!matrixCheck(A, B))
			{
				return result;
			}

			result = new Matrix(A.row, A.column);
			
			for (int i = 0; i < A.row; i++) {
				for (int j=0; i < A.column; i++) {
					result.matrx[i, j] = A.matrx[i, j] + B.matrx[i, j];
				}
			}
			return result;
		}

		public static Matrix operator -(Matrix A, Matrix B)
		{
			Matrix result = new Matrix();
			if (!matrixCheck(A, B))
			{
				return result;
			}

			result = new Matrix(A.row, A.column);

			for (int i = 0; i < A.row; i++)
			{
				for (int j = 0; i < A.column; i++)
				{
					result.matrx[i, j] = A.matrx[i, j] - B.matrx[i, j];
				}
			}
			return result;
		}

		public static Matrix operator *(Matrix A, Matrix B)
		{
			Matrix result = new Matrix();
			if (!multiableCheck(A, B))
			{
				return result;
			}
			result = new Matrix(A.row, B.column);
			for (int i = 0; i < A.row; i++)
			{
				for (int j=0; j < B.column; j++) {
					int sum = 0;
					for (int k = 0; k < B.column; k++) {
						sum += A.matrx[i, k] * B.matrx[k, j];
					}
					result.matrx[i, j] = sum;
				}
			}
			return result;
		}

		public int Row   // property
		{
			get { return row; }   // get method
			set { row = value; }  // set method
		}
		public int Column   // property
		{
			get { return column; }   // get method
			set { column = value; }  // set method
		}
	}
}
