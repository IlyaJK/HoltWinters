using HoltWintersController.PageController;
using HoltWintersUI.Page;

namespace HoltWintersUI
{
    public class StapFactory
    {
        public static StepPage GetStap(int k)
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