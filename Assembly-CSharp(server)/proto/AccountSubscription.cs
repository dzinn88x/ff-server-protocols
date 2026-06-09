using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000940 RID: 2368
	[Token(Token = "0x2000940")]
	[ProtoContract]
	public class AccountSubscription
	{
		// Token: 0x0600264E RID: 9806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264E")]
		[Address(RVA = "0x21AE84C", Offset = "0x21AE84C", VA = "0x7BBC9AE84C")]
		public AccountSubscription()
		{
		}

		// Token: 0x04002BA3 RID: 11171
		[Token(Token = "0x4002BA3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118EC0", Offset = "0x1118EC0")]
		public ulong account_id;

		// Token: 0x04002BA4 RID: 11172
		[Token(Token = "0x4002BA4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118ED4", Offset = "0x1118ED4")]
		public uint store_id;

		// Token: 0x04002BA5 RID: 11173
		[Token(Token = "0x4002BA5")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118EE8", Offset = "0x1118EE8")]
		public bool can_claim_reward;
	}
}
