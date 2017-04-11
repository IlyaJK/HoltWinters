using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace HoltWintersUI.Page
{
    public abstract class StepPage : UserControl
    {
        public bool Complete { get; private set; }

        public abstract void StepLoad();
        public abstract void Clear();

    }
}