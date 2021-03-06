﻿using LoginApp.ViewModels.Interfaces;
using LoginApp.Views.Interfaces;
using System.Windows.Controls;

namespace LoginApp.Views
{
    /// <summary>
    /// Interaction logic for LoginUserControl.xaml
    /// </summary>
    public partial class LoginUserControl : UserControl, ILoginUserControl
    {
        public LoginUserControl(ILoginViewModel viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
        }

        public UserControl ContentWindow => this;
    }
}
