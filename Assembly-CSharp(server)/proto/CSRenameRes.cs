using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000728 RID: 1832
	[Token(Token = "0x2000728")]
	[ProtoContract]
	public class CSRenameRes
	{
		// Token: 0x06002435 RID: 9269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002435")]
		[Address(RVA = "0x21B7494", Offset = "0x21B7494", VA = "0x7BBC9B7494")]
		public CSRenameRes()
		{
		}

		// Token: 0x04002462 RID: 9314
		[Token(Token = "0x4002462")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C33C", Offset = "0x110C33C")]
		public uint pet_id;

		// Token: 0x04002463 RID: 9315
		[Token(Token = "0x4002463")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110C350", Offset = "0x110C350")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C350", Offset = "0x110C350")]
		public string name;
	}
}
