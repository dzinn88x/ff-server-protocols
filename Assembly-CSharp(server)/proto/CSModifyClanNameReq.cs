using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007E8 RID: 2024
	[Token(Token = "0x20007E8")]
	[ProtoContract]
	public class CSModifyClanNameReq
	{
		// Token: 0x060024F7 RID: 9463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F7")]
		[Address(RVA = "0x21B695C", Offset = "0x21B695C", VA = "0x7BBC9B695C")]
		public CSModifyClanNameReq()
		{
		}

		// Token: 0x04002686 RID: 9862
		[Token(Token = "0x4002686")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FF8C", Offset = "0x110FF8C")]
		public ulong clan_id;

		// Token: 0x04002687 RID: 9863
		[Token(Token = "0x4002687")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110FFA0", Offset = "0x110FFA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FFA0", Offset = "0x110FFA0")]
		public string clan_name;
	}
}
