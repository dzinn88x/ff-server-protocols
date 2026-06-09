using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000927 RID: 2343
	[Token(Token = "0x2000927")]
	[ProtoContract]
	public class SubmitChampionshipTeamMatchStatsReq
	{
		// Token: 0x06002635 RID: 9781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002635")]
		[Address(RVA = "0x24A0984", Offset = "0x24A0984", VA = "0x7BBCCA0984")]
		public SubmitChampionshipTeamMatchStatsReq()
		{
		}

		// Token: 0x04002B69 RID: 11113
		[Token(Token = "0x4002B69")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118920", Offset = "0x1118920")]
		public ulong match_id;

		// Token: 0x04002B6A RID: 11114
		[Token(Token = "0x4002B6A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118934", Offset = "0x1118934")]
		public uint championship_type;

		// Token: 0x04002B6B RID: 11115
		[Token(Token = "0x4002B6B")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118948", Offset = "0x1118948")]
		public uint team_count;

		// Token: 0x04002B6C RID: 11116
		[Token(Token = "0x4002B6C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111895C", Offset = "0x111895C")]
		public TeamMatchStats team_stats;

		// Token: 0x04002B6D RID: 11117
		[Token(Token = "0x4002B6D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118970", Offset = "0x1118970")]
		public uint create_time;

		// Token: 0x04002B6E RID: 11118
		[Token(Token = "0x4002B6E")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118984", Offset = "0x1118984")]
		public uint end_time;

		// Token: 0x04002B6F RID: 11119
		[Token(Token = "0x4002B6F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118998", Offset = "0x1118998")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1118998", Offset = "0x1118998")]
		public string noti_region;

		// Token: 0x04002B70 RID: 11120
		[Token(Token = "0x4002B70")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11189E8", Offset = "0x11189E8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11189E8", Offset = "0x11189E8")]
		public string lock_region;

		// Token: 0x04002B71 RID: 11121
		[Token(Token = "0x4002B71")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118A38", Offset = "0x1118A38")]
		public bool is_fake;
	}
}
