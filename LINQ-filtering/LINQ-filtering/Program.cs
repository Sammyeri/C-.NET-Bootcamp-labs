using LINQ_filtering;

List<Student> studentList = new List<Student>()
{
    new Student() { name = "Steve Rogers" , age = 100, studentId = "A1003B"},
    new Student() {name = "Natasha Romanov", age = 32, studentId = "P90237"},
    new Student() {name = "Tony Stark", age = 30, studentId ="OI9302" },
    new Student() {name = "Thor Odinson", age = 500, studentId = "938S39" },
    new Student() {name = "Hank Banner", age = 45, studentId ="09TF23" },
    new Student() {name = "Loki", age = 498, studentId ="093823" },
    new Student() {name = "America Chavez", age = 15, studentId = "AIJ39382"}
};

//aggregate 
//sum, average, min, max

//LINQ query
var ageLsit = studentList.Select(x => x.age).ToList();

foreach(int age in ageLsit)
{
    Console.WriteLine(age);
}
//what averngers are over 30?

//where is for filtering data
var averngersOver30 = studentList.Where(x => x.age >= 30 && x.studentId.StartsWith('9')).ToList();

foreach(Student student in averngersOver30)
{
    Console.WriteLine(student.name);
}

var averageAge2 = studentList.Select(y => y.age).Average();

Console.WriteLine(averageAge2);

//what is the average age of an avenger?
double averageAge = studentList.Average(x => x.age);
Console.WriteLine(Convert.ToInt32(averageAge));


var oldestAvernger = studentList.Select(x => x.age).Max();
Console.WriteLine($"The oldest avenger is : {oldestAvernger} years old");

Console.WriteLine(studentList.Where(x => x.age > 30).Count());

