﻿namespace Sumerics.Plots
{
    using System;
    using YAMP;

    sealed class SumericsSurfacePlot : Sumerics3DPlot
    {
        #region Fields

        readonly SurfacePlotValue _plot;

        #endregion

        #region ctor

        public SumericsSurfacePlot(SurfacePlotValue plot)
            : base(plot)
        {
            _plot = plot;
        }

        #endregion

        #region Properties

        public override Boolean IsSeriesEnabled
        {
            get { return false; }
        }

        #endregion
    }
}