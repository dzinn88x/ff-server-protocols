using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B41 RID: 2881
	[Token(Token = "0x2000B41")]
	[ProtoContract]
	public class RecommendAlgo
	{
		// Token: 0x06002849 RID: 10313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002849")]
		[Address(RVA = "0x249FC98", Offset = "0x249FC98", VA = "0x7BBCC9FC98")]
		public RecommendAlgo()
		{
		}

		// Token: 0x040036AC RID: 13996
		[Token(Token = "0x40036AC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D2D0", Offset = "0x112D2D0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112D2D0", Offset = "0x112D2D0")]
		public string name;

		// Token: 0x040036AD RID: 13997
		[Token(Token = "0x40036AD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D320", Offset = "0x112D320")]
		public uint weight;
	}
}
