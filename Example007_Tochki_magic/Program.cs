Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+"); 

int xa = 40; int ya = 0; 
int xb = 0; int yb = 30; 
int xc = 80; int yc = 30; 

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+"); 
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+"); 
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+"); 

int x = xa/2; int y = yb/2;
int count = 0;
while(count < 10000)
{
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    int what = new Random().Next(0, 3); // 0, 1, 2
    if(what == 0)    {        x = x + (xa-x)/2;        y = y/2;    }
    if(what == 1)    {        x = x/2;                 y = y + (yb-y)/2;    }
    if(what == 2)    {        x = x + (xc-x)/2;        y = y + (yc-y)/2;    }
count = count + 1;
}
