using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001FCD RID: 8141
	[Token(Token = "0x2001FCD")]
	public class UIModelRateAPPSwitch : UIBaseModel
	{
		// Token: 0x0600B4A0 RID: 46240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4A0")]
		[Address(RVA = "0x2397334", Offset = "0x2397334", VA = "0x7BBCB97334")]
		public void ProcessRateAppSwitch(CSGetRateAppSwitchRes data)
		{
		}

		// Token: 0x0600B4A1 RID: 46241 RVA: 0x00033480 File Offset: 0x00031680
		[Token(Token = "0x600B4A1")]
		[Address(RVA = "0x23973B8", Offset = "0x23973B8", VA = "0x7BBCB973B8", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B4A2 RID: 46242 RVA: 0x00033498 File Offset: 0x00031698
		[Token(Token = "0x600B4A2")]
		[Address(RVA = "0x23973C0", Offset = "0x23973C0", VA = "0x7BBCB973C0")]
		public bool CanRateApp()
		{
			return default(bool);
		}

		// Token: 0x0600B4A3 RID: 46243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4A3")]
		[Address(RVA = "0x23973C8", Offset = "0x23973C8", VA = "0x7BBCB973C8")]
		public UIModelRateAPPSwitch()
		{
		}

		// Token: 0x0400B6FD RID: 46845
		[Token(Token = "0x400B6FD")]
		[FieldOffset(Offset = "0x18")]
		public bool IOSOpen;

		// Token: 0x0400B6FE RID: 46846
		[Token(Token = "0x400B6FE")]
		[FieldOffset(Offset = "0x19")]
		public bool GPOpen;

		// Token: 0x0400B6FF RID: 46847
		[Token(Token = "0x400B6FF")]
		[FieldOffset(Offset = "0x1A")]
		public bool HuaweiOpen;

		// Token: 0x0400B700 RID: 46848
		[Token(Token = "0x400B700")]
		[FieldOffset(Offset = "0x1B")]
		public bool ThirdPartyOpen;
	}
}
