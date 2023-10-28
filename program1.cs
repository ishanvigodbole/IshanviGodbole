// See https://aka.ms/new-console-template for more information
int[]a = [21, 22, 67, 43, 12, 4];
for (int i = 0; i < 6; i++)
{
    int temp = a[i];
    a[i] = a[6 - i - 1];
    a[6 - i - 1] = temp;
}
for (int i = 0; i < 6; i++)
{

    Console.WriteLine(a[i]);
}
