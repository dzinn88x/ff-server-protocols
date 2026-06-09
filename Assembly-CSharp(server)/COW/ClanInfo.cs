using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001DFE RID: 7678
	[Token(Token = "0x2001DFE")]
	public class ClanInfo
	{
		// Token: 0x0600A7E2 RID: 42978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A7E2")]
		[Address(RVA = "0x14F8B20", Offset = "0x14F8B20", VA = "0x7BBBCF8B20")]
		public static implicit operator ClanInfo(ClanInfo data)
		{
			return null;
		}

		// Token: 0x0600A7E3 RID: 42979 RVA: 0x0002D4C8 File Offset: 0x0002B6C8
		[Token(Token = "0x600A7E3")]
		[Address(RVA = "0x14F8D40", Offset = "0x14F8D40", VA = "0x7BBBCF8D40")]
		private static uint GetExtendTimeFromMiscellaneous(string misc)
		{
			return 0U;
		}

		// Token: 0x0600A7E4 RID: 42980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7E4")]
		[Address(RVA = "0x14F8D38", Offset = "0x14F8D38", VA = "0x7BBBCF8D38")]
		public ClanInfo()
		{
		}

		// Token: 0x0400AD6D RID: 44397
		[Token(Token = "0x400AD6D")]
		[FieldOffset(Offset = "0x10")]
		public ulong m_ClanID;

		// Token: 0x0400AD6E RID: 44398
		[Token(Token = "0x400AD6E")]
		[FieldOffset(Offset = "0x18")]
		public string m_ClanName;

		// Token: 0x0400AD6F RID: 44399
		[Token(Token = "0x400AD6F")]
		[FieldOffset(Offset = "0x20")]
		public uint m_ClanLevel;

		// Token: 0x0400AD70 RID: 44400
		[Token(Token = "0x400AD70")]
		[FieldOffset(Offset = "0x24")]
		public uint m_ClanMemberNum;

		// Token: 0x0400AD71 RID: 44401
		[Token(Token = "0x400AD71")]
		[FieldOffset(Offset = "0x28")]
		public uint m_ClanScale;

		// Token: 0x0400AD72 RID: 44402
		[Token(Token = "0x400AD72")]
		[FieldOffset(Offset = "0x2C")]
		public uint m_ExtendTimes;

		// Token: 0x0400AD73 RID: 44403
		[Token(Token = "0x400AD73")]
		[FieldOffset(Offset = "0x30")]
		public string m_ClanSlogan;

		// Token: 0x0400AD74 RID: 44404
		[Token(Token = "0x400AD74")]
		[FieldOffset(Offset = "0x38")]
		public string m_ClanRegion;

		// Token: 0x0400AD75 RID: 44405
		[Token(Token = "0x400AD75")]
		[FieldOffset(Offset = "0x40")]
		public uint m_LimitLevel;

		// Token: 0x0400AD76 RID: 44406
		[Token(Token = "0x400AD76")]
		[FieldOffset(Offset = "0x44")]
		public uint m_LimitRank;

		// Token: 0x0400AD77 RID: 44407
		[Token(Token = "0x400AD77")]
		[FieldOffset(Offset = "0x48")]
		public string m_CaptainName;

		// Token: 0x0400AD78 RID: 44408
		[Token(Token = "0x400AD78")]
		[FieldOffset(Offset = "0x50")]
		public string m_ClanAnnouncement;

		// Token: 0x0400AD79 RID: 44409
		[Token(Token = "0x400AD79")]
		[FieldOffset(Offset = "0x58")]
		public ulong m_CreateDate;

		// Token: 0x0400AD7A RID: 44410
		[Token(Token = "0x400AD7A")]
		[FieldOffset(Offset = "0x60")]
		public ulong CaptainID;

		// Token: 0x0400AD7B RID: 44411
		[Token(Token = "0x400AD7B")]
		[FieldOffset(Offset = "0x68")]
		public ulong[] ViceCaptainID;

		// Token: 0x0400AD7C RID: 44412
		[Token(Token = "0x400AD7C")]
		[FieldOffset(Offset = "0x70")]
		public uint m_HonorPoint;

		// Token: 0x0400AD7D RID: 44413
		[Token(Token = "0x400AD7D")]
		[FieldOffset(Offset = "0x74")]
		public uint m_EntryType;

		// Token: 0x0400AD7E RID: 44414
		[Token(Token = "0x400AD7E")]
		[FieldOffset(Offset = "0x78")]
		public uint m_RacePoint;

		// Token: 0x0400AD7F RID: 44415
		[Token(Token = "0x400AD7F")]
		[FieldOffset(Offset = "0x80")]
		public ulong m_ClaimRPAwardAt;

		// Token: 0x0400AD80 RID: 44416
		[Token(Token = "0x400AD80")]
		[FieldOffset(Offset = "0x88")]
		public uint m_AreaID;

		// Token: 0x0400AD81 RID: 44417
		[Token(Token = "0x400AD81")]
		[FieldOffset(Offset = "0x8C")]
		public uint m_PlayStyle;

		// Token: 0x0400AD82 RID: 44418
		[Token(Token = "0x400AD82")]
		[FieldOffset(Offset = "0x90")]
		public ulong m_DeputyCaptainID;
	}
}
