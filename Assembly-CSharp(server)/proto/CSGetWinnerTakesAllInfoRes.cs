using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200070B RID: 1803
	[Token(Token = "0x200070B")]
	[ProtoContract]
	public class CSGetWinnerTakesAllInfoRes
	{
		// Token: 0x06002418 RID: 9240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002418")]
		[Address(RVA = "0x21B63F4", Offset = "0x21B63F4", VA = "0x7BBC9B63F4")]
		public CSGetWinnerTakesAllInfoRes()
		{
		}

		// Token: 0x04002407 RID: 9223
		[Token(Token = "0x4002407")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BB6C", Offset = "0x110BB6C")]
		public ulong account_id;

		// Token: 0x04002408 RID: 9224
		[Token(Token = "0x4002408")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BB80", Offset = "0x110BB80")]
		public uint match_num;

		// Token: 0x04002409 RID: 9225
		[Token(Token = "0x4002409")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BB94", Offset = "0x110BB94")]
		public uint last_update_at;

		// Token: 0x0400240A RID: 9226
		[Token(Token = "0x400240A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BBA8", Offset = "0x110BBA8")]
		public WinnerTakesAllDesc wta_desc;

		// Token: 0x0400240B RID: 9227
		[Token(Token = "0x400240B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BBBC", Offset = "0x110BBBC")]
		public long refresh_at;
	}
}
