using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200158C RID: 5516
	[Token(Token = "0x200158C")]
	public class BuyBtnInfo
	{
		// Token: 0x06006067 RID: 24679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006067")]
		[Address(RVA = "0x14E8EB0", Offset = "0x14E8EB0", VA = "0x7BBBCE8EB0")]
		public BuyBtnInfo(string icon, string desc, EventDelegate.Callback callback)
		{
		}

		// Token: 0x04008090 RID: 32912
		[Token(Token = "0x4008090")]
		[FieldOffset(Offset = "0x10")]
		public string icon;

		// Token: 0x04008091 RID: 32913
		[Token(Token = "0x4008091")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x04008092 RID: 32914
		[Token(Token = "0x4008092")]
		[FieldOffset(Offset = "0x20")]
		public EventDelegate.Callback callback;
	}
}
