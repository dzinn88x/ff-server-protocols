using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A0F RID: 2575
	[Token(Token = "0x2000A0F")]
	[ProtoContract]
	public class RankingLevelLimitDesc
	{
		// Token: 0x06002719 RID: 10009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002719")]
		[Address(RVA = "0x249FA98", Offset = "0x249FA98", VA = "0x7BBCC9FA98")]
		public RankingLevelLimitDesc()
		{
		}

		// Token: 0x04002F02 RID: 12034
		[Token(Token = "0x4002F02")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E6E0", Offset = "0x111E6E0")]
		public uint match_mode;

		// Token: 0x04002F03 RID: 12035
		[Token(Token = "0x4002F03")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E6F4", Offset = "0x111E6F4")]
		public uint game_mode;

		// Token: 0x04002F04 RID: 12036
		[Token(Token = "0x4002F04")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E708", Offset = "0x111E708")]
		public uint guest_level;

		// Token: 0x04002F05 RID: 12037
		[Token(Token = "0x4002F05")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E71C", Offset = "0x111E71C")]
		public uint normal_level;

		// Token: 0x04002F06 RID: 12038
		[Token(Token = "0x4002F06")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E730", Offset = "0x111E730")]
		public uint guest_register_need_time;

		// Token: 0x04002F07 RID: 12039
		[Token(Token = "0x4002F07")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E744", Offset = "0x111E744")]
		public uint normal_register_need_time;
	}
}
