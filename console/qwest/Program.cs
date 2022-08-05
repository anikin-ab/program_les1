int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int maxnum = a;

if (a > maxnum) maxnum = a;
if (b > maxnum) maxnum = b;
if (c > maxnum) maxnum = c;
if (d > maxnum) maxnum = d;
if (e > maxnum) maxnum = e;
if (f > maxnum) maxnum = f;

Console.Write("maxnum = ");
Console.WriteLine(maxnum);