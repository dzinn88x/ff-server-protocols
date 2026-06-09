using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008A8 RID: 2216
	[Token(Token = "0x20008A8")]
	[ProtoContract]
	public class CSSendGiftReq
	{
		// Token: 0x060025B6 RID: 9654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B6")]
		[Address(RVA = "0x21B7600", Offset = "0x21B7600", VA = "0x7BBC9B7600")]
		public CSSendGiftReq()
		{
		}

		// Token: 0x040029C6 RID: 10694
		[Token(Token = "0x40029C6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115D4C", Offset = "0x1115D4C")]
		public ulong[] receiver_account_ids;

		// Token: 0x040029C7 RID: 10695
		[Token(Token = "0x40029C7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115D88", Offset = "0x1115D88")]
		public EGiftStore_BuddyType buddy_type;

		// Token: 0x040029C8 RID: 10696
		[Token(Token = "0x40029C8")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115D9C", Offset = "0x1115D9C")]
		public uint commodity_id;

		// Token: 0x040029C9 RID: 10697
		[Token(Token = "0x40029C9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115DB0", Offset = "0x1115DB0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1115DB0", Offset = "0x1115DB0")]
		public string message_content;

		// Token: 0x040029CA RID: 10698
		[Token(Token = "0x40029CA")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115E00", Offset = "0x1115E00")]
		public EInventory.CurrencyType currency_type;

		// Token: 0x040029CB RID: 10699
		[Token(Token = "0x40029CB")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115E14", Offset = "0x1115E14")]
		public ulong clan_id;

		// Token: 0x040029CC RID: 10700
		[Token(Token = "0x40029CC")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115E28", Offset = "0x1115E28")]
		public uint commodity_cnt;

		// Token: 0x040029CD RID: 10701
		[Token(Token = "0x40029CD")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115E3C", Offset = "0x1115E3C")]
		public uint voucher_id;
	}
}
