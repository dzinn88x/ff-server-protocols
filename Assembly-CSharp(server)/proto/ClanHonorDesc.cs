using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A3A RID: 2618
	[Token(Token = "0x2000A3A")]
	[ProtoContract]
	public class ClanHonorDesc
	{
		// Token: 0x06002744 RID: 10052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002744")]
		[Address(RVA = "0x21B85BC", Offset = "0x21B85BC", VA = "0x7BBC9B85BC")]
		public ClanHonorDesc()
		{
		}

		// Token: 0x04002FC1 RID: 12225
		[Token(Token = "0x4002FC1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120030", Offset = "0x1120030")]
		public uint id;

		// Token: 0x04002FC2 RID: 12226
		[Token(Token = "0x4002FC2")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120044", Offset = "0x1120044")]
		public uint type;

		// Token: 0x04002FC3 RID: 12227
		[Token(Token = "0x4002FC3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120058", Offset = "0x1120058")]
		public double honor;

		// Token: 0x04002FC4 RID: 12228
		[Token(Token = "0x4002FC4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112006C", Offset = "0x112006C")]
		public uint upperlimit;

		// Token: 0x04002FC5 RID: 12229
		[Token(Token = "0x4002FC5")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120080", Offset = "0x1120080")]
		public uint division;

		// Token: 0x04002FC6 RID: 12230
		[Token(Token = "0x4002FC6")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120094", Offset = "0x1120094")]
		public uint match_mode;

		// Token: 0x04002FC7 RID: 12231
		[Token(Token = "0x4002FC7")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11200A8", Offset = "0x11200A8")]
		public uint game_mode;
	}
}
