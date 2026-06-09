using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000605 RID: 1541
	[Token(Token = "0x2000605")]
	[ProtoContract]
	public class AccountNewsContent
	{
		// Token: 0x06002381 RID: 9089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002381")]
		[Address(RVA = "0x21AE688", Offset = "0x21AE688", VA = "0x7BBC9AE688")]
		public AccountNewsContent()
		{
		}

		// Token: 0x04001EBA RID: 7866
		[Token(Token = "0x4001EBA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110701C", Offset = "0x110701C")]
		public uint[] item_ids;

		// Token: 0x04001EBB RID: 7867
		[Token(Token = "0x4001EBB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107058", Offset = "0x1107058")]
		public uint rank;

		// Token: 0x04001EBC RID: 7868
		[Token(Token = "0x4001EBC")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110706C", Offset = "0x110706C")]
		public uint match_mode;

		// Token: 0x04001EBD RID: 7869
		[Token(Token = "0x4001EBD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107080", Offset = "0x1107080")]
		public uint map_id;

		// Token: 0x04001EBE RID: 7870
		[Token(Token = "0x4001EBE")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107094", Offset = "0x1107094")]
		public uint game_mode;

		// Token: 0x04001EBF RID: 7871
		[Token(Token = "0x4001EBF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11070A8", Offset = "0x11070A8")]
		public uint group_mode;

		// Token: 0x04001EC0 RID: 7872
		[Token(Token = "0x4001EC0")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11070BC", Offset = "0x11070BC")]
		public uint treasurebox_id;

		// Token: 0x04001EC1 RID: 7873
		[Token(Token = "0x4001EC1")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11070D0", Offset = "0x11070D0")]
		public uint commodity_id;

		// Token: 0x04001EC2 RID: 7874
		[Token(Token = "0x4001EC2")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11070E4", Offset = "0x11070E4")]
		public uint store_id;
	}
}
