using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007C3 RID: 1987
	[Token(Token = "0x20007C3")]
	[ProtoContract]
	public class CSGetActivityRewardsRes
	{
		// Token: 0x060024D2 RID: 9426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D2")]
		[Address(RVA = "0x21B1BD8", Offset = "0x21B1BD8", VA = "0x7BBC9B1BD8")]
		public CSGetActivityRewardsRes()
		{
		}

		// Token: 0x04002610 RID: 9744
		[Token(Token = "0x4002610")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EFD8", Offset = "0x110EFD8")]
		public AwardData awards;
	}
}
