using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009D4 RID: 2516
	[Token(Token = "0x20009D4")]
	[ProtoContract]
	public class ParachuteDesc
	{
		// Token: 0x060026DE RID: 9950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DE")]
		[Address(RVA = "0x249EFB4", Offset = "0x249EFB4", VA = "0x7BBCC9EFB4")]
		public ParachuteDesc()
		{
		}

		// Token: 0x04002D83 RID: 11651
		[Token(Token = "0x4002D83")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B698", Offset = "0x111B698")]
		public uint item_id;
	}
}
