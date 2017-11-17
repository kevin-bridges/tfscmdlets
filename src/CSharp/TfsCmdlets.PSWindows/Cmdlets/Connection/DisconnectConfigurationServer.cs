using System.Management.Automation;
using Microsoft.TeamFoundation.Client;

namespace TfsCmdlets.Cmdlets.Connection
{
    /*
    <#
    .SYNOPSIS
    Disconnects from the currently connected configuration server.

    .DESCRIPTION
    The Disconnect-TfsConfigurationServer cmdlet removes the global variable set by Connect-TfsConfigurationServer. Therefore, cmdlets relying on a "default server" as provided by "Get-TfsConfigurationServer -Current" will no longer work after a call to this cmdlet, unless their -Server argument is provided or a new call to Connect-TfsConfigurationServer is made.

    .EXAMPLE
    Disconnect-TfsConfigurationServer
    Disconnects from the currently connected TFS configuration server

    #>
    */
    [Cmdlet(verbName: VerbsCommunications.Disconnect, nounName: "ConfigurationServer")]
    public class DisconnectConfigurationServer : Cmdlet
    {
        protected override void ProcessRecord()
        {
            CurrentConnections.ConfigurationServer = null;
        }
    }
}