using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000584 RID: 1412
	[Token(Token = "0x2000584")]
	[ProtoContract]
	public class ActivationStatusReq
	{
		// Token: 0x06002343 RID: 9027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002343")]
		[Address(RVA = "0x21AE8C0", Offset = "0x21AE8C0", VA = "0x7BBC9AE8C0")]
		public ActivationStatusReq()
		{
		}

		// Token: 0x04001B8D RID: 7053
		[Token(Token = "0x4001B8D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1104FC4", Offset = "0x1104FC4")]
		public ulong account_id;

		// Token: 0x04001B8E RID: 7054
		[Token(Token = "0x4001B8E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1104FD8", Offset = "0x1104FD8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1104FD8", Offset = "0x1104FD8")]
		public string lock_region;

		// Token: 0x04001B8F RID: 7055
		[Token(Token = "0x4001B8F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105028", Offset = "0x1105028")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105028", Offset = "0x1105028")]
		public string client_version;

		// Token: 0x04001B90 RID: 7056
		[Token(Token = "0x4001B90")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105078", Offset = "0x1105078")]
		public uint plat_id;

		// Token: 0x04001B91 RID: 7057
		[Token(Token = "0x4001B91")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110508C", Offset = "0x110508C")]
		public bool is_trial;
	}
}
