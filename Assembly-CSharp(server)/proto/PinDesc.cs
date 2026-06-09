using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009DB RID: 2523
	[Token(Token = "0x20009DB")]
	[ProtoContract]
	public class PinDesc
	{
		// Token: 0x060026E5 RID: 9957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E5")]
		[Address(RVA = "0x249F2C8", Offset = "0x249F2C8", VA = "0x7BBCC9F2C8")]
		public PinDesc()
		{
		}

		// Token: 0x04002D97 RID: 11671
		[Token(Token = "0x4002D97")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B8A0", Offset = "0x111B8A0")]
		public uint item_id;
	}
}
