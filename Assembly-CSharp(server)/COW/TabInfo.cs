using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019D3 RID: 6611
	[Token(Token = "0x20019D3")]
	public class TabInfo
	{
		// Token: 0x060087F3 RID: 34803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087F3")]
		[Address(RVA = "0x1B42E68", Offset = "0x1B42E68", VA = "0x7BBC342E68")]
		public TabInfo()
		{
		}

		// Token: 0x04009676 RID: 38518
		[Token(Token = "0x4009676")]
		[FieldOffset(Offset = "0x10")]
		public string DeepLink;

		// Token: 0x04009677 RID: 38519
		[Token(Token = "0x4009677")]
		[FieldOffset(Offset = "0x18")]
		public string Key;

		// Token: 0x04009678 RID: 38520
		[Token(Token = "0x4009678")]
		[FieldOffset(Offset = "0x20")]
		public Action OnClick;
	}
}
