using System;
using System.Formats.Asn1;

class Program
{
    static int[] Rand(){
        int var1,var2,var3;
        while (true)
        {
             var1 = Random.Shared.Next(1,4);
             var2 = Random.Shared.Next(1,4);
             var3 = Random.Shared.Next(1,4);
            if(var1 != var2 && var1 != var3 && var2 != var3) break;
        }
        int[] arr = {var1,var2,var3};
        return arr;
        
    }
    static void Main()
    {   
        
        string[,] quiz = {
            {"Azerbaycanin paytaxti Haradir","Gence","Baku","Sumqayit","Baku"},
            {"Azerbaycanin en boyuk futbol komandasi hansidir","Neftci","Sabah","Qarabag","Qarabag"},
            {"“Tarixin atası” adı kimə verilmişdir?","Plutarx","Homer","Herodot","Herodot"},
            {"Hammurapinin “Qanunlar məcəlləsi” neçə maddədən ibarət olub?","1200","15","382","382"},
            {"“Modernizm” neçəci əsrdə, harada meydana gəlmişdir?","V-VII əsrlərdə, Şərqdə.","XIX-XX əsrlərdə, Avropada.","XVI əsrdə, Hindistanda.","XIX-XX əsrlərdə, Avropada."},
            {"“Nizami” operasının müəllifi kimdir?","Ə.Bədəlbəyli.","Niyazi.","Ü.Hacıbəyov.","Ə.Bədəlbəyli."},
            {"Kim Sokratı “əsrin zəkası” adlandırmışdır?","Aristotel.","Platon."," Kratil.","Platon."},
            {"Qərbi Avropada neçənci əsrdə “Humanizm hərəkatı” genişlənmişdir?","XIV əsrdə","XX əsrdə.","XV əsrdə.","XV əsrdə."},
            {"Knyaz Vladimir neçənci ildə pravoslav dinini qəbul edib?","993-cü ildə.","988-ci ildə.","561-ci ildə.","988-ci ildə."},
            {"“Bibliya” toplu olaraq neçə kitabdan ibarətdir?","2 kitab.","15 kitab.","66 kitab.","66 kitab."}
        };
        
        int point = 0;
        for (int i = 0; i < quiz.GetLength(0); i++){
            int[] arr = Rand();
            Console.WriteLine(quiz[i, 0]);
                for (int j = 0; j < 3; j++){
                    int temp = arr[j];
                     Console.WriteLine($"{(char)('A' + j)} {quiz[i,temp]} ");    
                }
                Console.Write("Enter Quiz Answer: ");
                string ans = Console.ReadLine().ToUpper();
                switch (ans){
                     case "A" when quiz[i, arr[0]] == quiz[i, 4]:
                     case "B" when quiz[i, arr[1]] == quiz[i, 4]:
                     case "C" when quiz[i, arr[2]] == quiz[i, 4]:
                        point += 10;
                        break;
                    default:
                        point -= 10;
                        break;
                }
                Console.WriteLine();
                point =  point < 0 ? point = 0 : point;

        }
        Console.WriteLine("Total Point: " + point);
    }
}
