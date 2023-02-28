﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Ssh.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.Ssh.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Azure PowerShell doesn&apos;t currently support AAD login for Service Principal accounts. Provide a -LocalUser..
        /// </summary>
        internal static string AADLoginForServicePrincipal {
            get {
                return ResourceManager.GetString("AADLoginForServicePrincipal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is a directory, unable to write config file in that path. Provide a valid path for a file..
        /// </summary>
        internal static string ConfigFilePathIsDirectory {
            get {
                return ResourceManager.GetString("ConfigFilePathIsDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Config file destination folder {0} does not exist..
        /// </summary>
        internal static string ConfigFolderDoesNotExist {
            get {
                return ResourceManager.GetString("ConfigFolderDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create default endpoint for the target Arc Server with error: {0}..
        /// </summary>
        internal static string FailedToCreateDefaultEndpoint {
            get {
                return ResourceManager.GetString("FailedToCreateDefaultEndpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create default connectivty endpoint for target resource with an Authorization failure. This is a one time operation that must be performed by someone with Owner or Contributor role before anyone can connect to this resource. Contact the owner of the resource to create the connectivity endpoint. Instructions here: https://aka.ms/ssharc/create-default-endpoint.
        /// </summary>
        internal static string FailedToCreateDefaultEndpointUnauthorized {
            get {
                return ResourceManager.GetString("FailedToCreateDefaultEndpointUnauthorized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Couldn&apos;t delete old version of the Proxy File: {0}. Error: {1}.
        /// </summary>
        internal static string FailedToDeleteOldProxy {
            get {
                return ResourceManager.GetString("FailedToDeleteOldProxy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to download client proxy executable from {0}. Error: {1}.
        /// </summary>
        internal static string FailedToDownloadProxy {
            get {
                return ResourceManager.GetString("FailedToDownloadProxy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ListCredentials operation failed with error code &apos;{0}&apos;..
        /// </summary>
        internal static string FailedToListCredentials {
            get {
                return ResourceManager.GetString("FailedToListCredentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KeysDestinationFolder can&apos;t be used in conjunction with PublicKeyFile or PrivateKeyFile. All generated keys are saved in the same directory as provided keys..
        /// </summary>
        internal static string KeysDestinationFolderWithKeys {
            get {
                return ResourceManager.GetString("KeysDestinationFolderWithKeys", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to list resources in the {0} Resource Group because API call returned a null object. Please try again and contact support..
        /// </summary>
        internal static string ListResourcesArgumentNullException {
            get {
                return ResourceManager.GetString("ListResourcesArgumentNullException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to list resources in the {0} Resource Group with error: &quot;{1}&quot;. Ensure that the Resource Group Name is correct and that you have Read role on that resource group..
        /// </summary>
        internal static string ListResourcesCloudException {
            get {
                return ResourceManager.GetString("ListResourcesCloudException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please make sure SSH port is allowed using &quot;azcmagent config list&quot; in the target Arc Server. Ensure SSHD is running on the target machine..
        /// </summary>
        internal static string MakeSurePortIsEnabled {
            get {
                return ResourceManager.GetString("MakeSurePortIsEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find Remote Desktop Client (mstsc.exe). Make sure to update the PATH environment variable to make client discoverable..
        /// </summary>
        internal static string MstscClientNotFound {
            get {
                return ResourceManager.GetString("MstscClientNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is more than one resource named &quot;{0}&quot; in the Resource Group &quot;{1}&quot;. Please provide -ResourceType so that this cmdlet can identify the correct target resource..
        /// </summary>
        internal static string MultipleResourcesWithSameName {
            get {
                return ResourceManager.GetString("MultipleResourcesWithSameName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find OpenSSH Client. Make sure to update the PATH environment variable to make OpenSSH client discoverable..
        /// </summary>
        internal static string OpenSSHClientNotFound {
            get {
                return ResourceManager.GetString("OpenSSHClientNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The -Rdp parameter is only supported on Windows OS..
        /// </summary>
        internal static string RDPOnNonWindowsClient {
            get {
                return ResourceManager.GetString("RDPOnNonWindowsClient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find Resource &quot;{0}&quot; in the ResourceGroup &quot;{1}&quot;. Make sure the resource exists, that you have Read rights, and that the target resource is of one of the Resource Types supported by this cmdlet..
        /// </summary>
        internal static string ResourceNotFoundNoTypeProvided {
            get {
                return ResourceManager.GetString("ResourceNotFoundNoTypeProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find Resource &quot;{0}&quot; of type &quot;{1}&quot; in the Resource Group &quot;{2}&quot;. Make sure the resource exists and that you have Read rights..
        /// </summary>
        internal static string ResourceNotFoundTypeProvided {
            get {
                return ResourceManager.GetString("ResourceNotFoundTypeProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To authenticate with a certificate you must provide a LocalUser. The certificate will be ignored..
        /// </summary>
        internal static string WarningCertificateWithNoLocalUser {
            get {
                return ResourceManager.GetString("WarningCertificateWithNoLocalUser", resourceCulture);
            }
        }
    }
}
