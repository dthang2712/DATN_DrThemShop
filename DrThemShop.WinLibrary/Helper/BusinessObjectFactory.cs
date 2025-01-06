using Spring.Context.Support;
using System.Linq;

namespace DrThemShop.WinLibrary.Helper
{
    public class BusinessObjectFactory<T>
    {
        public static T GetBusinessObject()
        {
            var listItem = ContextRegistry.GetContext().GetObjectsOfType(typeof(T)).Values;
            return listItem.Cast<T>().FirstOrDefault();
        }
    }
}
