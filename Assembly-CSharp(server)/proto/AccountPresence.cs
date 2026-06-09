using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005EA RID: 1514
	[Token(Token = "0x20005EA")]
	[ProtoContract]
	public class AccountPresence
	{
		// Token: 0x0600236A RID: 9066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236A")]
		[Address(RVA = "0x21AE72C", Offset = "0x21AE72C", VA = "0x7BBC9AE72C")]
		public AccountPresence()
		{
		}

		// Token: 0x04001E39 RID: 7737
		[Token(Token = "0x4001E39")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11063C4", Offset = "0x11063C4")]
		public ulong account_id;

		// Token: 0x04001E3A RID: 7738
		[Token(Token = "0x4001E3A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11063D8", Offset = "0x11063D8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11063D8", Offset = "0x11063D8")]
		public string noti_region;

		// Token: 0x04001E3B RID: 7739
		[Token(Token = "0x4001E3B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106428", Offset = "0x1106428")]
		public EPresence.AccountPresence presence;

		// Token: 0x04001E3C RID: 7740
		[Token(Token = "0x4001E3C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110643C", Offset = "0x110643C")]
		public long update_time;

		// Token: 0x04001E3D RID: 7741
		[Token(Token = "0x4001E3D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106450", Offset = "0x1106450")]
		public long login_time;

		// Token: 0x04001E3E RID: 7742
		[Token(Token = "0x4001E3E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106464", Offset = "0x1106464")]
		public ulong group_id;

		// Token: 0x04001E3F RID: 7743
		[Token(Token = "0x4001E3F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106478", Offset = "0x1106478")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1106478", Offset = "0x1106478")]
		public string group_region;

		// Token: 0x04001E40 RID: 7744
		[Token(Token = "0x4001E40")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11064C8", Offset = "0x11064C8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11064C8", Offset = "0x11064C8")]
		public string lock_region;

		// Token: 0x04001E41 RID: 7745
		[Token(Token = "0x4001E41")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106518", Offset = "0x1106518")]
		public uint match_mode;

		// Token: 0x04001E42 RID: 7746
		[Token(Token = "0x4001E42")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110652C", Offset = "0x110652C")]
		public uint game_mode;

		// Token: 0x04001E43 RID: 7747
		[Token(Token = "0x4001E43")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106540", Offset = "0x1106540")]
		public uint map_id;
	}
}
