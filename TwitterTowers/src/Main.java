import java.util.Scanner;

public class Main {
    //------------------------------------------------------------------------------
    public static void rectangleTower(int width, int height){
        int area=width*height;//calculate rectangle area - width*heigth.
        int perimeter=(width+height)*2;//The perimeter of rectangle is the width+height *2.
        // if the width==height this is Square ,
        // or if the difference between the width and the height is bigger than 5.
        //print the rectangle area.
        if(width==height ||Math.abs(width-height)>5){
            System.out.println("Rectangle area: "+area);
        }
        else{
            System.out.println("Rectangle Perimeter:"+perimeter);
        }
        // else we print the rectangle perimeter.
    }
    //---------------------------------------------------------------------------------------
    public static void triangleTower(int width,int height,int choose){
        int trianglePerimeter=width+(2*height);
        if(choose<1 || choose>2){
            System.out.println("the enter is not number 1 or 2 ");
            return;
        }
        if(choose==1){
            System.out.println("The triangle perimeter is : "+trianglePerimeter);
        }
        else if (width%2==0 || width > (2*height))
        {
            System.out.println("The triangle cannot be printed");
        }
        else{
            trianglePrint(width,height);
        }
    }
    //---------------------------------------------------------------------------------------
    public static void trianglePrint(int width,int height){
        int lineInGroup, extra;
        int[] triangle = new int[height];// An array where each cell in the array represents a row of asterisks.
        int numOfGroup = (width / 2) - 1;//The number of groups is the amount of odd numbers between the number 1 and the width.
        if(numOfGroup!=0) {
            lineInGroup = (height - 2) / numOfGroup;//The number of rows in a group is the height of the triangle minus 2 divided by the number of groups.
        }
        else {
            lineInGroup=1;
        }
        int x = 3;// The variable X represents the number of asterisks in the row In each iteration of the loop it will increase by 2.
        if(numOfGroup!=0){
            extra = (height - 2) % numOfGroup;// The variable extra represents the remainder of dividing
        }
        else extra=1;
        // the number of rows in the triangle (not including the first and last) by the number of groups.
        triangle[0] = 1;//the first line print just 1 asterisk.
        triangle[triangle.length - 1] = width;//In the last line, asterisks will be printed like the width of the triangle.
        int cnt = 0;//The variable cnt represents the number of lines already entered into
        // the array and the loop will stop when the cnt reaches lineInGroup and resets .
        int j=1;//The variable j represents the position in the array
        for (int i = 0; i < numOfGroup; i++) {
            //if we have a remainder we add it to the first group
            if (x == 3 && extra != 0) {
                while (cnt < extra + lineInGroup) {
                    triangle[j++] = x;
                    cnt++;
                }
                extra=0;
            }
            else {
                while (cnt < lineInGroup) {
                    triangle[j++] = x;
                    cnt++;
                }
            }
            cnt=0;
            x+=2;
        }
        //print the triangle
        //An outer loop for going over the rows
        for (int i = 0; i < triangle.length; i++){
            //An inner loop for printing the spaces before the asterisks
            for ( j = 0; j < width-triangle[i]/2; j++) {
                System.out.print(" ");
            }
            //An inner loop for printing the asterisks
            for (int k = 0; k < triangle[i]; k++) {
                System.out.print("*");
            }
            //Print a new line to end the current line
            System.out.println("");
        }
    }
    //------------------------------------------------------------------------------------
    public static void main(String[] args) {
        Scanner in =new Scanner(System.in);
        System.out.println("*** hello and welcome to Twitter Towers ****");
        int inputNumber=0,width,height;
        while(true) {
            do {
                System.out.println("Enter 1 for Rectangle Tower\n" +
                        "Enter 2 for Triangle Tower\n" +
                        "Enter 3 for exit any time");
                inputNumber=in.nextInt();
            } while (inputNumber<1||inputNumber>3);
            if(inputNumber==3){
                System.out.println("GoodBay!");
                break;
            }
            System.out.println("**please enter the width of the tower**");
            width=in.nextInt();
            System.out.println("**please enter the height of the tower**");
            height=in.nextInt();
            if(inputNumber==1){
                rectangleTower(width,height);
            }
            else{
                System.out.println("You choose triangle ,\n" +
                        "now choose 1 to get the triangle perimeter or 2 to print the triangle ");
                triangleTower(width,height,in.nextInt());
            }
        }
    }
}