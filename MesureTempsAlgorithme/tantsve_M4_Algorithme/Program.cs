// See https://aka.ms/new-console-template for more information

Random aleatoire = new Random();
List<int> BigList = new List<int>();

for (int i = 0; i < 1000; i++)
{
    int nbr = aleatoire.Next(100000, 999999);
    BigList.Add(nbr);
}
var DateStart = DateTime.Now;
#region BubbleSort

List<int> array = BigList;
Console.WriteLine("------- BubbleSort -------");
for (int i = 0; i < array.Count; i++)
{
    showArray(array);
    for (int j = 0; j < array.Count - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }

    }
}
foreach(int nbr in array)
{
    Console.Write($"{nbr} | ");
}

#endregion

#region Tri par insertion
/*
//int[] array_tpi = { 1, 7, 3, 2, 0, 5, 0, 8 };
List<int> array_tpi = BigList;
Console.WriteLine("------- Tri par insertion -------");

showArray(array_tpi);

for (int cptPassage = 1; cptPassage < array_tpi.Count; cptPassage++)
{
    int nbreAInserer = array_tpi[cptPassage];
    int posRech = cptPassage;
    while (posRech - 1 >= 0 && nbreAInserer < array_tpi[posRech - 1])
    {
        array_tpi[posRech] = array_tpi[posRech - 1];
        posRech--;
    }
    array_tpi[posRech] = nbreAInserer;

    showArray(array_tpi);
}
showArray(array_tpi);
*/
#endregion

#region Tri par sélection

//int[] array_tps = { 1, 7, 3, 2, 0, 5, 0, 8 };
/*
Console.WriteLine("------- Tri par sélection -------");
List<int> array_tps = BigList;
showArray(array_tps);

for (int indexPosition = 0; indexPosition < array_tps.Count; indexPosition++)
{
    int indexDuMin = indexPosition;

    for (int indexNombreAComparer = indexPosition; indexNombreAComparer < array_tps.Count; indexNombreAComparer++)
    {
        if (array_tps[indexNombreAComparer] < array_tps[indexDuMin])
            indexDuMin = indexNombreAComparer;
    }

    if (indexPosition != indexDuMin)
    {
        int temp = array_tps[indexPosition];
        array_tps[indexPosition] = array_tps[indexDuMin];
        array_tps[indexDuMin] = temp;
    }
    showArray(array_tps);
}
*/
#endregion

var DateEnd = DateTime.Now;
//double finTempsTri = (double)DateEnd;


Console.WriteLine($"\n{resultTime(DateStart, DateEnd)} pour effectuer le tri.");

static void showArray(List<int> array)
{
    //foreach (int item in array)
    //{
    //    if (item < array.Count)
    //        Console.Write(item + " - ");
    //    else
    //        Console.Write(item);
    //}
    //Console.WriteLine("\n--------------");
}



static double resultTime(DateTime start, DateTime end)
{
    var Time = end - start;
    return Time.TotalSeconds;
}






