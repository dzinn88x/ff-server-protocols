using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000997 RID: 2455
	[Token(Token = "0x2000997")]
	[ProtoContract]
	public class CSSupercarChangeCarReq
	{
		// Token: 0x060026A5 RID: 9893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A5")]
		[Address(RVA = "0x21B7720", Offset = "0x21B7720", VA = "0x7BBC9B7720")]
		public CSSupercarChangeCarReq()
		{
		}

		// Token: 0x04002C5E RID: 11358
		[Token(Token = "0x4002C5E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A02C", Offset = "0x111A02C")]
		public uint car_id;
	}
}
