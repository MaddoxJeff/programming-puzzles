import java.util.*;

public class ProblemTen {

	public static void main(String[] args) {
		
		ArrayList<Integer> n = new ArrayList<Integer>();
		System.out.println(sumPrimes(n));	
	}
	
	public static int sumPrimes(ArrayList<Integer> n) {
		
		ArrayList<Integer> temp = new ArrayList<Integer>();
		for (int k = 0; k < 10000; k++) {
			if (isPrime(k)==true)
				temp.add(k);
		}
		int x = sum(temp);
		return x;
	}
	
	public static boolean isPrime(int n) {
		int counter = 0;
		for(int i = 0; i < n;i++) {
			if(i == 0)
				continue;
			if(n%i == 0 )
				counter++;
		}
		if (counter == 1)
			return true;
		else
			return false;
	}
	public static int sum(List<Integer> list) {
		
		int sum = 0;
		for (int i: list) {
			sum += i;
		}
		return sum;
	}

}