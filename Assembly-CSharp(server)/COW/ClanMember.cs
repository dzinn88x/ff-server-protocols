using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001DFF RID: 7679
	[Token(Token = "0x2001DFF")]
	public class ClanMember : IComparable<ClanMember>
	{
		// Token: 0x0600A7E5 RID: 42981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A7E5")]
		[Address(RVA = "0x14F9234", Offset = "0x14F9234", VA = "0x7BBBCF9234")]
		public static implicit operator ClanMember(ClanMemberWithAccountInfo data)
		{
			return null;
		}

		// Token: 0x0600A7E6 RID: 42982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7E6")]
		[Address(RVA = "0x14F9418", Offset = "0x14F9418", VA = "0x7BBBCF9418")]
		public void SetPresenceStatus(uint presence, ulong groupId)
		{
		}

		// Token: 0x0600A7E7 RID: 42983 RVA: 0x0002D4E0 File Offset: 0x0002B6E0
		[Token(Token = "0x600A7E7")]
		[Address(RVA = "0x14F94B0", Offset = "0x14F94B0", VA = "0x7BBBCF94B0", Slot = "4")]
		public int CompareTo(ClanMember other)
		{
			return 0;
		}

		// Token: 0x0600A7E8 RID: 42984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7E8")]
		[Address(RVA = "0x14F93B0", Offset = "0x14F93B0", VA = "0x7BBBCF93B0")]
		public ClanMember()
		{
		}

		// Token: 0x0400AD83 RID: 44419
		[Token(Token = "0x400AD83")]
		[FieldOffset(Offset = "0x10")]
		public BaseProfileInfo m_AccountInfo;

		// Token: 0x0400AD84 RID: 44420
		[Token(Token = "0x400AD84")]
		[FieldOffset(Offset = "0x18")]
		public EClanRole m_Role;

		// Token: 0x0400AD85 RID: 44421
		[Token(Token = "0x400AD85")]
		[FieldOffset(Offset = "0x1C")]
		public EPresence.AccountPresence m_Status;

		// Token: 0x0400AD86 RID: 44422
		[Token(Token = "0x400AD86")]
		[FieldOffset(Offset = "0x20")]
		public uint m_HonorPoint;

		// Token: 0x0400AD87 RID: 44423
		[Token(Token = "0x400AD87")]
		[FieldOffset(Offset = "0x24")]
		public uint m_RacePoint;

		// Token: 0x0400AD88 RID: 44424
		[Token(Token = "0x400AD88")]
		[FieldOffset(Offset = "0x28")]
		public ulong m_LastGainRPAt;

		// Token: 0x0400AD89 RID: 44425
		[Token(Token = "0x400AD89")]
		[FieldOffset(Offset = "0x30")]
		public ulong m_JoinAt;

		// Token: 0x02001E00 RID: 7680
		[Token(Token = "0x2001E00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC304", Offset = "0x10FC304")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x0600A7E9 RID: 42985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7E9")]
			[Address(RVA = "0x14F97B8", Offset = "0x14F97B8", VA = "0x7BBBCF97B8")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x0600A7EA RID: 42986 RVA: 0x0002D4F8 File Offset: 0x0002B6F8
			[Token(Token = "0x600A7EA")]
			[Address(RVA = "0x14F97C0", Offset = "0x14F97C0", VA = "0x7BBBCF97C0")]
			internal bool <CompareTo>b__0(TeamMemberWithAccountInfo e)
			{
				return default(bool);
			}

			// Token: 0x0600A7EB RID: 42987 RVA: 0x0002D510 File Offset: 0x0002B710
			[Token(Token = "0x600A7EB")]
			[Address(RVA = "0x14F9834", Offset = "0x14F9834", VA = "0x7BBBCF9834")]
			internal bool <CompareTo>b__1(TeamMemberWithAccountInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400AD8A RID: 44426
			[Token(Token = "0x400AD8A")]
			[FieldOffset(Offset = "0x10")]
			public ClanMember <>4__this;

			// Token: 0x0400AD8B RID: 44427
			[Token(Token = "0x400AD8B")]
			[FieldOffset(Offset = "0x18")]
			public ClanMember other;
		}
	}
}
