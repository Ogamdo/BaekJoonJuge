import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        //TIP 캐럿을 강조 표시된 텍스트에 놓고 <shortcut actionId="ShowIntentionActions"/>을(를) 누르면
        // IntelliJ IDEA이(가) 수정을 제안하는 것을 확인할 수 있습니다.
       Scanner scanner = new Scanner(System.in);
       int[] nums = new int[9];
       int max=0;
       int index=0;
       for(int i=0; i<9; i++){
           nums[i] = scanner.nextInt();
           if (max<nums[i]){
               max = nums[i];
               index=i;
           }
       }
        System.out.println(max);
        System.out.println(index+1);

    }
}