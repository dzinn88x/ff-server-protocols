using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005DF RID: 1503
	[Token(Token = "0x20005DF")]
	[ProtoContract]
	public class AccountRegionSlice
	{
		// Token: 0x0600235F RID: 9055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235F")]
		[Address(RVA = "0x21AE7E8", Offset = "0x21AE7E8", VA = "0x7BBC9AE7E8")]
		public AccountRegionSlice()
		{
		}

		// Token: 0x04001DC7 RID: 7623
		[Token(Token = "0x4001DC7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110549C", Offset = "0x110549C")]
		public ulong account_id;

		// Token: 0x04001DC8 RID: 7624
		[Token(Token = "0x4001DC8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11054B0", Offset = "0x11054B0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11054B0", Offset = "0x11054B0")]
		public string noti_region;

		// Token: 0x04001DC9 RID: 7625
		[Token(Token = "0x4001DC9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105500", Offset = "0x1105500")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105500", Offset = "0x1105500")]
		public string lock_region;
	}
}
