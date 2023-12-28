using Serialization.BLL;
using Serialization.Model;
using System.Text.Json;

StudentBL studentBL = new StudentBL();

List<Student> studentsList = studentBL.getStudents();

string jsonStudent = JsonSerializer.Serialize(studentsList);

List<Student>? student = JsonSerializer.Deserialize<List<Student>>(jsonStudent);

Console.WriteLine(jsonStudent);

foreach (var itemList in student)
{
    Console.WriteLine($"Id: {itemList.IdStudent} Name: {itemList.Name} Age: {itemList.Age}");
}

Console.ReadKey();