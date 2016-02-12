﻿namespace Sumerics
{
    using MahApps.Metro.Controls;
    using YAMP;

	/// <summary>
	/// Interaction logic for PlotSettingsWindow.xaml
	/// </summary>
	public partial class SubPlotSettingsWindow : MetroWindow
	{
        public SubPlotSettingsWindow(SubPlotValue value)
		{
            InitializeComponent();
            DataContext = new SubPlotSettingsViewModel(value);
		}
	}
}
