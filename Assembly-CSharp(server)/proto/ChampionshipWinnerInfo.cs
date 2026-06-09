using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200090E RID: 2318
	[Token(Token = "0x200090E")]
	[ProtoContract]
	public class ChampionshipWinnerInfo
	{
		// Token: 0x0600261C RID: 9756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261C")]
		[Address(RVA = "0x21B821C", Offset = "0x21B821C", VA = "0x7BBC9B821C")]
		public ChampionshipWinnerInfo()
		{
		}

		// Token: 0x04002AF4 RID: 10996
		[Token(Token = "0x4002AF4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117F34", Offset = "0x1117F34")]
		public uint championship_type;

		// Token: 0x04002AF5 RID: 10997
		[Token(Token = "0x4002AF5")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117F48", Offset = "0x1117F48")]
		public uint championship_id;

		// Token: 0x04002AF6 RID: 10998
		[Token(Token = "0x4002AF6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1117F5C", Offset = "0x1117F5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117F5C", Offset = "0x1117F5C")]
		public string region;

		// Token: 0x04002AF7 RID: 10999
		[Token(Token = "0x4002AF7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117FAC", Offset = "0x1117FAC")]
		public ulong team_id;
	}
}
