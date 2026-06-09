using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200073A RID: 1850
	[Token(Token = "0x200073A")]
	[ProtoContract]
	public class CSGetCupConfigReq
	{
		// Token: 0x06002447 RID: 9287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002447")]
		[Address(RVA = "0x21B2D98", Offset = "0x21B2D98", VA = "0x7BBC9B2D98")]
		public CSGetCupConfigReq()
		{
		}

		// Token: 0x0400249B RID: 9371
		[Token(Token = "0x400249B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C918", Offset = "0x110C918")]
		public uint cup_type;

		// Token: 0x0400249C RID: 9372
		[Token(Token = "0x400249C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C92C", Offset = "0x110C92C")]
		public uint cup_id;

		// Token: 0x0400249D RID: 9373
		[Token(Token = "0x400249D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C940", Offset = "0x110C940")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110C940", Offset = "0x110C940")]
		public string language;
	}
}
