﻿/*
Copyright Mitratech Holdings Inc, 2021
This software is provided under the terms of a License Agreement and may
only be used and/or copied in accordance with the terms of such agreement.
Neither this software nor any copy thereof may be provided or otherwise
made available to any other person. No title or ownership of this software
is hereby transferred.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MS_WOPI.Response
{
    [DataContract]
    public class WopiCheckFileInfo
    {
        [DataMember]
        public bool AllowExternalMarketplace { get; set; }
        [DataMember]
        public string BaseFileName { get; set; }
        [DataMember]
        public string BreadcrumbBrandName { get; set; }
        [DataMember]
        public string BreadcrumbBrandUrl { get; set; }
        [DataMember]
        public string BreadcrumbDocName { get; set; }
        [DataMember]
        public string BreadcrumbDocUrl { get; set; }
        [DataMember]
        public string BreadcrumbFolderName { get; set; }
        [DataMember]
        public string BreadcrumbFolderUrl { get; set; }
        [DataMember]
        public string ClientUrl { get; set; }
        [DataMember]
        public bool CloseButtonClosesWindow { get; set; }
        [DataMember]
        public string CloseUrl { get; set; }
        [DataMember]
        public bool DisableBrowserCachingOfUserContent { get; set; }
        [DataMember]
        public bool DisablePrint { get; set; }
        [DataMember]
        public bool DisableTranslation { get; set; }
        [DataMember]
        public string DownloadUrl { get; set; }
        [DataMember]
        public string FileSharingUrl { get; set; }
        [DataMember]
        public string FileUrl { get; set; }
        [DataMember]
        public string HostAuthenticationId { get; set; }
        [DataMember]
        public string HostEditUrl { get; set; }
        [DataMember]
        public string HostEmbeddedEditUrl { get; set; }
        [DataMember]
        public string HostEmbeddedViewUrl { get; set; }
        [DataMember]
        public string HostName { get; set; }
        [DataMember]
        public string HostNotes { get; set; }
        [DataMember]
        public string HostRestUrl { get; set; }
        [DataMember]
        public string HostViewUrl { get; set; }
        [DataMember]
        public string IrmPolicyDescription { get; set; }
        [DataMember]
        public string IrmPolicyTitle { get; set; }
        [DataMember]
        public string OwnerId { get; set; }
        [DataMember]
        public string PresenceProvider { get; set; }
        [DataMember]
        public string PresenceUserId { get; set; }
        [DataMember]
        public string PrivacyUrl { get; set; }
        [DataMember]
        public bool ProtectInClient { get; set; }
        [DataMember]
        public bool ReadOnly { get; set; }
        [DataMember]
        public bool RestrictedWebViewOnly { get; set; }
        [DataMember]
        public string SHA256 { get; set; }
        [DataMember]
        public string SignoutUrl { get; set; }
        [DataMember]
        public long Size { get; set; }
        [DataMember]
        public bool SupportsCoauth { get; set; }
        [DataMember]
        public bool SupportsCobalt { get; set; }
        [DataMember]
        public bool SupportsFolders { get; set; }
        [DataMember]
        public bool SupportsLocks { get; set; }
        [DataMember]
        public bool SupportsScenarioLinks { get; set; }
        [DataMember]
        public bool SupportsSecureStore { get; set; }
        [DataMember]
        public bool SupportsUpdate { get; set; }
        [DataMember]
        public string TenantId { get; set; }
        [DataMember]
        public string TermsOfUseUrl { get; set; }
        [DataMember]
        public string TimeZone { get; set; }
        [DataMember]
        public bool UserCanAttend { get; set; }
        [DataMember]
        public bool UserCanNotWriteRelative { get; set; }
        [DataMember]
        public bool UserCanPresent { get; set; }
        [DataMember]
        public bool UserCanWrite { get; set; }
        [DataMember]
        public string UserFriendlyName { get; set; }
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string Version { get; set; }
        [DataMember]
        public bool WebEditingDisabled { get; set; }
    }
}
