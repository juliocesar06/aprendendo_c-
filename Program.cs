// Curso basico C# .net

//estrutura padrao c#

namespace basico;
class Program
{

    //metodo com declaraçoes
    static void declaracao()
    {
        int a;
        int b=50 ,c = 50;
        const int d = 777;
        float ff = 62.39f;
        double dd = 7777.77896555d;
        a = 1;
        Console.WriteLine((a + b + c + d) +(dd + ff));

    }
    //input/output
    static void print_input()
    {
        string nome;

        Console.Write("escreva seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Seu nome é: " + nome + " e voçe esta aprendendo c sharp");
    }
    //funcloes com if/else if / else
    static void condicional()
    {
        string nome_aluno,value;
        float n1,n2,n3,soma;

        //recebendo nome do aluno
        Console.WriteLine("Nota do ano");
        Console.Write("Digite seu nome: ");
        nome_aluno = Console.ReadLine();

        //recebendo nota1
        Console.WriteLine("digite sua nota n1: ");
        value = Console.ReadLine();
        n1 = float.Parse(value);
        Console.WriteLine("----------------------------------");

        //recebendo nota2
        Console.WriteLine("digite sua nota n2: ");
        value = Console.ReadLine();
           Console.WriteLine("----------------------------------");

        //recebendo nota3
        n2 = float.Parse(value);
            Console.WriteLine("digite sua nota n3: ");
        value = Console.ReadLine();
        n3 = float.Parse(value);
           Console.WriteLine("----------------------------------");

        soma = ((n1+n2+n3)/3);

        if (soma < 6)
        {
            Console.WriteLine("Nota abaixo da media:");
            Console.WriteLine("REPROVADO  :{ ");
        }
        else if (soma >= 6 && soma <= 8)
        {
            Console.WriteLine("Nota acima da media:");
            Console.WriteLine("APROVADO  :) ");
        }
        else
        {   
            Console.WriteLine("Nota acima da media:");
            Console.WriteLine("APROVADO  :) OK ");
            Console.WriteLine("PARABENS SUA NOTA FOI: " + Math.Round(soma));
        }
        


    }
    //metodo com swicth
    static void casosSWITH(string[] args)
    {
        int numero_args = args.Length;

        switch(numero_args)
        {
        
            case 0:
                Console.WriteLine("0 argumentos...");
                break;
            case 1:
                Console.WriteLine("1 argumentos...");
                break;
            default:
                    Console.WriteLine($"{numero_args} argumentos...");
                break;
        }
        
    }
    //metodo com while
    static void loop_while()
    {
        int contador = 100;
        int  i = 0;
        while(contador > 1)
        {
            Console.WriteLine(contador);
            contador --; 
        }
    }

    //metodo com for
        static void loop_for()
    {
        int contador = 777;
        int i;

        for (i=0;i<contador;i++)
        {
            Console.Write(i);
        }
    }
    //metodo com dowhile
    static void whiledowhile()
    {
        int cont = 100;

        do 
        {
            Console.WriteLine("Hello world!!!" + cont);
            cont--;
            
        }
        while(cont > 0);
       
    }
    //metodo foreach
    static void imprimeCada ()
    {   
        List<string>cores = new List<string>();
        cores.Add("branco");
        cores.Add("preto");
        cores.Add("azul");
        cores.Add("laranja");

        foreach (string s in cores)
        {
            Console.WriteLine(s);
        }
    }
    //metodo break/continue
    public static void estrutura()
    {
        int num;
        string line;
      

        while(true)
        {
            Console.Write("Digite um numero: ");
            line = Console.ReadLine();

            num = int.Parse(line);
            
            if (num < 10)
            {   
                 Console.WriteLine(num+"continue");
                continue;
            }
            else if(num > 10 & num < 50)
            {
                 Console.WriteLine(num + "break");
                break;
            }
            else
            {
                 Console.WriteLine(num + "else");
                Console.WriteLine(num);
                return ;
            }
        }
        
    }
 
    public static void Main()
    {
    
        //tipos e variaveis
        //declaracao();
        //print_input();
        //condicional();
        //casosSWITH(args);
        //loop_while();
        //loop_for();
        //whiledowhile();
        //imprimeCada();
        //estrutura();
    }
}