using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A69 RID: 2665
	[Token(Token = "0x2000A69")]
	[ProtoContract]
	public class DispatchQuestDesc
	{
		// Token: 0x06002773 RID: 10099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002773")]
		[Address(RVA = "0x21B96D8", Offset = "0x21B96D8", VA = "0x7BBC9B96D8")]
		public DispatchQuestDesc()
		{
		}

		// Token: 0x040030B7 RID: 12471
		[Token(Token = "0x40030B7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11219D0", Offset = "0x11219D0")]
		public uint quest_line;

		// Token: 0x040030B8 RID: 12472
		[Token(Token = "0x40030B8")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11219E4", Offset = "0x11219E4")]
		public uint quest_id;

		// Token: 0x040030B9 RID: 12473
		[Token(Token = "0x40030B9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11219F8", Offset = "0x11219F8")]
		public bool is_repeated;

		// Token: 0x040030BA RID: 12474
		[Token(Token = "0x40030BA")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121A0C", Offset = "0x1121A0C")]
		public float quest_time;

		// Token: 0x040030BB RID: 12475
		[Token(Token = "0x40030BB")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121A20", Offset = "0x1121A20")]
		public uint quest_number;

		// Token: 0x040030BC RID: 12476
		[Token(Token = "0x40030BC")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121A34", Offset = "0x1121A34")]
		public List<ExchangedAward> awards;

		// Token: 0x040030BD RID: 12477
		[Token(Token = "0x40030BD")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121A48", Offset = "0x1121A48")]
		public float critical_rate;

		// Token: 0x040030BE RID: 12478
		[Token(Token = "0x40030BE")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121A5C", Offset = "0x1121A5C")]
		public uint critical_times;
	}
}
