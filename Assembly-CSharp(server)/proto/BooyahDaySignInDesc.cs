using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B21 RID: 2849
	[Token(Token = "0x2000B21")]
	[ProtoContract]
	public class BooyahDaySignInDesc
	{
		// Token: 0x06002829 RID: 10281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002829")]
		[Address(RVA = "0x21AFE14", Offset = "0x21AFE14", VA = "0x7BBC9AFE14")]
		public BooyahDaySignInDesc()
		{
		}

		// Token: 0x04003609 RID: 13833
		[Token(Token = "0x4003609")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BFC0", Offset = "0x112BFC0")]
		public uint sign_id;

		// Token: 0x0400360A RID: 13834
		[Token(Token = "0x400360A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BFD4", Offset = "0x112BFD4")]
		public uint booyah_num;

		// Token: 0x0400360B RID: 13835
		[Token(Token = "0x400360B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BFE8", Offset = "0x112BFE8")]
		public uint token_id;

		// Token: 0x0400360C RID: 13836
		[Token(Token = "0x400360C")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BFFC", Offset = "0x112BFFC")]
		public uint token_num;
	}
}
