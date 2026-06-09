using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007D8 RID: 2008
	[Token(Token = "0x20007D8")]
	[ProtoContract]
	public class CSClanNameReq
	{
		// Token: 0x060024E7 RID: 9447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E7")]
		[Address(RVA = "0x21B0AC8", Offset = "0x21B0AC8", VA = "0x7BBC9B0AC8")]
		public CSClanNameReq()
		{
		}

		// Token: 0x04002660 RID: 9824
		[Token(Token = "0x4002660")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FAF0", Offset = "0x110FAF0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110FAF0", Offset = "0x110FAF0")]
		public string clan_name;
	}
}
