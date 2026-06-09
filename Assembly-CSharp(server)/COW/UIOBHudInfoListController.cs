using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AA8 RID: 6824
	[Token(Token = "0x2001AA8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F888C", Offset = "0x10F888C")]
	internal class UIOBHudInfoListController : UIBaseHudInfoListController
	{
		// Token: 0x06008FF0 RID: 36848 RVA: 0x00026580 File Offset: 0x00024780
		[Token(Token = "0x6008FF0")]
		[Address(RVA = "0x1B0B02C", Offset = "0x1B0B02C", VA = "0x7BBC30B02C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008FF1 RID: 36849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FF1")]
		[Address(RVA = "0x1B0B07C", Offset = "0x1B0B07C", VA = "0x7BBC30B07C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008FF2 RID: 36850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008FF2")]
		[Address(RVA = "0x1B0B418", Offset = "0x1B0B418", VA = "0x7BBC30B418")]
		public UIOBHudInfoListController()
		{
		}

		// Token: 0x04009BE4 RID: 39908
		[Token(Token = "0x4009BE4")]
		[FieldOffset(Offset = "0xA8")]
		private UIOBHudInfoListView m_View;
	}
}
