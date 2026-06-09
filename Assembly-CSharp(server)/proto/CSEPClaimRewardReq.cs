using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000881 RID: 2177
	[Token(Token = "0x2000881")]
	[ProtoContract]
	public class CSEPClaimRewardReq
	{
		// Token: 0x0600258F RID: 9615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600258F")]
		[Address(RVA = "0x21B0FFC", Offset = "0x21B0FFC", VA = "0x7BBC9B0FFC")]
		public CSEPClaimRewardReq()
		{
		}

		// Token: 0x040028BD RID: 10429
		[Token(Token = "0x40028BD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113830", Offset = "0x1113830")]
		public List<unlock> unlock_reward;

		// Token: 0x040028BE RID: 10430
		[Token(Token = "0x40028BE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1113844", Offset = "0x1113844")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113844", Offset = "0x1113844")]
		public string nickname;

		// Token: 0x040028BF RID: 10431
		[Token(Token = "0x40028BF")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113894", Offset = "0x1113894")]
		public bool claim_max_reward;
	}
}
