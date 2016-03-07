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
	public class RAW : Connection.Protocol.PuttyBase
	{
		public RAW()
		{
			this.PuttyProtocol = Putty_Protocol.raw;
		}
				
		public enum Defaults
		{
			Port = 23
		}
	}
}
