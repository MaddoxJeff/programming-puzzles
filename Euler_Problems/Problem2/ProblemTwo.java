

public class ProblemTwo {

	public static void main(String[] args) {
		long[] fib = { 2, 0 };
		int n = 0;
		long total = 0;
		while (fib[n]< 4000000) {
			total += fib[n];
			n = (n+1)%2;
			fib[n] = 4*fib[(n+1)%2]+fib[n];
		}
		System.out.println(total);
	}

}
