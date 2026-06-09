using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ADC RID: 2780
	[Token(Token = "0x2000ADC")]
	[ProtoContract]
	public class ManualChallengeDesc
	{
		// Token: 0x060027E4 RID: 10212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E4")]
		[Address(RVA = "0x21BC3F4", Offset = "0x21BC3F4", VA = "0x7BBC9BC3F4")]
		public ManualChallengeDesc()
		{
		}

		// Token: 0x04003434 RID: 13364
		[Token(Token = "0x4003434")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11280DC", Offset = "0x11280DC")]
		public uint event_id;

		// Token: 0x04003435 RID: 13365
		[Token(Token = "0x4003435")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11280F0", Offset = "0x11280F0")]
		public EManual.EventType Type;

		// Token: 0x04003436 RID: 13366
		[Token(Token = "0x4003436")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128104", Offset = "0x1128104")]
		public uint param1;

		// Token: 0x04003437 RID: 13367
		[Token(Token = "0x4003437")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128118", Offset = "0x1128118")]
		public uint param2;
	}
}
