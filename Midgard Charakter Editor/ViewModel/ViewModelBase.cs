using System;
using ReactiveUI;
using Splat;

namespace MidgardCharakterEditor.ViewModel
{
    public class ViewModelBase : ReactiveObject, IRoutableViewModel
    {
        public string  UrlPathSegment { get; }
        public IScreen HostScreen     { get; }

        public ViewModelBase(string urlPathSegment, IScreen screen = null)
        {
            UrlPathSegment = urlPathSegment ?? throw new ArgumentNullException(nameof(urlPathSegment));
            HostScreen     = screen ?? Locator.Current.GetService<IScreen>();
        }
    }
}