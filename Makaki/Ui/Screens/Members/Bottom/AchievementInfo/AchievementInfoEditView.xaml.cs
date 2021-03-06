﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Makaki.Ui.Screens.Members.Bottom.AchievementInfo
{
    /// <summary>
    /// Interaction logic for AchievementInfoEditView.xaml
    /// </summary>
    public partial class AchievementInfoEditView : Window
    {
        public AchievementInfoEditView()
        {
            InitializeComponent();
        }

        public AchievementInfoEditView(AchievementInfoEditViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
