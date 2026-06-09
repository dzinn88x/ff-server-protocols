using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007E5 RID: 2021
	[Token(Token = "0x20007E5")]
	[ProtoContract]
	public class CSQuitClanReq
	{
		// Token: 0x060024F4 RID: 9460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F4")]
		[Address(RVA = "0x21B6FF8", Offset = "0x21B6FF8", VA = "0x7BBC9B6FF8")]
		public CSQuitClanReq()
		{
		}

		// Token: 0x0400267B RID: 9851
		[Token(Token = "0x400267B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FDFC", Offset = "0x110FDFC")]
		public ulong clan_id;
	}
}
