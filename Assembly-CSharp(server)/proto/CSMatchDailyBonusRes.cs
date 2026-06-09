using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006F2 RID: 1778
	[Token(Token = "0x20006F2")]
	[ProtoContract]
	public class CSMatchDailyBonusRes
	{
		// Token: 0x06002400 RID: 9216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002400")]
		[Address(RVA = "0x21B68F0", Offset = "0x21B68F0", VA = "0x7BBC9B68F0")]
		public CSMatchDailyBonusRes()
		{
		}

		// Token: 0x040022B7 RID: 8887
		[Token(Token = "0x40022B7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109E0C", Offset = "0x1109E0C")]
		public bool has_exp_achieved;

		// Token: 0x040022B8 RID: 8888
		[Token(Token = "0x40022B8")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109E20", Offset = "0x1109E20")]
		public uint exp_bonus;

		// Token: 0x040022B9 RID: 8889
		[Token(Token = "0x40022B9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109E34", Offset = "0x1109E34")]
		public bool has_gold_achieved;

		// Token: 0x040022BA RID: 8890
		[Token(Token = "0x40022BA")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109E48", Offset = "0x1109E48")]
		public uint gold_bonus;
	}
}
