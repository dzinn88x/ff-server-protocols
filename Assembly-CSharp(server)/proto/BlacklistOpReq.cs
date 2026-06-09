using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200068E RID: 1678
	[Token(Token = "0x200068E")]
	[ProtoContract]
	public class BlacklistOpReq
	{
		// Token: 0x060023CC RID: 9164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CC")]
		[Address(RVA = "0x21AFA6C", Offset = "0x21AFA6C", VA = "0x7BBC9AFA6C")]
		public BlacklistOpReq()
		{
		}

		// Token: 0x04002103 RID: 8451
		[Token(Token = "0x4002103")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108C28", Offset = "0x1108C28")]
		public EAccount.BlacklistOpType ban_type;

		// Token: 0x04002104 RID: 8452
		[Token(Token = "0x4002104")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108C3C", Offset = "0x1108C3C")]
		public ulong account_id;

		// Token: 0x04002105 RID: 8453
		[Token(Token = "0x4002105")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108C50", Offset = "0x1108C50")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1108C50", Offset = "0x1108C50")]
		public string device_id;

		// Token: 0x04002106 RID: 8454
		[Token(Token = "0x4002106")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1108CA0", Offset = "0x1108CA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108CA0", Offset = "0x1108CA0")]
		public string ban_reason_detail;

		// Token: 0x04002107 RID: 8455
		[Token(Token = "0x4002107")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1108CF0", Offset = "0x1108CF0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108CF0", Offset = "0x1108CF0")]
		public string noti_region;

		// Token: 0x04002108 RID: 8456
		[Token(Token = "0x4002108")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108D40", Offset = "0x1108D40")]
		public EAccount.BanReason ban_reason;

		// Token: 0x04002109 RID: 8457
		[Token(Token = "0x4002109")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108D54", Offset = "0x1108D54")]
		public uint ban_expire_timestamp;
	}
}
