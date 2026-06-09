using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020013C4 RID: 5060
	[Token(Token = "0x20013C4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBE18", Offset = "0x10EBE18")]
	public class UISuperCarRewardWndController : UIPopupWindowController
	{
		// Token: 0x060052AF RID: 21167 RVA: 0x00018CD8 File Offset: 0x00016ED8
		[Token(Token = "0x60052AF")]
		[Address(RVA = "0x214AF84", Offset = "0x214AF84", VA = "0x7BBC94AF84")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052B0")]
		[Address(RVA = "0x214AFD4", Offset = "0x214AFD4", VA = "0x7BBC94AFD4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052B1")]
		[Address(RVA = "0x2140F30", Offset = "0x2140F30", VA = "0x7BBC940F30")]
		public void SetData(List<SupercarRoundAward> awards)
		{
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052B2")]
		[Address(RVA = "0x214B038", Offset = "0x214B038", VA = "0x7BBC94B038", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052B3")]
		[Address(RVA = "0x214B040", Offset = "0x214B040", VA = "0x7BBC94B040")]
		public UISuperCarRewardWndController()
		{
		}

		// Token: 0x0400788C RID: 30860
		[Token(Token = "0x400788C")]
		[FieldOffset(Offset = "0x98")]
		private UISuperCarRewardWndView m_View;
	}
}
