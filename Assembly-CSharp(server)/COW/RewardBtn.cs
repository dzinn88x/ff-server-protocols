using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016A2 RID: 5794
	[Token(Token = "0x20016A2")]
	public class RewardBtn
	{
		// Token: 0x06006991 RID: 27025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006991")]
		[Address(RVA = "0x175DBE8", Offset = "0x175DBE8", VA = "0x7BBBF5DBE8")]
		public RewardBtn()
		{
		}

		// Token: 0x04008664 RID: 34404
		[Token(Token = "0x4008664")]
		[FieldOffset(Offset = "0x10")]
		public string BtnTitle;

		// Token: 0x04008665 RID: 34405
		[Token(Token = "0x4008665")]
		[FieldOffset(Offset = "0x18")]
		public Action OnBtnClick;
	}
}
