using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;

namespace FirstDemo.iOS.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class MainView : MvxViewController
    {
        public MainView() : base("MainView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<MainView, Core.ViewModels.MainViewModel>();
            set.Bind(textEditFirst).To(vm => vm.FirstName);
            set.Bind(textEditSecond).To(vm => vm.LastName);
            set.Bind(labelFull).To(vm => vm.FullName);
            set.Apply();
        }
    }
}
