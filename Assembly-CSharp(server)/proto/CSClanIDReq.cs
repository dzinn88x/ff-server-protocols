using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007D5 RID: 2005
	[Token(Token = "0x20007D5")]
	[ProtoContract]
	public class CSClanIDReq
	{
		// Token: 0x060024E4 RID: 9444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E4")]
		[Address(RVA = "0x21B09C0", Offset = "0x21B09C0", VA = "0x7BBC9B09C0")]
		public CSClanIDReq()
		{
		}

		// Token: 0x0400265D RID: 9821
		[Token(Token = "0x400265D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FAB4", Offset = "0x110FAB4")]
		public ulong clan_id;
	}
}
