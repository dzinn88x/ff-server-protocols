using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C00 RID: 7168
	[Token(Token = "0x2001C00")]
	public class UIHUDSelfInfoController : UIBaseController
	{
		// Token: 0x06009BCB RID: 39883 RVA: 0x00028E90 File Offset: 0x00027090
		[Token(Token = "0x6009BCB")]
		[Address(RVA = "0x1D4CE08", Offset = "0x1D4CE08", VA = "0x7BBC54CE08")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009BCC RID: 39884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BCC")]
		[Address(RVA = "0x1D4CE58", Offset = "0x1D4CE58", VA = "0x7BBC54CE58", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009BCD RID: 39885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BCD")]
		[Address(RVA = "0x1D4CEBC", Offset = "0x1D4CEBC", VA = "0x7BBC54CEBC")]
		public void SetNameInfo(string info, Color color)
		{
		}

		// Token: 0x06009BCE RID: 39886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BCE")]
		[Address(RVA = "0x1D4CF6C", Offset = "0x1D4CF6C", VA = "0x7BBC54CF6C")]
		public UIHUDSelfInfoController()
		{
		}

		// Token: 0x0400A1F4 RID: 41460
		[Token(Token = "0x400A1F4")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDWereWolvesSelfInfoView m_View;
	}
}
