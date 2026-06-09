using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A30 RID: 2608
	[Token(Token = "0x2000A30")]
	[ProtoContract]
	public class WhiteNicknameDesc
	{
		// Token: 0x0600273A RID: 10042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273A")]
		[Address(RVA = "0x24A1A9C", Offset = "0x24A1A9C", VA = "0x7BBCCA1A9C")]
		public WhiteNicknameDesc()
		{
		}

		// Token: 0x04002F97 RID: 12183
		[Token(Token = "0x4002F97")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FACC", Offset = "0x111FACC")]
		public uint id;

		// Token: 0x04002F98 RID: 12184
		[Token(Token = "0x4002F98")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FAE0", Offset = "0x111FAE0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111FAE0", Offset = "0x111FAE0")]
		public string nickname;
	}
}
