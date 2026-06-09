using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200071F RID: 1823
	[Token(Token = "0x200071F")]
	[ProtoContract]
	public class CSRankingInfo
	{
		// Token: 0x0600242C RID: 9260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242C")]
		[Address(RVA = "0x21B7108", Offset = "0x21B7108", VA = "0x7BBC9B7108")]
		public CSRankingInfo()
		{
		}

		// Token: 0x04002449 RID: 9289
		[Token(Token = "0x4002449")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C0E4", Offset = "0x110C0E4")]
		public uint season_id;

		// Token: 0x0400244A RID: 9290
		[Token(Token = "0x400244A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C0F8", Offset = "0x110C0F8")]
		public uint rank;

		// Token: 0x0400244B RID: 9291
		[Token(Token = "0x400244B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C10C", Offset = "0x110C10C")]
		public uint max_rank;

		// Token: 0x0400244C RID: 9292
		[Token(Token = "0x400244C")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C120", Offset = "0x110C120")]
		public uint ranking_points;
	}
}
