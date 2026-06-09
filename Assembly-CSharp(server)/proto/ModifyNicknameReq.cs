using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005E4 RID: 1508
	[Token(Token = "0x20005E4")]
	[ProtoContract]
	public class ModifyNicknameReq
	{
		// Token: 0x06002364 RID: 9060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002364")]
		[Address(RVA = "0x21BCBFC", Offset = "0x21BCBFC", VA = "0x7BBC9BCBFC")]
		public ModifyNicknameReq()
		{
		}

		// Token: 0x04001DD3 RID: 7635
		[Token(Token = "0x4001DD3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105730", Offset = "0x1105730")]
		public ulong account_id;

		// Token: 0x04001DD4 RID: 7636
		[Token(Token = "0x4001DD4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105744", Offset = "0x1105744")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105744", Offset = "0x1105744")]
		public string nickname;

		// Token: 0x04001DD5 RID: 7637
		[Token(Token = "0x4001DD5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105794", Offset = "0x1105794")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105794", Offset = "0x1105794")]
		public string lock_region;

		// Token: 0x04001DD6 RID: 7638
		[Token(Token = "0x4001DD6")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11057E4", Offset = "0x11057E4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11057E4", Offset = "0x11057E4")]
		public string noti_region;

		// Token: 0x04001DD7 RID: 7639
		[Token(Token = "0x4001DD7")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105834", Offset = "0x1105834")]
		public bool use_card;

		// Token: 0x04001DD8 RID: 7640
		[Token(Token = "0x4001DD8")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105848", Offset = "0x1105848")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105848", Offset = "0x1105848")]
		public string ip_address;

		// Token: 0x04001DD9 RID: 7641
		[Token(Token = "0x4001DD9")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105898", Offset = "0x1105898")]
		public uint client_type;
	}
}
