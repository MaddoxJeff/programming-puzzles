import java.util.*;

public class ProblemTen {

	public static void main(String[] args) {
		
		ArrayList<Integer> n = new ArrayList<Integer>();
		System.out.println(sumPrimes(n));	
	}
	
	public static int sumPrimes(ArrayList<Integer> n) {
		
		ArrayList<Integer> temp = new ArrayList<Integer>();
		for (int k = 2; k < 2000000; k++) {
			if (isPrime(k)==true)
				temp.add(k);
		}
		int x = sum(temp);
		return x;
	}
	public static boolean isPrime(int n) {
		int counter = 0;
		if (n == 2) {
			return true;
		} else if (n % 2 == 0) {
			return false;
		}
		for(int i = 3; i*i <= n;i++) {
			if(n%i == 0) {
				return false;
			}			
		}
		return true;
	}	

	public static int sum(List<Integer> list) {
		
		int sum = 0;
		for (int i: list) {
			sum += i;
		}
		return sum;
	}

}
