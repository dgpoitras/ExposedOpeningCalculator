using RevitAddIn_ExposedOpeningCalc.ViewModels;

namespace RevitAddIn_ExposedOpeningCalc.Views
{
    public sealed partial class RevitAddIn_ExposedOpeningCalcView
    {
        public RevitAddIn_ExposedOpeningCalcView(RevitAddIn_ExposedOpeningCalcViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}