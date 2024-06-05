class Program
{
    
    static void Main(string[] args)
    {
        Findsosoo findsosoo = new Findsosoo();
        findsosoo.FindSoSoo();
    }
}

public class Findsosoo
{
    int[] sosooarray = new int[10000];
    int sosoogetsoo = 0;

    public void FindSoSoo()
    {
        sosooarray[sosoogetsoo] = 1;
        RecursiveSoSoo();
    }

    void RecursiveSoSoo(int asdf = 2)
    {
        for (int i = 0; i < sosoogetsoo+1 ; i++)
        {
            if(asdf % sosooarray[i] != 0)
            {   //소수라면, 배열마지막에 추가하고, 배열 마지막위치를 하나 민다.
                sosooarray[sosoogetsoo] = asdf;
                Console.WriteLine($"{sosoogetsoo}번째 소수 : {asdf}");
                asdf++;
                sosoogetsoo++;
                if(sosoogetsoo > 10)
                {
                    Console.ReadLine();
                }
                RecursiveSoSoo(asdf);
                break;
            }
        }
        RecursiveSoSoo(asdf + 1);
    }
}