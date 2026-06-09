using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000742 RID: 1858
	[Token(Token = "0x2000742")]
	[ProtoContract]
	public class CSGetAccountCupInfoBundleByAccountIDsOrderlyReq
	{
		// Token: 0x0600244F RID: 9295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244F")]
		[Address(RVA = "0x21B160C", Offset = "0x21B160C", VA = "0x7BBC9B160C")]
		public CSGetAccountCupInfoBundleByAccountIDsOrderlyReq()
		{
		}

		// Token: 0x040024C0 RID: 9408
		[Token(Token = "0x40024C0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CC38", Offset = "0x110CC38")]
		public uint cup_type;

		// Token: 0x040024C1 RID: 9409
		[Token(Token = "0x40024C1")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CC4C", Offset = "0x110CC4C")]
		public uint cup_id;

		// Token: 0x040024C2 RID: 9410
		[Token(Token = "0x40024C2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CC60", Offset = "0x110CC60")]
		public ulong[] account_ids;

		// Token: 0x040024C3 RID: 9411
		[Token(Token = "0x40024C3")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CC9C", Offset = "0x110CC9C")]
		public bool need_team_info;
	}
}
