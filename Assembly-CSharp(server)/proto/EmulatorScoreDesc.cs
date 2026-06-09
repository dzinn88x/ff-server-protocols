using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AD1 RID: 2769
	[Token(Token = "0x2000AD1")]
	[ProtoContract]
	public class EmulatorScoreDesc
	{
		// Token: 0x060027D9 RID: 10201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D9")]
		[Address(RVA = "0x21B9B7C", Offset = "0x21B9B7C", VA = "0x7BBC9B9B7C")]
		public EmulatorScoreDesc()
		{
		}

		// Token: 0x04003407 RID: 13319
		[Token(Token = "0x4003407")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11279D4", Offset = "0x11279D4")]
		public bool check_emulator;

		// Token: 0x04003408 RID: 13320
		[Token(Token = "0x4003408")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11279E8", Offset = "0x11279E8")]
		public uint no_sensor_score;

		// Token: 0x04003409 RID: 13321
		[Token(Token = "0x4003409")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11279FC", Offset = "0x11279FC")]
		public uint root_no_sensor_score;
	}
}
