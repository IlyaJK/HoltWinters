using System.Windows.Forms;
using HoltWintersController.PageController;
using HoltWintersUI.Page;

namespace HoltWintersUI
{
    public class StepFactory
    {
        public static UserControl GetStap(int k)
        {
            switch (k)
            {
                case 1:
                    return new StepOne(new StepOneController());
                case 2:
                    return new StepSecond();
                default:
                    return null;
            }
        }
    }
}