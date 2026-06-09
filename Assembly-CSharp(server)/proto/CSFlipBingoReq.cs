using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007C7 RID: 1991
	[Token(Token = "0x20007C7")]
	[ProtoContract]
	public class CSFlipBingoReq
	{
		// Token: 0x060024D6 RID: 9430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D6")]
		[Address(RVA = "0x21B14C0", Offset = "0x21B14C0", VA = "0x7BBC9B14C0")]
		public CSFlipBingoReq()
		{
		}

		// Token: 0x04002617 RID: 9751
		[Token(Token = "0x4002617")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F104", Offset = "0x110F104")]
		public uint activity_id;

		// Token: 0x04002618 RID: 9752
		[Token(Token = "0x4002618")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F118", Offset = "0x110F118")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F118", Offset = "0x110F118")]
		public string language;
	}
}
