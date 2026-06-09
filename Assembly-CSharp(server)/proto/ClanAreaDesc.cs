using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A48 RID: 2632
	[Token(Token = "0x2000A48")]
	[ProtoContract]
	public class ClanAreaDesc
	{
		// Token: 0x06002752 RID: 10066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002752")]
		[Address(RVA = "0x21B85A4", Offset = "0x21B85A4", VA = "0x7BBC9B85A4")]
		public ClanAreaDesc()
		{
		}

		// Token: 0x04002FF6 RID: 12278
		[Token(Token = "0x4002FF6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11205F8", Offset = "0x11205F8")]
		public uint id;
	}
}
