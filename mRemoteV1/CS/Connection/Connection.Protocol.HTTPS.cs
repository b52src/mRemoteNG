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


namespace mRemoteNG.Connection.Protocol
{
	public class HTTPS : HTTPBase
	{
				
		public HTTPS(RenderingEngine RenderingEngine) : base(RenderingEngine)
		{
		}
				
		public override void NewExtended()
		{
			base.NewExtended();
			httpOrS = "https";
			defaultPort = (int)Defaults.Port;
		}
				
		public enum Defaults
		{
			Port = 443
		}
	}
}
