﻿using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JacksonVeroneze.Shopping.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible, IApplicationLifecycleAware, IInitialize
    {
        protected INavigationService _navigationService { get; private set; }

        private ViewModelState _viewModelState = new ViewModelState();
        public ViewModelState ViewModelState
        {
            get => _viewModelState;
            set => SetProperty(ref _viewModelState, value);
        }

        protected void UpdateViewModeStateData(IEnumerable<object> listData)
        {
            if (listData is null)
                return;

            ViewModelState.HasData = listData.Any() is true;
            ViewModelState.NoData = listData.Any() is false;
        }

        public ViewModelBase(INavigationService navigationService)
            => _navigationService = navigationService;

        public virtual void OnNavigatedFrom(INavigationParameters parameters) { }

        public virtual void OnNavigatedTo(INavigationParameters parameters) { }

        public virtual void Initialize(INavigationParameters parameters) { }

        public virtual void Destroy() { }

        public virtual void OnResume() { }

        public virtual void OnSleep() { }

        public virtual void OnDisappearing() { }

        internal virtual void OnBackButtonPressed() { }

        internal virtual Task OnBackButtonPressedAsync() => Task.CompletedTask;
    }
}