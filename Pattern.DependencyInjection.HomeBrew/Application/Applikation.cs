namespace Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Application
{
    public class Applikation
    {
        public Applikation(UserInterface userInterface)
        {
            UserInterface = userInterface;
        }

        public UserInterface UserInterface { get; set; }

        public void Run()
        {
           
        }
    }
}