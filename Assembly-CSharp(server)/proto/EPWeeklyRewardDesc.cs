using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A7F RID: 2687
	[Token(Token = "0x2000A7F")]
	[ProtoContract]
	public class EPWeeklyRewardDesc
	{
		// Token: 0x06002789 RID: 10121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002789")]
		[Address(RVA = "0x21B9A98", Offset = "0x21B9A98", VA = "0x7BBC9B9A98")]
		public EPWeeklyRewardDesc()
		{
		}

		// Token: 0x04003172 RID: 12658
		[Token(Token = "0x4003172")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122D30", Offset = "0x1122D30")]
		public uint ep_event_id;

		// Token: 0x04003173 RID: 12659
		[Token(Token = "0x4003173")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122D44", Offset = "0x1122D44")]
		public uint week_id;

		// Token: 0x04003174 RID: 12660
		[Token(Token = "0x4003174")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122D58", Offset = "0x1122D58")]
		public uint node_id;

		// Token: 0x04003175 RID: 12661
		[Token(Token = "0x4003175")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122D6C", Offset = "0x1122D6C")]
		public uint challenge_num;

		// Token: 0x04003176 RID: 12662
		[Token(Token = "0x4003176")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122D80", Offset = "0x1122D80")]
		public List<AwardDesc> awards;
	}
}
