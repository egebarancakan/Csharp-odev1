internal class Program
{
    private static void Main(string[] args)
    {
       Questions question=new Questions();
       question.firstQuestion();
       question.secondQuestion();
       question.thirdQuestion();
       question.fourthQuestion();
    }
}

public class Questions
{
    public void firstQuestion()
    {
        Console.WriteLine("Çift sayıları ekrana yazdırma");
        Console.WriteLine("Kaç sayı gireceğinizi belirtiniz");
        string queue=Console.ReadLine();
        List<int> numbers = new List<int>();
        for(int i=0; i<int.Parse(queue); i++)
        {
            Console.WriteLine("{0}. sayıyı giriniz:" , i+1);
            int a=int.Parse(Console.ReadLine());
            if(a%2==0)
            {
                numbers.Add(a);
            }
        }
        foreach(var item in numbers)
        {
            Console.WriteLine("Girmiş olduğunuz çift sayılar:" + item);
        }
    }

    public void secondQuestion()
    {
        Console.WriteLine("Tam bölünenleri ekrana yazdırma");
        Console.WriteLine("İki adet pozitif sayı giriniz");
        int n=int.Parse(Console.ReadLine());
        int m=int.Parse(Console.ReadLine());
        Console.WriteLine("Girdiğiniz " + n + " değeri kadar sayı giriniz");
        List<int> numbers=new List<int>();
        for(int i=0; i<n; i++)
        {
            Console.WriteLine("{0}. sayıyı giriniz" , i+1);
            int a=int.Parse(Console.ReadLine());
            if(a%m==0)
            {
                numbers.Add(a);
            }
        }
        foreach(var item in numbers)
        {
            Console.WriteLine("İkinci girdiğiniz değere tam bölünen sayılar:" + item);
        }
    }

    public void thirdQuestion()
    {
        Console.WriteLine("Kelimeleri sondan başa ekrana yazdırma");
        Console.WriteLine("Kaç kelime gireceğinizi belirleyiniz");
        int n=int.Parse(Console.ReadLine());
        List<string> words=new List<string>();
        for(int i=0; i<n; i++)
        {
            Console.WriteLine($"{i+1}. kelimeyi giriniz");
            string word=Console.ReadLine();
            words.Add(word);
        }
        for(int j=n-1; j>=0; j--)
        {
            Console.WriteLine(words[j]);
        }
    }

    public void fourthQuestion()
    {
        Console.WriteLine("Cümledeki toplam kelime ve harf sayısını konsola yazdırma");
        Console.WriteLine("Cümle giriniz");
        string sentence=Console.ReadLine();
        string[] words=sentence.Split(' ');
        Console.WriteLine("Kelime sayısı : {0}", words.Count());
        Console.WriteLine("Harf sayısı : {0}" , sentence.Count());
    }
}
