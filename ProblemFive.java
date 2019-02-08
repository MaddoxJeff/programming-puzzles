import java.util.*;
import java.util.ArrayList;

public class ProblemFive {

	public static void main(String[] args) {
		int z = 0;
		System.out.println(lowest(z));		
	}
	
	public static int lowest(int n){
	int count = 0;
	int temp = 11;
	while (count < 20) {
		for (int i = 0; i < 20;i++) {
			if (i == 0 || i == 1) {
				count++;
				continue;
			}
			if (temp%i == 0)
				count++;
			else {
				count = 0;
				temp++;
				break;
			}							
		}
	}
	return temp;

	}
}