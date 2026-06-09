using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017F7 RID: 6135
	[Token(Token = "0x20017F7")]
	public class UIGachaLegendaryTempBagPackItemState
	{
		// Token: 0x06007722 RID: 30498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007722")]
		[Address(RVA = "0x2058988", Offset = "0x2058988", VA = "0x7BBC858988")]
		public UIGachaLegendaryTempBagPackItemState(GachaShowItem item, int realIndex)
		{
		}

		// Token: 0x04008DA0 RID: 36256
		[Token(Token = "0x4008DA0")]
		[FieldOffset(Offset = "0x10")]
		public uint UniquePrizeID;

		// Token: 0x04008DA1 RID: 36257
		[Token(Token = "0x4008DA1")]
		[FieldOffset(Offset = "0x14")]
		public int RealIndex;

		// Token: 0x04008DA2 RID: 36258
		[Token(Token = "0x4008DA2")]
		[FieldOffset(Offset = "0x18")]
		public GachaShowItem Item;

		// Token: 0x04008DA3 RID: 36259
		[Token(Token = "0x4008DA3")]
		[FieldOffset(Offset = "0x20")]
		public bool IsSelected;

		// Token: 0x04008DA4 RID: 36260
		[Token(Token = "0x4008DA4")]
		[FieldOffset(Offset = "0x21")]
		public bool QuickSelect;
	}
}
