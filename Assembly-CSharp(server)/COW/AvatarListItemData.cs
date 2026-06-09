using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016AE RID: 5806
	[Token(Token = "0x20016AE")]
	public class AvatarListItemData
	{
		// Token: 0x060069F1 RID: 27121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069F1")]
		[Address(RVA = "0x15621FC", Offset = "0x15621FC", VA = "0x7BBBD621FC")]
		public AvatarListItemData()
		{
		}

		// Token: 0x040086A1 RID: 34465
		[Token(Token = "0x40086A1")]
		[FieldOffset(Offset = "0x10")]
		public AvatarProfile profile;

		// Token: 0x040086A2 RID: 34466
		[Token(Token = "0x40086A2")]
		[FieldOffset(Offset = "0x18")]
		public bool isCurrentSelected;

		// Token: 0x040086A3 RID: 34467
		[Token(Token = "0x40086A3")]
		[FieldOffset(Offset = "0x19")]
		public bool isCurrentEquipped;
	}
}
