namespace DemoLibrary
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        double Salary { get; set; }

        void CalculatePerHourRate(int rank);
    }
}