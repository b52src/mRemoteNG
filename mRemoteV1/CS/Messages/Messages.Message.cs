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


namespace mRemoteNG.Messages
{
	public enum MessageClass
	{
		InformationMsg = 0,
		WarningMsg = 1,
		ErrorMsg = 2,
		ReportMsg = 3
	}
		
	public class Message
	{
		private MessageClass _MsgClass;
        public MessageClass MsgClass
		{
			get
			{
				return _MsgClass;
			}
			set
			{
				_MsgClass = value;
			}
		}
			
		private string _MsgText;
        public string MsgText
		{
			get
			{
				return _MsgText;
			}
			set
			{
				_MsgText = value;
			}
		}
			
		private DateTime _MsgDate;
        public DateTime MsgDate
		{
			get
			{
				return _MsgDate;
			}
			set
			{
				_MsgDate = value;
			}
		}
	}
}
