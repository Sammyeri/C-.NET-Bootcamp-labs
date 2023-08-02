int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

//find minimum value
int min = nums.Min();
Console.WriteLine(min);
Console.WriteLine("------------------------------");

//find max value
int max = nums.Max();
Console.WriteLine(max);
Console.WriteLine("------------------------------");

//find max less than 10,000
var maxLimited = nums.Where(a => a <= 10000).Max();
Console.WriteLine(maxLimited);
Console.WriteLine("------------------------------");

//find all values between 10 and 100
var betweenTenAndHundred = nums.Where(b => b <= 100).Where(c => c >= 10).ToList();
betweenTenAndHundred.ForEach(c => Console.WriteLine(c));
Console.WriteLine("------------------------------");

//find all values between 100, 000 and 999, 999 inclusive
var largeNums = nums.Where(d => d <= 999999).Where(e => e >= 100000).ToList();
largeNums.ForEach(f => Console.WriteLine(f));
Console.WriteLine("------------------------------");

//count all the even numbers
int evenCount = nums.Where(g => g % 2 == 0).Count();
Console.WriteLine(evenCount);
Console.WriteLine("------------------------------");