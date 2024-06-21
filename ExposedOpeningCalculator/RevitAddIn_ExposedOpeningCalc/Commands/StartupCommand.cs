using Autodesk.Revit.Attributes;
using Nice3point.Revit.Toolkit.External;
using RevitAddIn_ExposedOpeningCalc.ViewModels;
using RevitAddIn_ExposedOpeningCalc.Views;

namespace RevitAddIn_ExposedOpeningCalc.Commands
{
    /// <summary>
    ///     External command entry point invoked from the Revit interface
    /// </summary>
    [UsedImplicitly]
    [Transaction(TransactionMode.Manual)]
    public class StartupCommand : ExternalCommand
    {
        public override void Execute()
        {
            var viewModel = new RevitAddIn_ExposedOpeningCalcViewModel();
            var view = new RevitAddIn_ExposedOpeningCalcView(viewModel);
            view.ShowDialog();
        }
    }
}