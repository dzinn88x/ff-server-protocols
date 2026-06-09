using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000872 RID: 2162
	[Token(Token = "0x2000872")]
	[ProtoContract]
	public class ExchangeItemNum
	{
		// Token: 0x06002580 RID: 9600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002580")]
		[Address(RVA = "0x21B9DFC", Offset = "0x21B9DFC", VA = "0x7BBC9B9DFC")]
		public ExchangeItemNum()
		{
		}

		// Token: 0x0400288A RID: 10378
		[Token(Token = "0x400288A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11132CC", Offset = "0x11132CC")]
		public uint itemId;

		// Token: 0x0400288B RID: 10379
		[Token(Token = "0x400288B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11132E0", Offset = "0x11132E0")]
		public uint num;
	}
}
