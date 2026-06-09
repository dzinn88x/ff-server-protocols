using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000727 RID: 1831
	[Token(Token = "0x2000727")]
	[ProtoContract]
	public class CSRenamePetReq
	{
		// Token: 0x06002434 RID: 9268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002434")]
		[Address(RVA = "0x21B7438", Offset = "0x21B7438", VA = "0x7BBC9B7438")]
		public CSRenamePetReq()
		{
		}

		// Token: 0x04002460 RID: 9312
		[Token(Token = "0x4002460")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C2D8", Offset = "0x110C2D8")]
		public uint pet_id;

		// Token: 0x04002461 RID: 9313
		[Token(Token = "0x4002461")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C2EC", Offset = "0x110C2EC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110C2EC", Offset = "0x110C2EC")]
		public string name;
	}
}
