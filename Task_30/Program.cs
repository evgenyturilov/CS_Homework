// Показать кубы чисел, заканчивающихся на четную цифру

/*for(int i = 1; i < 10; i++)
{
    if(i%2 == 0)
    {
        System.Console.WriteLine(i*i*i); 
    }
}*/

int[] array = {3, 6, 7, 8, 9, 3, 12, 13};
for (int i = 0; i < array.Length; i++)
{
    if( array[i]%2 == 0)
    {
        System.Console.WriteLine("{0,8}{1,8}", array[i], Math.Pow(array[i], 3));
    }
}

