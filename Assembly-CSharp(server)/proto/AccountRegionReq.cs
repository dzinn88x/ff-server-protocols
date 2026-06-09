using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000627 RID: 1575
	[Token(Token = "0x2000627")]
	[ProtoContract]
	public class AccountRegionReq
	{
		// Token: 0x06002398 RID: 9112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002398")]
		[Address(RVA = "0x21AE78C", Offset = "0x21AE78C", VA = "0x7BBC9AE78C")]
		public AccountRegionReq()
		{
		}

		// Token: 0x04001F5C RID: 8028
		[Token(Token = "0x4001F5C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107DB4", Offset = "0x1107DB4")]
		public ulong account_id;

		// Token: 0x04001F5D RID: 8029
		[Token(Token = "0x4001F5D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107DC8", Offset = "0x1107DC8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107DC8", Offset = "0x1107DC8")]
		public string lock_region;

		// Token: 0x04001F5E RID: 8030
		[Token(Token = "0x4001F5E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107E18", Offset = "0x1107E18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107E18", Offset = "0x1107E18")]
		public string noti_region;
	}
}
