using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016CD RID: 5837
	[Token(Token = "0x20016CD")]
	internal class SuitDisplayData
	{
		// Token: 0x06006B56 RID: 27478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B56")]
		[Address(RVA = "0x1B41A54", Offset = "0x1B41A54", VA = "0x7BBC341A54")]
		public SuitDisplayData()
		{
		}

		// Token: 0x04008748 RID: 34632
		[Token(Token = "0x4008748")]
		[FieldOffset(Offset = "0x10")]
		public AvatarSuit suit;

		// Token: 0x04008749 RID: 34633
		[Token(Token = "0x4008749")]
		[FieldOffset(Offset = "0x18")]
		public bool isSelected;

		// Token: 0x0400874A RID: 34634
		[Token(Token = "0x400874A")]
		[FieldOffset(Offset = "0x19")]
		public bool isEquiping;

		// Token: 0x0400874B RID: 34635
		[Token(Token = "0x400874B")]
		[FieldOffset(Offset = "0x1A")]
		public bool isNeedDownloadAB;
	}
}
