using System;
using COW.GamePlay;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001F65 RID: 8037
	[Token(Token = "0x2001F65")]
	internal class EPPlayerInfo
	{
		// Token: 0x0600B114 RID: 45332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B114")]
		[Address(RVA = "0x1610FF0", Offset = "0x1610FF0", VA = "0x7BBBE10FF0")]
		public EPPlayerInfo(ulong uID, {QAb\u0082~u pID, bool isBot, idPihWs info)
		{
		}

		// Token: 0x0600B115 RID: 45333 RVA: 0x00031AB8 File Offset: 0x0002FCB8
		[Token(Token = "0x600B115")]
		[Address(RVA = "0x1611274", Offset = "0x1611274", VA = "0x7BBBE11274")]
		public bool IsLocalPlayer()
		{
			return default(bool);
		}

		// Token: 0x0600B116 RID: 45334 RVA: 0x00031AD0 File Offset: 0x0002FCD0
		[Token(Token = "0x600B116")]
		[Address(RVA = "0x1611314", Offset = "0x1611314", VA = "0x7BBBE11314")]
		public bool IsCelebrity()
		{
			return default(bool);
		}

		// Token: 0x0600B117 RID: 45335 RVA: 0x00031AE8 File Offset: 0x0002FCE8
		[Token(Token = "0x600B117")]
		[Address(RVA = "0x16113C0", Offset = "0x16113C0", VA = "0x7BBBE113C0")]
		public bool IsFemale()
		{
			return default(bool);
		}

		// Token: 0x0600B118 RID: 45336 RVA: 0x00031B00 File Offset: 0x0002FD00
		[Token(Token = "0x600B118")]
		[Address(RVA = "0x16114B8", Offset = "0x16114B8", VA = "0x7BBBE114B8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600B119 RID: 45337 RVA: 0x00031B18 File Offset: 0x0002FD18
		[Token(Token = "0x600B119")]
		[Address(RVA = "0x16115A8", Offset = "0x16115A8", VA = "0x7BBBE115A8", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400B466 RID: 46182
		[Token(Token = "0x400B466")]
		[FieldOffset(Offset = "0x10")]
		public ulong userID;

		// Token: 0x0400B467 RID: 46183
		[Token(Token = "0x400B467")]
		[FieldOffset(Offset = "0x18")]
		public {QAb\u0082~u playerID;

		// Token: 0x0400B468 RID: 46184
		[Token(Token = "0x400B468")]
		[FieldOffset(Offset = "0x30")]
		public string playerName;

		// Token: 0x0400B469 RID: 46185
		[Token(Token = "0x400B469")]
		[FieldOffset(Offset = "0x38")]
		public uint badgeCount;

		// Token: 0x0400B46A RID: 46186
		[Token(Token = "0x400B46A")]
		[FieldOffset(Offset = "0x3C")]
		public uint badgeId;

		// Token: 0x0400B46B RID: 46187
		[Token(Token = "0x400B46B")]
		[FieldOffset(Offset = "0x40")]
		public bool isAI;

		// Token: 0x0400B46C RID: 46188
		[Token(Token = "0x400B46C")]
		[FieldOffset(Offset = "0x44")]
		public uint pinId;

		// Token: 0x0400B46D RID: 46189
		[Token(Token = "0x400B46D")]
		[FieldOffset(Offset = "0x48")]
		public AvatarManager.Vk[~Plj avatarData;

		// Token: 0x0400B46E RID: 46190
		[Token(Token = "0x400B46E")]
		[FieldOffset(Offset = "0x50")]
		public uint role;
	}
}
