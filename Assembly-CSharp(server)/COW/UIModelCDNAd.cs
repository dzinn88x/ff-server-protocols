using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001DA8 RID: 7592
	[Token(Token = "0x2001DA8")]
	public class UIModelCDNAd : UIBaseModel
	{
		// Token: 0x0600A5FE RID: 42494 RVA: 0x0002C610 File Offset: 0x0002A810
		[Token(Token = "0x600A5FE")]
		[Address(RVA = "0x22E1700", Offset = "0x22E1700", VA = "0x7BBCAE1700", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600A5FF RID: 42495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5FF")]
		[Address(RVA = "0x22E1708", Offset = "0x22E1708", VA = "0x7BBCAE1708")]
		public void ProcessCDNAd(CSGetAdvertRes adRes)
		{
		}

		// Token: 0x0600A600 RID: 42496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A600")]
		[Address(RVA = "0x22E1A10", Offset = "0x22E1A10", VA = "0x7BBCAE1A10")]
		public List<AdvertDesc> GetAdList(AdType type)
		{
			return null;
		}

		// Token: 0x0600A601 RID: 42497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A601")]
		[Address(RVA = "0x22E1AE4", Offset = "0x22E1AE4", VA = "0x7BBCAE1AE4", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600A602 RID: 42498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A602")]
		[Address(RVA = "0x22E1AEC", Offset = "0x22E1AEC", VA = "0x7BBCAE1AEC", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600A603 RID: 42499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A603")]
		[Address(RVA = "0x22E1B68", Offset = "0x22E1B68", VA = "0x7BBCAE1B68")]
		public UIModelCDNAd()
		{
		}

		// Token: 0x0400ABDC RID: 43996
		[Token(Token = "0x400ABDC")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<AdType, List<AdvertDesc>> m_AdDic;
	}
}
