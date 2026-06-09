using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B31 RID: 2865
	[Token(Token = "0x2000B31")]
	[ProtoContract]
	public class BooyahDayLeaderboardRewardDesc
	{
		// Token: 0x06002839 RID: 10297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002839")]
		[Address(RVA = "0x21AFC54", Offset = "0x21AFC54", VA = "0x7BBC9AFC54")]
		public BooyahDayLeaderboardRewardDesc()
		{
		}

		// Token: 0x0400365A RID: 13914
		[Token(Token = "0x400365A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C86C", Offset = "0x112C86C")]
		public uint id;

		// Token: 0x0400365B RID: 13915
		[Token(Token = "0x400365B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C880", Offset = "0x112C880")]
		public uint rank_type;

		// Token: 0x0400365C RID: 13916
		[Token(Token = "0x400365C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C894", Offset = "0x112C894")]
		public uint rank_lower;

		// Token: 0x0400365D RID: 13917
		[Token(Token = "0x400365D")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C8A8", Offset = "0x112C8A8")]
		public uint rank_upper;

		// Token: 0x0400365E RID: 13918
		[Token(Token = "0x400365E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C8BC", Offset = "0x112C8BC")]
		public List<AwardDesc> awards;
	}
}
