import java.util.*;
class searchstack
{  
   public static void main (String args[])
   {  
      Scanner dataIn = new Scanner (System.in);
      Stack<Integer> numbers = new Stack<>();
      
      for(int i = 0; i < 10; i++)
      {
         numbers.push((i + 1) * 10);
      }
      
      System.out.println("Stack: " + numbers);
      System.out.print("Enter a number to search: ");
      int searchNumber = dataIn.nextInt();

      if (numbers.search(searchNumber) != -1) System.out.println("Found the number");
      else System.out.println("Not found");
   }
}