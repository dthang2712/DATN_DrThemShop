using log4net;

namespace DrThem.Libary.BusinessObject
{
    public abstract class BaseSingleton<T> where T : BaseSingleton<T>, new()
    {
        /// <summary>
        /// 	Logger
        /// </summary>
        protected ILog _logger = null;

        private static T _instance = null;

        public BaseSingleton()
        {
            _logger = LogManager.GetLogger(this.GetType());
        }

        public static T GetInstance()
        {
            if (_instance == null)
            {
                _instance = new T();
            }

            return _instance;
        }
    }
}