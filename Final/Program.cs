using System;
class Program
{
    static void Main(string[] args)
    {
        Tree<string> tree = new Tree<string>();
        
        string Name = "Plus";
        string Absent =  "";
        string Sipling = "";
        string General = "";
        string TopicName = Console.ReadLine();
        int Headamount = int.Parse(Console.ReadLine());
        int quantity = 0;
        int Plusamount = 0;
        tree.AddChild(-1,Name);
        tree.AddChild(0,TopicName);
        Manage(ref quantity,ref Headamount, ref Plusamount,ref tree,ref General, ref Sipling);
        Absent = Console.ReadLine();  
    }
    static void Manage(ref int amount,ref int Topicamount ,ref int Siplingamount, ref Tree<string> tree, ref string General, ref string Sipling)
    {
        int x = 1;
        while( x<=Topicamount)
            {
                General = Console.ReadLine();
                tree.AddChild(x,General);
                amount = int.Parse(Console.ReadLine());
                 Lower(ref amount,ref Topicamount ,ref Siplingamount,ref tree,ref General,ref Sipling);
                
            }      
    }
    static void Lower(ref int amount,ref int Headamount,ref int Siplingamount,ref Tree<string> tree,ref string General,ref string Sipling)
    {
        int y =1;
        while( y<= amount)
            {
                Sipling = Console.ReadLine();
                tree.AddSibling(y,Sipling);
                Siplingamount= int.Parse(Console.ReadLine());
                if(Siplingamount > 0) Manage(ref amount,ref Headamount ,ref Siplingamount, ref tree, ref General, ref Sipling);
                
            }
    }
}