using System;
using System.IO;

namespace Problem2 {
	public class Problem2 {
		public Problem2 () {
		
		}
		public void solveProblem2() {
			int x = 0;
			int i = 1;
			int n = 1;
			int sum = 0;
			string answer = "";
			for (; i < 4000000;) {
				x = n + i;
				n = i;
				i = x;
				if (i % 2 == 0) {
					sum = sum + i;
				}

			}
			answer = "The Answer Is: " + sum;
			Console.WriteLine (answer);

		}
	
		static void Main() {
			Problem2 solution = new Problem2();

			solution.solveProblem2();

		}
	}
}


