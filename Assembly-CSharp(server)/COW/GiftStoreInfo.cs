using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001EB8 RID: 7864
	[Token(Token = "0x2001EB8")]
	public class GiftStoreInfo
	{
		// Token: 0x0600AC5D RID: 44125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC5D")]
		[Address(RVA = "0x1D8DD30", Offset = "0x1D8DD30", VA = "0x7BBC58DD30")]
		public GiftStoreInfo()
		{
		}

		// Token: 0x0400B0FE RID: 45310
		[Token(Token = "0x400B0FE")]
		[FieldOffset(Offset = "0x10")]
		public CSGetGiftStoreRes m_GetGiftStoreRes;

		// Token: 0x0400B0FF RID: 45311
		[Token(Token = "0x400B0FF")]
		[FieldOffset(Offset = "0x18")]
		public string m_StoreIcon;

		// Token: 0x0400B100 RID: 45312
		[Token(Token = "0x400B100")]
		[FieldOffset(Offset = "0x20")]
		public string m_StoreTab;
	}
}
