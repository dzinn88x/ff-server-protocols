using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200076C RID: 1900
	[Token(Token = "0x200076C")]
	[ProtoContract]
	public class CSChooseSlotsReq
	{
		// Token: 0x06002479 RID: 9337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002479")]
		[Address(RVA = "0x21B0758", Offset = "0x21B0758", VA = "0x7BBC9B0758")]
		public CSChooseSlotsReq()
		{
		}

		// Token: 0x04002527 RID: 9511
		[Token(Token = "0x4002527")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D7F0", Offset = "0x110D7F0")]
		public uint[] slots;
	}
}
