import java.util.Scanner;
import java.util.*;

public class perfBal {

    public static void main(String[] args) {
        Scanner input=new Scanner(System.in);
		System.out.println("Enter a word: ");
        String s = input.nextLine();
        
        Map<Character, Integer> stringHash = new HashMap<Character, Integer>();
		for (char ch : s.toCharArray())
            stringHash.put(ch, stringHash.containsKey(ch) ? (stringHash.get(ch) + 1) : 1);
            
            ArrayList<Integer> arList = new ArrayList<Integer>();
            for(Map.Entry<Character, Integer> map : stringHash.entrySet()){
                 arList.add(map.getValue());
            }
            perfBal test = new perfBal();
            System.out.println(test.balanced(arList));
    }
    public static boolean balanced(ArrayList<Integer> arList) {
	
        for(int i = 0; i < arList.size(); i++) {
            for (int k = i+1; k < arList.size(); k++) {
                if (arList.get(i) != arList.get(k)) {
                    return false;
                }
            }
        }
        return true;
    }
}