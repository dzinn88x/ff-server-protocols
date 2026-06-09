using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000933 RID: 2355
	[Token(Token = "0x2000933")]
	[ProtoContract]
	public class CSGetFreshActivityRewardsReq
	{
		// Token: 0x06002641 RID: 9793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002641")]
		[Address(RVA = "0x21B3898", Offset = "0x21B3898", VA = "0x7BBC9B3898")]
		public CSGetFreshActivityRewardsReq()
		{
		}

		// Token: 0x04002B87 RID: 11143
		[Token(Token = "0x4002B87")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118BF0", Offset = "0x1118BF0")]
		public uint[] activity_ids;

		// Token: 0x04002B88 RID: 11144
		[Token(Token = "0x4002B88")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118C2C", Offset = "0x1118C2C")]
		public bool is_daily;
	}
}
