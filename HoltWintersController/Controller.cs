using HoltWintersModel;
using HoltWintersModel.FileManager;

namespace HoltWintersController
{
    public class Controller : IController
    {
        private readonly IData _data;

        public Controller() : this(ModelManager.GetData()){}
        public Controller(IData data)
        {
            _data = data;
        }

        public void Clear()
        {
            _data.Clear();
        }

        public bool LoadData()
        {
            return _data.LoadData();
        }
    }
}