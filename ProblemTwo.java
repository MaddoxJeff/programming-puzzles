import java.util.*;
import java.util.ArrayList;

public class ProblemTwo {

	public static void main(String[] args) {
		ArrayList<Integer> test = new ArrayList<Integer>();
		test = fib(test);
		System.out.println(even(test));		
	}
	public static ArrayList<Integer> fib(ArrayList<Integer> n){
		
		int prev = 1, current = 1, next = 1;
		for (int i = 0; i < 100; i++) {
			if (i == 0) {
				n.add(1);
				continue;
			}
			next = prev+current;
			n.add(next);
			prev = current;
			current = next;
		}
		return n;
	}
	public static ArrayList<Integer> even(ArrayList<Integer> n){
		
		ArrayList<Integer> temp = new ArrayList<Integer>();
		for (int i: n) {
			if (i > 400000000)
				break;
			if(i % 2 == 0)
				temp.add(i);
		}
		return temp;
		
	}

}