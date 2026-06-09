using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007D6 RID: 2006
	[Token(Token = "0x20007D6")]
	[ProtoContract]
	public class CSClanIDRes
	{
		// Token: 0x060024E5 RID: 9445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E5")]
		[Address(RVA = "0x21B09C8", Offset = "0x21B09C8", VA = "0x7BBC9B09C8")]
		public CSClanIDRes()
		{
		}

		// Token: 0x0400265E RID: 9822
		[Token(Token = "0x400265E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FAC8", Offset = "0x110FAC8")]
		public ulong clan_id;
	}
}
