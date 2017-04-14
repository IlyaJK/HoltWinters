using System.Windows.Forms;
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
                    return new StepOne();
                case 2:
                    return new StepSecond();
                case 3:
                    return new StepThird();
                case 4:
                    return new StepFourth();
                case 5:
                    return new StepFifth();
                case 6:
                    return new StepSixth();
                case 7:
                    return new StepSeventh();
                case 8:
                    return new StepEighth();
                default:
                    return null;
            }
        }
    }
}