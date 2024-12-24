namespace LINQINTRO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Douglas", Email = "douglasonyil91@gmail.com"},
                new Employee(){Id = 2, Name = "Onyil", Email = "onyil@gmail.com"},
                new Employee(){Id = 3, Name = "Mercy", Email = "mercyogutu@gmail.com"},
                new Employee(){Id = 4, Name = "Ogutu", Email = "ogutu@gmail.com"}
            };

            var basicQuery = (from emp in employees
                             select emp).ToList();

            var basicMethod = employees.ToList();

            foreach (var emp in basicMethod)
            {
                Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, and Email = {emp.Email}");
            }
            Console.WriteLine();

            foreach (var emp in basicQuery)
            {
                Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name} and Email = {emp.Email}");
            }
        }
    }
}
