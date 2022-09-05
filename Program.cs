int size = 5;
double [ ] array = new double [size];
for(int i =0; i <array.Length; i ++)
{                                           
 array[ i] = new Random().Next(0,100);
 }

Console.WriteLine(string.Join(",", array));
double maxValue = array.Max<double>();
double minValue = array.Min<double>();
 double result = maxValue - minValue; 
 Console.Write("Разность равна : ");
Console.WriteLine(result);