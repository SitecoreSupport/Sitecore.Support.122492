using Sitecore.Analytics.Tracking.Diagnostics.PerformanceCounters;
using Sitecore.Diagnostics;
using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.Support.Analytics.Pipelines.StartAnalytics
{
    public class CheckPreconditions : Sitecore.Analytics.Pipelines.StartAnalytics.CheckPreconditions
    {
        public override void Process(PipelineArgs args)
        {
            base.Process(args);
            if (Sitecore.Context.PageMode.IsExperienceEditor | Sitecore.Context.PageMode.IsPreview | Sitecore.Context.PageMode.IsDebugging)
            {
                args.AbortPipeline();
            }
        }
    }
}