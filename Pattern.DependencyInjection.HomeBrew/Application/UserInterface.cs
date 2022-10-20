namespace Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Application
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