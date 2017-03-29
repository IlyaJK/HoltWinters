using System.Collections.Generic;
using System.Windows.Forms;

namespace HoltWintersController
{
    public class StepManager
    {
        private List<UserControl> _userControls;

        public StepManager()
        {
            _userControls = new List<UserControl>();
        }

        public void SetControl(UserControl userControl)
        {
            _userControls.Add(userControl);
        }

        

    }
}