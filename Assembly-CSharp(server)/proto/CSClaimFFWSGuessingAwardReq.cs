using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009BD RID: 2493
	[Token(Token = "0x20009BD")]
	[ProtoContract]
	public class CSClaimFFWSGuessingAwardReq
	{
		// Token: 0x060026CB RID: 9931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CB")]
		[Address(RVA = "0x21B082C", Offset = "0x21B082C", VA = "0x7BBC9B082C")]
		public CSClaimFFWSGuessingAwardReq()
		{
		}

		// Token: 0x04002CC0 RID: 11456
		[Token(Token = "0x4002CC0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A9C8", Offset = "0x111A9C8")]
		public uint session;
	}
}
