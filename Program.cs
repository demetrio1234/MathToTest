namespace MathToTest;

class Program
{
    static void Main()
    {

        Controller.Controller controller = new Controller.Controller() { };

        try
        {
            controller.GetAndAssignParameters();
            controller.Operate();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

}
