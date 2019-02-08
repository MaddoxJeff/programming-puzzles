import java.util.*;
import java.util.ArrayList;

public class ProblemThree {
	
	public static void main(String[] args) {
		ArrayList<Integer> test = new ArrayList<Integer>();
		System.out.println(prime(13195));

	}
	
	public static ArrayList<Integer> prime(int n) {
		ArrayList<Integer> temp = new ArrayList<Integer>();
		for (int i = 2;i<n;i++) {
			if (i == 0 || i == 1)
				continue;
			if (n % i == 0 && isPrime(i)==true)
				temp.add(i);
		}
		return temp;
	}
	
	public static boolean isPrime(int n) {
		int counter = 0;
		for(int i = 0; i < n;i++) {
			if(i == 0)
				continue;
			if(n%i == 0)
				counter++;
		}
		if (counter > 2)
			return false;
		else
			return true;
	}

}
