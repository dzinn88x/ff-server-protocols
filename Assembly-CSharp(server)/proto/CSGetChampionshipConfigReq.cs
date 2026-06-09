using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000913 RID: 2323
	[Token(Token = "0x2000913")]
	[ProtoContract]
	public class CSGetChampionshipConfigReq
	{
		// Token: 0x06002621 RID: 9761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002621")]
		[Address(RVA = "0x21B2AB0", Offset = "0x21B2AB0", VA = "0x7BBC9B2AB0")]
		public CSGetChampionshipConfigReq()
		{
		}

		// Token: 0x04002B14 RID: 11028
		[Token(Token = "0x4002B14")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11181F0", Offset = "0x11181F0")]
		public uint championship_type;

		// Token: 0x04002B15 RID: 11029
		[Token(Token = "0x4002B15")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118204", Offset = "0x1118204")]
		public uint championship_id;

		// Token: 0x04002B16 RID: 11030
		[Token(Token = "0x4002B16")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1118218", Offset = "0x1118218")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118218", Offset = "0x1118218")]
		public string language;
	}
}
