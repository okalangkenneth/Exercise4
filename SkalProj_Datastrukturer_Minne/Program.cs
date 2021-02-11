using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Datastrukturer och minneseffektivitet
 * 
*   1.Heap är ett område där minne tilldelas eller delas om utan någon ordning. Detta händer när man skapar 
*    ett objekt med den new operatören eller något liknande. Detta är i motsats till stack där minnet delas ut på den 
*    FILO eller LIFO sätt. Ett exempel är på tallrikar staplade över varandra i en matsal. Plattan som är upptill är den första som tas bort, 
*    dvs plattan som har placerats i det nedre läget förblir i stapeln under den längsta tiden.
*    
*  2.När det gäller minneshantering, strukturer är vad vi kallar Value Types medan klasser är Reference Types.
* 
*  3.När man skapar en variabel som är en Value Type int x, tilldelas en del av minnet som kallas Stack för det variabel.Denna minnestilldelning 
*    görs automatiskt.När denna variabel går utanför räckvidden kommer 3 omedelbart att tas bort från Stacken med runtime eller C-L. Med 
*    Reference Types MyValue, måste man programmer själv tilldela minne med hjälp av new opertören och detta händer från ett annat område i
*    minnet som kallas Heap och 4 kommer att finnas kvar i minnet för en stund.Det är Garbage Collection som är gort av C-L som tar hand av det */

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }

            }

            /// <summary>
            /// Examines the datastructure List
            /// </summary>
            static void ExamineList()
            {
                /*
                 * Loop this method untill the user inputs something to exit to main menue.
                 * Create a switch statement with cases '+' and '-'
                 * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
                 * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
                 * In both cases, look at the count and capacity of the list
                 * As a default case, tell them to use only + or -
                 * Below you can see some inspirational code to begin working.
                */

                List<string> myList = new List<string>();
                while (true) // Loops indefinitly
                {
                    Console.WriteLine("Please make a choice");
                    Console.WriteLine("1) Make addition to list with a +");
                    Console.WriteLine("2) Make a subtraction from list with a -");
                    Console.WriteLine("3 Exit");

                    string input = Console.ReadLine();
                    char nav = input[0];
                    string value = input.Substring(1);

                    switch (nav)
                    {
                        case '+':

                            myList.Add(value);
                            Console.WriteLine();
                            foreach (string list in myList)
                            {
                                Console.WriteLine($"Elements after (+): {list}");
                            }
                            Console.WriteLine($"\nCount after (+) : {myList.Count}");
                            Console.WriteLine($"Capacity after (+) : {myList.Capacity}");
                            Console.WriteLine();

                            break;
                        case '-':

                            myList.Remove(value);
                            foreach (string list in myList)
                            {
                                Console.WriteLine($"Elements after (-) : {list}");
                            }
                            Console.WriteLine($"\nCount after (-) : {myList.Count}");
                            Console.WriteLine($"Capacity  after (-) : {myList.Capacity}");
                            Console.WriteLine();
                            break;

                        default:
                            Console.WriteLine("Invalid Operator.Use only + or -");
                            break;

                    }/*1. Skriv klart implementationen av ExamineList-metoden så att undersökningen blir
                          genomförbar.
                       2. När ökar listans kapacitet? (Alltså den underliggande arrayens storlek)
                          Listan kapacitet ökar när man lägga mer elementer. 

                       3. Med hur mycket ökar kapaciteten?
                          Med 2 gånger den initiala kapacitet

                       4. Varför ökar inte listans kapacitet i samma takt som element läggs till?
                          Eftersom den har en viss mängd element som den kan lagra innan den ändrar storlek
                          
                       5. Minskar kapaciteten när element tas bort ur listan?
                          Nej det minskar inte.

                       6. När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
                          När man vet att data är fast längd, och vill optimera den för en mycket specifik anledning
                          anars det bätra att använda lista.
                    */
                }
            }

            /// <summary>
            /// Examines the datastructure Queue
            /// </summary>
            /// 
            /// 
            //1. Simulera följande kö på papper:
            //a. ICA öppnar och kön till kassan är tom
            //b. Kalle ställer sig i kön
            //c. Greta ställer sig i kön
            //d. Kalle blir expedierad och lämnar kön
            //e. Stina ställer sig i kön
            //f. Greta blir expedierad och lämnar kön
            //g. Olle ställer sig i kön
            //h. …

            //2. Implementera metoden TestQueue. Metoden ska simulera hur en kö fungerar
            //genom att tillåta användaren att ställa element i kön (enqueue) och ta bort element
            //ur kön (dequeue). Använd Queue-klassen till hjälp för att implementera metoden.
            //Simulera sedan ICA-kön med hjälp av ditt program.
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
             */
            static void ExamineQueue()
            {
                {
                    TestQueue();
                }

                static void TestQueue()
                {

                }

                Queue<string> myqueue = new Queue<string>();
                int userInput = -1;
                do
                {
                    Console.WriteLine("Please choose your request");
                    Console.Write("1. Enqueue\n");
                    Console.Write("2. Dequeue\n");
                    Console.Write("3. Display names in queue\n");
                    Console.Write("5. Exit\n");

                    if (!int.TryParse(Console.ReadLine(), out userInput))

                    {
                        Console.Write("Invalid input.Try again");
                        continue;
                    }
                    switch (userInput)
                    {
                        case 1:
                            Console.Write("Enter name");
                            myqueue.Enqueue(Console.ReadLine());
                            break;
                        case 2:
                            if (myqueue.Count() > 0)
                            {
                                string name = myqueue.Dequeue();
                                Console.WriteLine("{0} removed from queue", name);
                            }
                            else
                            {
                                Console.WriteLine("Queue is empty");
                            }
                            break;
                        case 3:
                            Console.WriteLine();
                            myqueue.ToArray();
                            //ForEach(name => Console.WriteLine(name));
                            foreach (var item in myqueue)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        case 0:
                            break;

                    }
                }
                while (userInput != 0);
                Console.WriteLine("You may quit the application");

            }

        }

        static void ExamineStack()
        {

            Stack st = new Stack();

            static void ReverseText()
            {
                var reversedStr = "";
                Stack myStack = new Stack();

                Console.WriteLine("Default value will be: Please enter your text");
                Console.WriteLine("Enter your data to Reverse otherwise just Hit Enter");
                string sampleText = Console.ReadLine();

                //if (string.IsNullOrEmpty(sampleText))
                //    sampleText = "Please enter your text";

                Console.WriteLine(" ");
                Console.WriteLine($"Original Text: {sampleText}");
                Console.WriteLine(" ");

                foreach (var t in sampleText)
                    myStack.Push(t);

                while (myStack.Count > 0)
                    reversedStr += myStack.Pop();



                Console.WriteLine($"Reversed Text : {reversedStr}");

            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 Add an element");
                Console.WriteLine("2 See the top element");
                Console.WriteLine("3 Remove top element");
                Console.WriteLine("4 Dispaly stack element");
                Console.WriteLine("5 ReverseText");
                Console.WriteLine("6 Exit");
                Console.Write("Select your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an element:");
                        st.Push(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Top elemet is:{0}", st.Peek());
                        break;
                    case 3:
                        Console.WriteLine("Element removed:{0}", st.Pop());
                        break;
                    case 4:

                        break;
                    case 5:
                        ReverseText();
                        break;
                    case 6:
                        System.Environment.Exit(1);
                        break;
                }
                Console.ReadLine();
            }

            /*2. Implementera en ReverseText-metod som läser in en sträng från användaren och
                 med hjälp av en stack vänder ordning på teckenföljden för att sedan skriva ut den
                 omvända strängen till användaren.
             */





        }

        private static void CheckParanthesis()
        {
            {


                Stack<char> mypara = new Stack<char>();

                Console.WriteLine("Pleas enter a word containing brackets");
                string input = "";


                // Testa varje karakter i sträng input
                foreach (var character in input)
                {
                    switch (character)
                    {
                        // När du öppnar fästet, push in det i stacken
                        case '{':
                        case '[':
                        case '(':
                            mypara.Push(character);
                            break;
                        // När du stänger parentes, pop den och testa den.
                        case '}':
                        case ']':
                        case ')':

                            var stored = mypara.Pop();
                            // Om det poppade objektet inte matchar misslyckades kontrollen
                            if (stored == '{' && character != '}' ||
                               stored == '[' && character != ']' ||
                               stored == '(' && character != ')')
                            {
                                Console.WriteLine(); 
                            }
                            break;

                        default:
                            { }
                            break;
                            {
                                // Om kontrollen har inte misslyckat ännu, inmatningen är ok
                                //Console.WriteLine();
                            }
                    }

                }

            }

        }


    /// <summary>
    /// Examines the datastructure Stack
    /// </summary>
    /// 
    /*
      * Loop this method until the user inputs something to exit to main menue.
      * Create a switch with cases to push or pop items
      * Make sure to look at the stack after pushing and and poping to see how it behaves
     */
    
    


        /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        /* 1. Skapa med hjälp av er nya kunskap funktionalitet för att kontrollera en välformad
        *sträng på papper.Du ska använda dig av någon eller några av de datastrukturer vi
        *precis gått igenom.Vilken datastruktur använder du?
        *
        *Jag ska använda Stack
        *
        * 2.Implementera funktionaliteten i metoden CheckParantheses. Låt programmet läsa
        * in en sträng från användaren och returnera ett svar som reflekterar huruvida
        * strängen är välformad eller ej.
        */

        
    }
}



      








