namespace HoltWintersController.PageController
{
    public interface IStepOneController
    {
        double[,] GetStartData();
        double[,] GetDataKorel();
        double[] SolveYp();
        double[] GetYp();


        double[] Kramer(double a1, double a2, double a3, double a4, double a5, double a6);
        void SetKorni(double[] korni);
        double[] GetKorni();
    }
}