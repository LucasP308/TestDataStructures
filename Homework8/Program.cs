namespace Homework8
{
    internal class Program
    {/*

                                        number of students unable to eat lunch
        public int CountStudents(int[] students, int[] sandwiches) {
        Queue<int> kids = new();
        Stack <int> stack = new();
        int count = 0;

        foreach( int i in students){
            kids.Enqueue(i);
        }
        for(int i = sandwiches.Length -1; i>=0; i--){
            stack.Push(sandwiches[i]);
        }

        while(count< kids.Count){

            if(kids.Peek()==stack.Peek()){
                kids.Dequeue();
                stack.Pop();
                count = 0;
            }
            else if(kids.Peek()!=stack.Peek()){
                kids.Enqueue(kids.Peek());
                kids.Dequeue();
                count ++;
            }
        }
        return kids.Count;
    }



                                                        Baseball Game
        public int CalPoints(string[] operations) {
        List<int> points=new() ;
        int a = 0;
        for(int i = 0; i< operations.Length; i++){
            if(operations[i]=="+"){
                points.Add(Convert.ToInt32(points[a-2])+Convert.ToInt32(points[a-1]));
                a++;
            }
            else if(operations[i]=="D"){
                points.Add( Convert.ToInt32(points[a-1]) *2);
                a++;
            }
            else if(operations[i]=="C"){
                points.RemoveAt(points.Count-1);
                a--;
            }
            else{
                points.Add(Convert.ToInt32(operations[i]));
                a++;
            }
        }
        
        int total_points=0;
        for(int i=0; i<points.Count; i++){
            total_points+=points[i];
        }
        return total_points;
    }



                                                        Find Pivot index
         public int PivotIndex(int[] nums) {
        int idx=-1;
        int right=0;
        int left=0;
        int total =0;
        for(int i= 0; i< nums.Length; i++){
            total += nums[i];
        }

        for(int i =0; i< nums.Length;i++){
            right = total - left - nums[i];

            if(right==left){
                idx = i;
                return idx;
            }
           left +=nums[i];
        }
        return idx;
    }


                                                        Valid parentheses
        public bool IsValid(string s) {
        bool bruh = true;
        Stack<char> brack = new();
        int len = s.Length;

        char c ;
        if(len==1){
            return  false;
        }
        for (int i =0; i<len; i++){
            c=s[i];
            if(c =='('||c =='['||c =='{'){
                brack.Push(c);
                
            }
            else if(brack.Count>0&& 
                    (brack.Peek()=='('&&c==')'||
                    brack.Peek()=='['&&c==']'||
                    brack.Peek()=='{'&&c=='}')){
                        brack.Pop();
                        
                    }
            else{
                bruh = false;
                break;
            }
        }
        if(brack.Count>0){
            bruh =false;
        }
        return bruh;
      
    }


                                                        Number of Recent Pings
                 public Queue <int> ping;
    public RecentCounter() {
        ping= new();
    }
    
    public int Ping(int t) {
        
        ping.Enqueue(t);
        while(ping.Peek()<t-3000){
            ping.Dequeue();
        }
        return ping.Count();
    }
}
*/



        static void Main(string[] args)
        {
            
        }
    }
}
