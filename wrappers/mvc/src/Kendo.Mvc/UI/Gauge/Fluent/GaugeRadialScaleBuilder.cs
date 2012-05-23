using Kendo.Mvc.Infrastructure;
using System;
namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent interface for configuring the gauge scale.
    /// </summary>
    public class GaugeRadialScaleBuilder<T> : GaugeScaleBuilderBase<IRadialScale<T>, GaugeRadialScaleBuilder<T>, T>
        where T : struct
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GaugeRadialScaleBuilder{T}" /> class.
        /// </summary>
        /// <param name="gauge">The gauge component.</param>
        public GaugeRadialScaleBuilder(RadialGauge<T> gauge)
            : base(gauge.Scale)
        {
            radialGauge = gauge;
        }

        /// <summary>
        /// The parent Guage
        /// </summary>
        public RadialGauge<T> radialGauge
        {
            get;
            private set;
        }

        /// <summary>
        /// Sets the end angle of the gauge
        /// </summary>
        /// <param name="endAngle">The end angle.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().RadialGauge()
        ///            .Name("radialGauge")
        ///            .Scale(scale => scale
        ///                .EndAngle(10)
        ///            )
        /// %&gt;
        /// </code>
        /// </example>        
        public GaugeRadialScaleBuilder<T> EndAngle(double endAngle)
        {
            radialGauge.Scale.EndAngle = endAngle;
            return this;
        }

        /// <summary>
        /// Sets the start angle of the gauge
        /// </summary>
        /// <param name="startAngle">The start Angle.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().RadialGauge()
        ///            .Name("radialGauge")
        ///            .Scale(scale => scale
        ///                .StartAngle(220)
        ///            )
        /// %&gt;
        /// </code>
        /// </example>        
        public GaugeRadialScaleBuilder<T> StartAngle(double startAngle)
        {
            radialGauge.Scale.StartAngle = startAngle;
            return this;
        }

        /// <summary>
        /// Configures the labels.
        /// </summary>
        /// <param name="configurator">The configuration action.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().RadialGauge()
        ///            .Name("radialGauge")
        ///            .Scale(scale => scale
        ///                .Labels(labels => labels
        ///                    .Visible(false)
        ///                )
        ///            )
        /// %&gt;
        /// </code>
        /// </example>
        public GaugeRadialScaleBuilder<T> Labels(Action<GaugeRadialScaleLabelsBuilder> configurator)
        {
            Guard.IsNotNull(configurator, "configurator");

            configurator(new GaugeRadialScaleLabelsBuilder(Scale.Labels));

            return this;
        }
    }
}