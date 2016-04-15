﻿namespace Sumerics.Plots
{
    using OxyPlot;
    using OxyPlot.Axes;
    using System;
    using YAMP;

	sealed class SumericsComplexPlot : SumericsOxyPlot
	{
		#region Fields

		readonly ComplexPlotValue _plot;

		#endregion

		#region ctor

		public SumericsComplexPlot(ComplexPlotValue plot) : 
            base(plot)
		{
			_plot = plot;
			SetSeries();
			SetProperties();
		}

		#endregion

		#region Properties

		public override Boolean IsGridEnabled
		{
			get { return false; }
		}

		public override Boolean IsSeriesEnabled
		{
			get { return false; }
		}

		#endregion

        #region Methods

        protected override void UpdateProperties()
        {
            var model = Model;

            model.Axes[0].Title = _plot.XLabel;
            model.Axes[1].Title = _plot.YLabel;

            model.Axes[0].Minimum = _plot.MinX;
            model.Axes[0].Maximum = _plot.MaxX;

            model.Axes[1].Minimum = _plot.MinY;
            model.Axes[1].Maximum = _plot.MaxY;
        }

        #endregion

        #region Helpers

        void SetSeries()
		{
			var series = new ComplexSeries(_plot.Fz);
			Model.Series.Add(series);
		}

		void SetProperties()
		{
            var model = Model;
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
			    Minimum = _plot.MinX,
			    Maximum = _plot.MaxX,
			    Title = _plot.XLabel
            });
            model.Axes.Add(new LinearAxis
            {
			    Position = AxisPosition.Left,
			    Minimum = _plot.MinY,
			    Maximum = _plot.MaxY,
			    Title = _plot.YLabel
            });		
		}

		#endregion
	}
}