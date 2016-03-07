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


namespace mRemoteNG.Credential
{
	public class Info
	{
        #region 1 Display
		private string _Name;
        [LocalizedAttributes.LocalizedCategory("strCategoryDisplay", 1), 
            Browsable(true),
            LocalizedAttributes.LocalizedDisplayName("strPropertyNameName"),
            LocalizedAttributes.LocalizedDescription("strPropertyDescriptionName")]
        public string Name
		{
			get
			{
				return _Name;
			}
			set
			{
				_Name = value;
			}
		}
			
		private string _Description;
        [LocalizedAttributes.LocalizedCategory("strCategoryDisplay", 1), 
            Browsable(true),
            LocalizedAttributes.LocalizedDisplayName("strPropertyNameDescription"),
            LocalizedAttributes.LocalizedDescription("strPropertyDescriptionDescription")]
        public string Description
		{
			get
			{
				return _Description;
			}
			set
			{
				_Description = value;
			}
		}
        #endregion
        
        #region 2 Credentials
		private string _Username;
        [LocalizedAttributes.LocalizedCategory("strCategoryCredentials", 2), 
            Browsable(true),
            LocalizedAttributes.LocalizedDisplayName("strPropertyNameUsername"),
            LocalizedAttributes.LocalizedDescription("strPropertyDescriptionUsername")]
        public string Username
		{
			get
			{
				return _Username;
			}
			set
			{
				_Username = value;
			}
		}
			
		private string _Password;
        [LocalizedAttributes.LocalizedCategory("strCategoryCredentials", 2), 
            Browsable(true),
            LocalizedAttributes.LocalizedDisplayName("strPropertyNamePassword"),
            LocalizedAttributes.LocalizedDescription("strPropertyDescriptionPassword"), 
            PasswordPropertyText(true)]public string Password
		{
			get
			{
				return _Password;
			}
			set
			{
				_Password = value;
			}
		}
			
		private string _Domain;
        [LocalizedAttributes.LocalizedCategory("strCategoryCredentials", 2), 
            Browsable(true),
            LocalizedAttributes.LocalizedDisplayName("strPropertyNameDomain"),
            LocalizedAttributes.LocalizedDescription("strPropertyDescriptionDomain")]
        public string Domain
		{
			get
			{
				return _Domain;
			}
			set
			{
				_Domain = value;
			}
		}
        #endregion
	}
}
