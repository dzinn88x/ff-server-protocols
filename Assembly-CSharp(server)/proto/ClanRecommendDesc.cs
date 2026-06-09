using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A43 RID: 2627
	[Token(Token = "0x2000A43")]
	[ProtoContract]
	public class ClanRecommendDesc
	{
		// Token: 0x0600274D RID: 10061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274D")]
		[Address(RVA = "0x21B8AA8", Offset = "0x21B8AA8", VA = "0x7BBC9B8AA8")]
		public ClanRecommendDesc()
		{
		}

		// Token: 0x04002FE9 RID: 12265
		[Token(Token = "0x4002FE9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1120404", Offset = "0x1120404")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120404", Offset = "0x1120404")]
		public string region;

		// Token: 0x04002FEA RID: 12266
		[Token(Token = "0x4002FEA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120454", Offset = "0x1120454")]
		public uint factor;
	}
}
