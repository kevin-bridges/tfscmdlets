using System.Management.Automation;

namespace TfsCmdlets.Cmdlets.WorkItemType
{
    [Cmdlet(VerbsCommon.Get, "WorkItemType")]
    [OutputType(typeof(Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemType))]
    public class GetWorkItemType : WorkItemTypeBaseCmdlet
    {
        protected override void ProcessRecord()
        {
            WriteObject(GetWits(), true);
        }

        [Parameter(Position = 0)]
        [SupportsWildcards]
        [Alias("Name")]
        public override object Type { get; set; } = "*";

        [Parameter(ValueFromPipeline = true)]
        public override object Project { get; set; }
    }
}