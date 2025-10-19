import java.util.Scanner;

public class Tram 
{
    
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        int num_of_tram = scanner.nextInt(); 

        int[][] num_of_people = new int[num_of_tram][2]; //[num of peep getting out][number of people getting in].
        int num_of_peep_inside_the_tram = 0;
        int max_people = 0;

        for(int i = 0; i < num_of_tram; i++)
        {
            num_of_people[i][0] = scanner.nextInt();
            num_of_people[i][1] = scanner.nextInt();
            num_of_peep_inside_the_tram = num_of_peep_inside_the_tram - num_of_people[i][0] + num_of_people[i][1];
            max_people = Math.max(max_people, num_of_peep_inside_the_tram);
        }

        System.out.println(max_people);





        scanner.close();




    }
}

/*Linear Kingdom has exactly one tram line. It has n stops, numbered from 1 to n in the order of tram's movement. At the i-th stop ai passengers exit the tram, 
while bi passengers enter it. The tram is empty before it arrives at the first stop. Also, when the tram arrives at the last stop, all passengers exit so that 
it becomes empty.

Your task is to calculate the tram's minimum capacity such that the number of people inside the tram at any time never exceeds this capacity. Note that at each 
stop all exiting passengers exit before any entering passenger enters the tram. */
