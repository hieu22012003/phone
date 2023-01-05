// See https://aka.ms/new-console-template for more information
using phone;


public class Progam
{
    static void Main4(string[] args)
    {
        PhoneBook pb = new PhoneBook();
        pb.insertPhone("quan", "0999999999");
        pb.insertPhone("minh", "0999988899");
        pb.insertPhone("nam", "0777799999");
        pb.insertPhone("nam", "093435435999");
        pb.Sort();
        foreach (PhoneNumber p in pb.PhoneList)
        {
            Console.WriteLine(p.ToString());
        }
    }
}