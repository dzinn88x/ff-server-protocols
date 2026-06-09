using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A61 RID: 2657
	[Token(Token = "0x2000A61")]
	[ProtoContract]
	public class SkillInfo
	{
		// Token: 0x0600276B RID: 10091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276B")]
		[Address(RVA = "0x24A05F0", Offset = "0x24A05F0", VA = "0x7BBCCA05F0")]
		public SkillInfo()
		{
		}

		// Token: 0x04003092 RID: 12434
		[Token(Token = "0x4003092")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11214F8", Offset = "0x11214F8")]
		public uint skill_id;

		// Token: 0x04003093 RID: 12435
		[Token(Token = "0x4003093")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112150C", Offset = "0x112150C")]
		public uint pre_skill_id;

		// Token: 0x04003094 RID: 12436
		[Token(Token = "0x4003094")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121520", Offset = "0x1121520")]
		public uint avatar_id;

		// Token: 0x04003095 RID: 12437
		[Token(Token = "0x4003095")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121534", Offset = "0x1121534")]
		public bool is_active_skill;

		// Token: 0x04003096 RID: 12438
		[Token(Token = "0x4003096")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121548", Offset = "0x1121548")]
		public uint skill_level;
	}
}
