using System;
using System.IO;

public class Problem1 {
	public int sum = 0;
	public string answer = "";

	public Problem1 () {			

	}
	public void solveProblem1() {
		for (int i = 0; i < 1000; i++) {
			if (i % 3 == 0 && i % 5 == 0) {
				sum = sum + i;


			}
			answer = "The Answer Is: " + sum;
		
		}
		Console.WriteLine (answer);
	}
	static void Main() {
		Problem1 solution = new Problem1();
	
		solution.solveProblem1();

	}
}
