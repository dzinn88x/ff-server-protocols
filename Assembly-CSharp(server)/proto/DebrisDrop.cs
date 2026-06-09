using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A6B RID: 2667
	[Token(Token = "0x2000A6B")]
	[ProtoContract]
	public class DebrisDrop
	{
		// Token: 0x06002775 RID: 10101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002775")]
		[Address(RVA = "0x21B9470", Offset = "0x21B9470", VA = "0x7BBC9B9470")]
		public DebrisDrop()
		{
		}

		// Token: 0x040030C3 RID: 12483
		[Token(Token = "0x40030C3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121AC0", Offset = "0x1121AC0")]
		public uint avatar_id;

		// Token: 0x040030C4 RID: 12484
		[Token(Token = "0x40030C4")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121AD4", Offset = "0x1121AD4")]
		public uint debris_id;

		// Token: 0x040030C5 RID: 12485
		[Token(Token = "0x40030C5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121AE8", Offset = "0x1121AE8")]
		public uint drop_param;

		// Token: 0x040030C6 RID: 12486
		[Token(Token = "0x40030C6")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121AFC", Offset = "0x1121AFC")]
		public uint drop_daily_max;

		// Token: 0x040030C7 RID: 12487
		[Token(Token = "0x40030C7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121B10", Offset = "0x1121B10")]
		public float skill_slot_drop_percent;
	}
}
