/* Console.WriteLine("ЗАДАЧА 64.1");
int n = 5;

f1(n);

void f1(int n1) {
    Console.WriteLine (n1);
    if (n1 > 1) { f1(n1 - 1);}
}
*/

/* Console.WriteLine("ЗАДАЧА 64.2");
int n = 8;

f1(n);

void f1(int n1) {
    Console.WriteLine (n1);
    if (n1 > 1) { f1(n1 - 1);}
}*/

/* Console.WriteLine("ЗАДАЧА 66.1");
int n = 1;
int m = 15;
Console.WriteLine(f1(n));

int f1(int n1)
{
    if (n1 < m)
    {
        return n1 + f1(n1 + 1);
    }
    return n1;
}
*/

/* Console.WriteLine("ЗАДАЧА 66.2");
int n = 1;
int m = 15;
Console.WriteLine(f1(n));

int f1(int n1)
{
    if (n1 < m)
    {
        return n1 + f1(n1 + 1);
    }
    return n1;
}
*/

/* Console.WriteLine("ЗАДАЧА 68.1");
int m = 2;
int n = 3;
Console.WriteLine(af(m, n));

int af(int m1, int n1)
{
    if (m1 == 0) {
        return n1 + 1;
    }
    if (n1 == 0) {
        return af(m1 - 1, 1);
    }
    n1 = af(m1, n1 - 1);
    return af(m1 - 1, n1);
}
*/

/* Console.WriteLine("ЗАДАЧА 68.2");
int m = 3;
int n = 2;
Console.WriteLine(af(m, n));

int af(int m1, int n1)
{
    if (m1 == 0) {
        return n1 + 1;
    }
    if (n1 == 0) {
        return af(m1 - 1, 1);
    }
    n1 = af(m1, n1 - 1);
    return af(m1 - 1, n1);
}
*/
