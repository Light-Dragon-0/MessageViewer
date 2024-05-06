
string spacer = "            ";
void NL()
{
    Console.Write("\n" + spacer);
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

string Message = "Hello........\nI'm Very sorry about all i did before.........\nAnd........ I Promise you .....that i'll try my best to change it.....\nLove you.! .....<3";

Console.Write(spacer);

for (int i = 0;i < Message.Length;i++)
{
    Thread.Sleep(75);
    switch(Message[i])
    {
        case '\\':
            i++;
            Console.Write(Message[i]);
            break;
        case '.':
            Thread.Sleep(100);
            break;
        case '\n':
            Thread.Sleep(250);
            NL();
            break;
        default:
            Console.Write(Message[i]);
            break;
    }
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


