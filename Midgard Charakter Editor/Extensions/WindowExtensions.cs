using System;
using System.Windows;
using ReactiveUI;
using Splat;

namespace MidgardCharakterEditor.Extensions
{
    public static class WindowExtensions
    {
        public static Window GetView<T>(this T viewModel) where T : ReactiveObject
        {
            var view = Locator.Current.GetService<IViewFor<T>>();
            view.ViewModel = viewModel;
            if (!(view is Window window))
                throw new TypeAccessException("View not implemented for IViewFor");
            return window;
        }    
    }
}