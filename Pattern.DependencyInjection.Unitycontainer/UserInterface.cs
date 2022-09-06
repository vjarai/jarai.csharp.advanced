namespace Jarai.CSharp.Pattern.DependencyInjection.Unitycontainer
{
    public class UserInterface
    {
        public UserInterface(ViewModel viewModel)
        {
            ViewModel = viewModel;
        }

        public ViewModel ViewModel { get; set; }
    }
}