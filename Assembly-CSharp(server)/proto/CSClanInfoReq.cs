using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007DA RID: 2010
	[Token(Token = "0x20007DA")]
	[ProtoContract]
	public class CSClanInfoReq
	{
		// Token: 0x060024E9 RID: 9449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E9")]
		[Address(RVA = "0x21B0A44", Offset = "0x21B0A44", VA = "0x7BBC9B0A44")]
		public CSClanInfoReq()
		{
		}

		// Token: 0x04002662 RID: 9826
		[Token(Token = "0x4002662")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FB54", Offset = "0x110FB54")]
		public ulong clan_id;

		// Token: 0x04002663 RID: 9827
		[Token(Token = "0x4002663")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FB68", Offset = "0x110FB68")]
		public bool ignore_region;
	}
}
