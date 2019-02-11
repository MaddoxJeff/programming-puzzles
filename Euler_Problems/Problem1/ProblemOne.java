import java.util.*;
import java.util.ArrayList;

public class ProblemOne {

	public static void main(String[] args) {
		LinkedList<Integer> three = new LinkedList<Integer>();
		LinkedList<Integer> five = new LinkedList<Integer>();
		LinkedList<Integer> merged = new LinkedList<Integer>();
		
		for (int i = 0; i < 1000; i += 3) {
			if (i == 0)
				continue;
			three.addLast(i);
		}
		for(int j = 0; j < 1000; j+= 5) {
			if (j == 0)
				continue;
			five.addLast(j);
		}
		for (int k = 0; k < 1000; k++) {
			if(three.contains(k) || five.contains(k))
				merged.addLast(k);
		}
		System.out.println(sum(merged));

	}
	public static int sum(List<Integer> list) {
		
		int sum = 0;
		for (int i: list) {
			sum += i;
		}
		return sum;
	}

}
