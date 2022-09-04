using System.Windows;

namespace Configurator.Addin.Windows
{
    internal static class WindowHelpers
    {
        /// <summary>
        /// Register a dependency property with an owner type.
        /// Don't forget to change the owner when you copy-paste a control.
        /// </summary>
        /// <typeparam name="TOwnerType"></typeparam>
        /// <typeparam name="TPropertyType"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DependencyProperty RegisterProperty<TOwnerType, TPropertyType>(string name)
        {
            return DependencyProperty.Register(name, typeof(TPropertyType), typeof(TOwnerType));
        }

        /// <summary>
        /// Register a dependency property with an owner type.
        /// Don't forget to change the owner when you copy-paste a control.
        /// </summary>
        /// <typeparam name="TOwnerType"></typeparam>
        /// <typeparam name="TPropertyType"></typeparam>
        /// <param name="name"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static DependencyProperty RegisterProperty<TOwnerType, TPropertyType>(string name, object defaultValue)
        {
            return DependencyProperty.Register(name, typeof(TPropertyType), typeof(TOwnerType), new FrameworkPropertyMetadata(defaultValue));
        }
    }
}
