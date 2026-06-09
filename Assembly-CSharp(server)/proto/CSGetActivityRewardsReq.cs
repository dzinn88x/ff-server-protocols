using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007C2 RID: 1986
	[Token(Token = "0x20007C2")]
	[ProtoContract]
	public class CSGetActivityRewardsReq
	{
		// Token: 0x060024D1 RID: 9425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D1")]
		[Address(RVA = "0x21B1B7C", Offset = "0x21B1B7C", VA = "0x7BBC9B1B7C")]
		public CSGetActivityRewardsReq()
		{
		}

		// Token: 0x0400260E RID: 9742
		[Token(Token = "0x400260E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EF4C", Offset = "0x110EF4C")]
		public uint[] activity_ids;

		// Token: 0x0400260F RID: 9743
		[Token(Token = "0x400260F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110EF88", Offset = "0x110EF88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EF88", Offset = "0x110EF88")]
		public string language;
	}
}
