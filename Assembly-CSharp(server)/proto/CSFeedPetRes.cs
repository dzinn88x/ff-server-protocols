using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000725 RID: 1829
	[Token(Token = "0x2000725")]
	[ProtoContract]
	public class CSFeedPetRes
	{
		// Token: 0x06002432 RID: 9266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002432")]
		[Address(RVA = "0x21B1374", Offset = "0x21B1374", VA = "0x7BBC9B1374")]
		public CSFeedPetRes()
		{
		}

		// Token: 0x04002459 RID: 9305
		[Token(Token = "0x4002459")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C24C", Offset = "0x110C24C")]
		public uint old_level;

		// Token: 0x0400245A RID: 9306
		[Token(Token = "0x400245A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C260", Offset = "0x110C260")]
		public uint new_level;

		// Token: 0x0400245B RID: 9307
		[Token(Token = "0x400245B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C274", Offset = "0x110C274")]
		public uint old_exp;

		// Token: 0x0400245C RID: 9308
		[Token(Token = "0x400245C")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C288", Offset = "0x110C288")]
		public uint new_exp;

		// Token: 0x0400245D RID: 9309
		[Token(Token = "0x400245D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C29C", Offset = "0x110C29C")]
		public uint add_exp;
	}
}
