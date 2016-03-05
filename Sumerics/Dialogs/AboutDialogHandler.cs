﻿namespace Sumerics.Dialogs
{
    using Sumerics.Views;
    using System;

    [DialogType(Dialog.About)]
    sealed class AboutDialogHandler : IDialogHandler
    {
        readonly IComponents _container;

        public AboutDialogHandler(IComponents container)
        {
            _container = container;
        }

        public void Open(params Object[] parameters)
        {
            this.Show<AboutWindow>();
        }

        public void Close()
        {
            this.Close<AboutWindow>();
        }
    }
}
