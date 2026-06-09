using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001F27 RID: 7975
	[Token(Token = "0x2001F27")]
	public class AdItemInfo
	{
		// Token: 0x0600AF74 RID: 44916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF74")]
		[Address(RVA = "0x154B728", Offset = "0x154B728", VA = "0x7BBBD4B728")]
		public AdItemInfo()
		{
		}

		// Token: 0x0600AF75 RID: 44917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF75")]
		[Address(RVA = "0x154B794", Offset = "0x154B794", VA = "0x7BBBD4B794")]
		public AdItemInfo(AdvertDesc desc)
		{
		}

		// Token: 0x0400B35A RID: 45914
		[Token(Token = "0x400B35A")]
		[FieldOffset(Offset = "0x10")]
		public AdvertDesc Desc;
	}
}
