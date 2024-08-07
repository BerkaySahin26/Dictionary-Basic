// See https://aka.ms/new-console-template for more information
using Dictionary;

internal class Program
{
    static void Main(string[] args)
    {

        MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
        myDictionary.Add(12, "A");
        myDictionary.Add(13, "B");
        myDictionary.Add(14, "C");
        myDictionary.Add(15, "D");
        myDictionary.Write();
    }
}
