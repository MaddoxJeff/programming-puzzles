import java.util.*;
import java.util.ArrayList;

public class ProblemSix {
	public static void main(String[] args) {
		
		ArrayList<Double> test = new ArrayList<Double>();
		System.out.println(squares(test)-square(test));		
	}
	
	public static double square(ArrayList<Double> n){
		ArrayList<Double> tempArr = new ArrayList<Double>();
		for (int i = 0;i < 101; i++) {
			if (i == 0)
				continue;
			double tempp = Math.pow(i, 2);
			tempArr.add(tempp);
		}
		double sum = 0;
		for (double k: tempArr) {
			sum += k;
		}
		return sum;
	}
	
	public static double squares(ArrayList<Double> n){
		double temp = 0;
		ArrayList<Double> tempArr = new ArrayList<Double>();
		for (double i = 0; i < 101; i++) {
			if (i == 0)
				continue;
			temp += i;			
		}
		temp = Math.pow(temp, 2);
		return temp;
	}
}
