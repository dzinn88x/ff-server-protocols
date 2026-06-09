using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001F46 RID: 8006
	[Token(Token = "0x2001F46")]
	public class AvatarDebrisInfo
	{
		// Token: 0x0600B033 RID: 45107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B033")]
		[Address(RVA = "0x155D108", Offset = "0x155D108", VA = "0x7BBBD5D108")]
		public AvatarDebrisInfo()
		{
		}

		// Token: 0x0400B3D1 RID: 46033
		[Token(Token = "0x400B3D1")]
		[FieldOffset(Offset = "0x10")]
		public uint PurchaseCount;

		// Token: 0x0400B3D2 RID: 46034
		[Token(Token = "0x400B3D2")]
		[FieldOffset(Offset = "0x14")]
		public uint GoldPrice;

		// Token: 0x0400B3D3 RID: 46035
		[Token(Token = "0x400B3D3")]
		[FieldOffset(Offset = "0x18")]
		public uint GemPrice;
	}
}
