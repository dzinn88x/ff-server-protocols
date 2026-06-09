using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000719 RID: 1817
	[Token(Token = "0x2000719")]
	[ProtoContract]
	public class CSGetHeroicInfoRes
	{
		// Token: 0x06002426 RID: 9254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002426")]
		[Address(RVA = "0x21B41C8", Offset = "0x21B41C8", VA = "0x7BBC9B41C8")]
		public CSGetHeroicInfoRes()
		{
		}

		// Token: 0x04002436 RID: 9270
		[Token(Token = "0x4002436")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BF18", Offset = "0x110BF18")]
		public uint[] br_reached_season;

		// Token: 0x04002437 RID: 9271
		[Token(Token = "0x4002437")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BF54", Offset = "0x110BF54")]
		public uint[] cs_reached_season;
	}
}
