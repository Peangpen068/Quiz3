class program {
    static void Main(string[] args){

        int TotalStalls = int.Parse(Console.ReadLine());
        int[] num = new int[TotalStalls];
        Console.WriteLine("Total Stalls = {0} ", TotalStalls);
        
        for (int i = 0; i < TotalStalls; i++){
            Console.Write("{0} ", num[i]);
        }
        while(true){

            Console.WriteLine("Enter Stall's number = ");
            int stall1 = int.Parse(Console.ReadLine());
            int stall2 = int.Parse(Console.ReadLine());

            if(stall1 == 0 || stall1 < 0 && stall2 == 0 || stall2 < 0 ){
                Console.WriteLine("Invalid Input");
                break;
            }if(stall1 == 0 || stall2 == 0 || stall2 < 0 || stall1 < 0 ) {
                total++;
            } if (stall1 > 0 && stall2 > 0 ) {
                total++;
            } else {
                total++;
            }
        }
        
    }
        
}