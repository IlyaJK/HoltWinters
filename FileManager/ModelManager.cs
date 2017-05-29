

namespace HoltWintersModel
{
    public class ModelManager
    {
        private static IData _dateManage;

        public static IData GetData()
        {
            return _dateManage ?? (_dateManage = new CurrentData());
        }
    }
}