using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007CF RID: 1999
	[Token(Token = "0x20007CF")]
	[ProtoContract]
	public class ClientActivityBingoInfoDesc
	{
		// Token: 0x060024DE RID: 9438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DE")]
		[Address(RVA = "0x21B8B2C", Offset = "0x21B8B2C", VA = "0x7BBC9B8B2C")]
		public ClientActivityBingoInfoDesc()
		{
		}

		// Token: 0x04002630 RID: 9776
		[Token(Token = "0x4002630")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F49C", Offset = "0x110F49C")]
		public uint level;

		// Token: 0x04002631 RID: 9777
		[Token(Token = "0x4002631")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F4B0", Offset = "0x110F4B0")]
		public uint key_id;

		// Token: 0x04002632 RID: 9778
		[Token(Token = "0x4002632")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F4C4", Offset = "0x110F4C4")]
		public uint init_key_num;

		// Token: 0x04002633 RID: 9779
		[Token(Token = "0x4002633")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F4D8", Offset = "0x110F4D8")]
		public uint cost_key_num;

		// Token: 0x04002634 RID: 9780
		[Token(Token = "0x4002634")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F4EC", Offset = "0x110F4EC")]
		public uint cost_diamond;

		// Token: 0x04002635 RID: 9781
		[Token(Token = "0x4002635")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F500", Offset = "0x110F500")]
		public long start_time;

		// Token: 0x04002636 RID: 9782
		[Token(Token = "0x4002636")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F514", Offset = "0x110F514")]
		public long end_time;
	}
}
