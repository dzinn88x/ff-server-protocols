using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001880 RID: 6272
	[Token(Token = "0x2001880")]
	internal class BombModeNotification
	{
		// Token: 0x06007C03 RID: 31747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C03")]
		[Address(RVA = "0x14E4490", Offset = "0x14E4490", VA = "0x7BBBCE4490")]
		public BombModeNotification()
		{
		}

		// Token: 0x04009036 RID: 36918
		[Token(Token = "0x4009036")]
		[FieldOffset(Offset = "0x10")]
		public string BombActionPlayerName;

		// Token: 0x04009037 RID: 36919
		[Token(Token = "0x4009037")]
		[FieldOffset(Offset = "0x18")]
		public string BombActionPlayerNameColor;

		// Token: 0x04009038 RID: 36920
		[Token(Token = "0x4009038")]
		[FieldOffset(Offset = "0x20")]
		public string BattleInfo;

		// Token: 0x04009039 RID: 36921
		[Token(Token = "0x4009039")]
		[FieldOffset(Offset = "0x28")]
		public string iconName;

		// Token: 0x0400903A RID: 36922
		[Token(Token = "0x400903A")]
		[FieldOffset(Offset = "0x30")]
		public Color iconTintColor;
	}
}
