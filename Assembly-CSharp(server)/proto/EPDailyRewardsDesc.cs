using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A84 RID: 2692
	[Token(Token = "0x2000A84")]
	[ProtoContract]
	public class EPDailyRewardsDesc
	{
		// Token: 0x0600278E RID: 10126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278E")]
		[Address(RVA = "0x21B9914", Offset = "0x21B9914", VA = "0x7BBC9B9914")]
		public EPDailyRewardsDesc()
		{
		}

		// Token: 0x0400317D RID: 12669
		[Token(Token = "0x400317D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122E0C", Offset = "0x1122E0C")]
		public uint ep_event_id;

		// Token: 0x0400317E RID: 12670
		[Token(Token = "0x400317E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122E20", Offset = "0x1122E20")]
		public uint count_num;

		// Token: 0x0400317F RID: 12671
		[Token(Token = "0x400317F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122E34", Offset = "0x1122E34")]
		public uint award_id;

		// Token: 0x04003180 RID: 12672
		[Token(Token = "0x4003180")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122E48", Offset = "0x1122E48")]
		public uint award_num;

		// Token: 0x04003181 RID: 12673
		[Token(Token = "0x4003181")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122E5C", Offset = "0x1122E5C")]
		public uint ep_award_num;
	}
}
