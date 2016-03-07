using System.Collections.Generic;
using System;
using AxWFICALib;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using AxMSTSCLib;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;
using mRemoteNG.Tools;
using System.ComponentModel;
using mRemoteNG.Tools;


namespace mRemoteNG.Connection
{
	public partial class Info
	{
		public class Inheritance
		{
            #region Public Properties
            #region General
            [LocalizedAttributes.LocalizedCategory("strCategoryGeneral", 1),
                LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameAll"),
                LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionAll"), 
                TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]
            public bool EverythingInherited
			{
				get
				{
					if (CacheBitmaps && Colors && Description && DisplayThemes && DisplayWallpaper 
						&& EnableFontSmoothing && EnableDesktopComposition && Domain && Icon && Password 
						&& Port && Protocol && PuttySession && RedirectDiskDrives && RedirectKeys 
						&& RedirectPorts && RedirectPrinters && RedirectSmartCards && RedirectSound && Resolution 
						&& AutomaticResize && UseConsoleSession && UseCredSsp && RenderingEngine && UserField 
						&& ExtApp && Username && Panel && ICAEncryption && RDPAuthenticationLevel 
						&& LoadBalanceInfo && PreExtApp && PostExtApp && MacAddress && VNCAuthMode 
						&& VNCColors && VNCCompression && VNCEncoding && VNCProxyIP && VNCProxyPassword 
						&& VNCProxyPort && VNCProxyType && VNCProxyUsername)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				set
				{
					SetAllValues(value);
				}
			}
            #endregion
            #region Display
			[LocalizedAttributes.LocalizedCategory("strCategoryDisplay", 2), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameDescription"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionDescription"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool Description {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryDisplay", 2), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameIcon"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionIcon"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool Icon {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryDisplay", 2), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNamePanel"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionPanel"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool Panel {get; set;}
            #endregion
            #region Connection
			[LocalizedAttributes.LocalizedCategory("strCategoryConnection", 3), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameUsername"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionUsername"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool Username {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryConnection", 3), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNamePassword"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionPassword"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool Password {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryConnection", 3), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameDomain"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionDomain"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool Domain {get; set;}
            #endregion
            #region Protocol
			[LocalizedAttributes.LocalizedCategory("strCategoryProtocol", 4), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameProtocol"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionProtocol"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool Protocol {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryProtocol", 4), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameExternalTool"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionExternalTool"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool ExtApp {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryProtocol", 4), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNamePort"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionPort"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool Port {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryProtocol", 4), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNamePuttySession"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionPuttySession"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool PuttySession {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryProtocol", 4), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameEncryptionStrength"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionEncryptionStrength"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool ICAEncryption {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryProtocol", 4), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameAuthenticationLevel"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionAuthenticationLevel"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool RDPAuthenticationLevel {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryProtocol", 4), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameLoadBalanceInfo"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionLoadBalanceInfo"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool LoadBalanceInfo {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryProtocol", 4), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameRenderingEngine"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionRenderingEngine"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool RenderingEngine {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryProtocol", 4), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameUseConsoleSession"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionUseConsoleSession"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool UseConsoleSession {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryProtocol", 4), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameUseCredSsp"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionUseCredSsp"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool UseCredSsp {get; set;}
            #endregion
            #region RD Gateway
			[LocalizedAttributes.LocalizedCategory("strCategoryGateway", 5),
                LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameRDGatewayUsageMethod"),
                LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionRDGatewayUsageMethod"), 
				TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]
            public bool RDGatewayUsageMethod {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryGateway", 5), 
				LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameRDGatewayHostname"), 
				LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionRDGatewayHostname"), 
				TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]
            public bool RDGatewayHostname {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryGateway", 5), 
				LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameRDGatewayUseConnectionCredentials"), 
				LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionRDGatewayUseConnectionCredentials"), 
				TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]
            public bool RDGatewayUseConnectionCredentials {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryGateway", 5), 
				LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameRDGatewayUsername"), 
				LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionRDGatewayUsername"), 
				TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]
            public bool RDGatewayUsername {get; set;}

            [LocalizedAttributes.LocalizedCategory("strCategoryGateway", 5), 
				LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameRDGatewayPassword"), 
				LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionRDGatewayPassword"), 
				TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]
            public bool RDGatewayPassword {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryGateway", 5), 
				LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameRDGatewayDomain"), 
				LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionRDGatewayDomain"), 
				TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]
            public bool RDGatewayDomain {get; set;}
            #endregion
            #region Appearance
			[LocalizedAttributes.LocalizedCategory("strCategoryAppearance", 6), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameResolution"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionResolution"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool Resolution {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryAppearance", 6), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameAutomaticResize"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionAutomaticResize"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool AutomaticResize {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryAppearance", 6), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameColors"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionColors"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool Colors {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryAppearance", 6), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameCacheBitmaps"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionCacheBitmaps"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool CacheBitmaps {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryAppearance", 6), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameDisplayWallpaper"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionDisplayWallpaper"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool DisplayWallpaper {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryAppearance", 6), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameDisplayThemes"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionDisplayThemes"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool DisplayThemes {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryAppearance", 6), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameEnableFontSmoothing"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionEnableFontSmoothing"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool EnableFontSmoothing {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryAppearance", 6), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameEnableDesktopComposition"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionEnableEnableDesktopComposition"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool EnableDesktopComposition {get; set;}
            #endregion
            #region Redirect
			[LocalizedAttributes.LocalizedCategory("strCategoryRedirect", 7), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameRedirectKeys"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionRedirectKeys"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool RedirectKeys {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryRedirect", 7), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameRedirectDrives"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionRedirectDrives"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool RedirectDiskDrives {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryRedirect", 7), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameRedirectPrinters"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionRedirectPrinters"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool RedirectPrinters {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryRedirect", 7), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameRedirectPorts"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionRedirectPorts"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool RedirectPorts {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryRedirect", 7), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameRedirectSmartCards"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionRedirectSmartCards"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool RedirectSmartCards {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryRedirect", 7), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameRedirectSounds"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionRedirectSounds"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool RedirectSound {get; set;}
            #endregion
            #region Misc
			[LocalizedAttributes.LocalizedCategory("strCategoryMiscellaneous", 8), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameExternalToolBefore"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionExternalToolBefore"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool PreExtApp {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryMiscellaneous", 8), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameExternalToolAfter"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionExternalToolAfter"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool PostExtApp {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryMiscellaneous", 8), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameMACAddress"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionMACAddress"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool MacAddress {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryMiscellaneous", 8), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameUser1"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionUser1"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool UserField {get; set;}
            #endregion
            #region VNC
			[LocalizedAttributes.LocalizedCategory("strCategoryAppearance", 9), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameCompression"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionCompression"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool VNCCompression {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryAppearance", 9), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameEncoding"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionEncoding"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool VNCEncoding {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryConnection", 9), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameAuthenticationMode"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionAuthenticationMode"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool VNCAuthMode {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryMiscellaneous", 9), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameVNCProxyType"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionVNCProxyType"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool VNCProxyType {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryMiscellaneous", 9), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameVNCProxyAddress"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionVNCProxyAddress"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool VNCProxyIP {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryMiscellaneous", 9), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameVNCProxyPort"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionVNCProxyPort"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool VNCProxyPort {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryMiscellaneous", 9), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameVNCProxyUsername"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionVNCProxyUsername"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool VNCProxyUsername {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryMiscellaneous", 9), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameVNCProxyPassword"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionVNCProxyPassword"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool VNCProxyPassword {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryAppearance", 9), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameColors"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionColors"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool VNCColors {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryAppearance", 9), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameSmartSizeMode"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionSmartSizeMode"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool VNCSmartSizeMode {get; set;}
				
			[LocalizedAttributes.LocalizedCategory("strCategoryAppearance", 9), 
			LocalizedAttributes.LocalizedDisplayNameInheritAttribute("strPropertyNameViewOnly"), 
			LocalizedAttributes.LocalizedDescriptionInheritAttribute("strPropertyDescriptionViewOnly"), 
			TypeConverter(typeof(Tools.Misc.YesNoTypeConverter))]public bool VNCViewOnly {get; set;}
            #endregion
				
			[Browsable(false)]
            public object Parent {get; set;}
				
			[Browsable(false)]
            public bool IsDefault {get; set;}
            #endregion
				
            #region Constructors
			public Inheritance(object parent, bool inheritEverything = false)
			{
				this.Parent = parent;
				if (inheritEverything)
				{
					TurnOnInheritanceCompletely();
				}
			}
            #endregion
				
            #region Public Methods
			public Inheritance Copy()
			{
				return (Inheritance)MemberwiseClone();
			}
				
			public void TurnOnInheritanceCompletely()
			{
				SetAllValues(true);
			}
				
			public void TurnOffInheritanceCompletely()
			{
				SetAllValues(false);
			}
            #endregion
				
            #region Private Methods
			private void SetAllValues(bool value)
			{
				// Display
				Description = value;
				Icon = value;
				Panel = value;
					
				// Connection
				Username = value;
				Password = value;
				Domain = value;
					
				// Protocol
				Protocol = value;
				ExtApp = value;
				Port = value;
				PuttySession = value;
				ICAEncryption = value;
				RDPAuthenticationLevel = value;
				LoadBalanceInfo = value;
				RenderingEngine = value;
				UseConsoleSession = value;
				UseCredSsp = value;
					
				// RD Gateway
				RDGatewayUsageMethod = value;
				RDGatewayHostname = value;
				RDGatewayUseConnectionCredentials = value;
				RDGatewayUsername = value;
				RDGatewayPassword = value;
				RDGatewayDomain = value;
					
				// Appearance
				Resolution = value;
				AutomaticResize = value;
				Colors = value;
				CacheBitmaps = value;
				DisplayWallpaper = value;
				DisplayThemes = value;
				EnableFontSmoothing = value;
				EnableDesktopComposition = value;
					
				// Redirect
				RedirectKeys = value;
				RedirectDiskDrives = value;
				RedirectPrinters = value;
				RedirectPorts = value;
				RedirectSmartCards = value;
				RedirectSound = value;
					
				// Misc
				PreExtApp = value;
				PostExtApp = value;
				MacAddress = value;
				UserField = value;
					
				// VNC
				VNCCompression = value;
				VNCEncoding = value;
				VNCAuthMode = value;
				VNCProxyType = value;
				VNCProxyIP = value;
				VNCProxyPort = value;
				VNCProxyUsername = value;
				VNCProxyPassword = value;
				VNCColors = value;
				VNCSmartSizeMode = value;
				VNCViewOnly = value;
			}
            #endregion
		}
	}
}
