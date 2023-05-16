namespace MVCDemoRazor.Models
{
    public class Person
    {
        public string Nmae { get; set; }
        public int Age { get; set; }
        public Person()
        {
            
        }
        public Person(string nmae, int age)
        {
            Nmae = nmae;
            Age = age;
        }
    }
}
