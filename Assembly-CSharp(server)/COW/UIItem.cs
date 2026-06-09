using System;
using COW.GamePlay;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018E9 RID: 6377
	[Token(Token = "0x20018E9")]
	internal class UIItem
	{
		// Token: 0x06007F84 RID: 32644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F84")]
		[Address(RVA = "0x1E85108", Offset = "0x1E85108", VA = "0x7BBC685108")]
		public UIItem()
		{
		}

		// Token: 0x04009244 RID: 37444
		[Token(Token = "0x4009244")]
		[FieldOffset(Offset = "0x10")]
		public AHtazwI ParentItem;

		// Token: 0x04009245 RID: 37445
		[Token(Token = "0x4009245")]
		[FieldOffset(Offset = "0x18")]
		public int Count;

		// Token: 0x04009246 RID: 37446
		[Token(Token = "0x4009246")]
		[FieldOffset(Offset = "0x1C")]
		public int Value;
	}
}
