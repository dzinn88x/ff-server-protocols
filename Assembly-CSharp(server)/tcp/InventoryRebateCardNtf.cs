using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004BE RID: 1214
	[Token(Token = "0x20004BE")]
	[ProtoContract]
	public class InventoryRebateCardNtf
	{
		// Token: 0x06001EA8 RID: 7848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA8")]
		[Address(RVA = "0x24A423C", Offset = "0x24A423C", VA = "0x7BBCCA423C")]
		public InventoryRebateCardNtf()
		{
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001EA9 RID: 7849 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		// (set) Token: 0x06001EAA RID: 7850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000464")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156A60", Offset = "0x1156A60")]
		public uint txn_type
		{
			[Token(Token = "0x6001EA9")]
			[Address(RVA = "0x24A42A8", Offset = "0x24A42A8", VA = "0x7BBCCA42A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137064", Offset = "0x1137064")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001EAA")]
			[Address(RVA = "0x24A42B0", Offset = "0x24A42B0", VA = "0x7BBCCA42B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137074", Offset = "0x1137074")]
			set
			{
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001EAB RID: 7851 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		// (set) Token: 0x06001EAC RID: 7852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000465")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156A74", Offset = "0x1156A74")]
		public uint rebate_card_id
		{
			[Token(Token = "0x6001EAB")]
			[Address(RVA = "0x24A42B8", Offset = "0x24A42B8", VA = "0x7BBCCA42B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137084", Offset = "0x1137084")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001EAC")]
			[Address(RVA = "0x24A42C0", Offset = "0x24A42C0", VA = "0x7BBCCA42C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137094", Offset = "0x1137094")]
			set
			{
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		// (set) Token: 0x06001EAE RID: 7854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000466")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156A88", Offset = "0x1156A88")]
		public int point_amount
		{
			[Token(Token = "0x6001EAD")]
			[Address(RVA = "0x24A42C8", Offset = "0x24A42C8", VA = "0x7BBCCA42C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11370A4", Offset = "0x11370A4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001EAE")]
			[Address(RVA = "0x24A42D0", Offset = "0x24A42D0", VA = "0x7BBCCA42D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11370B4", Offset = "0x11370B4")]
			set
			{
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x0000D200 File Offset: 0x0000B400
		// (set) Token: 0x06001EB0 RID: 7856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000467")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156A9C", Offset = "0x1156A9C")]
		public uint channel_id
		{
			[Token(Token = "0x6001EAF")]
			[Address(RVA = "0x24A42D8", Offset = "0x24A42D8", VA = "0x7BBCCA42D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11370C4", Offset = "0x11370C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001EB0")]
			[Address(RVA = "0x24A42E0", Offset = "0x24A42E0", VA = "0x7BBCCA42E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11370D4", Offset = "0x11370D4")]
			set
			{
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EB2 RID: 7858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000468")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156AB0", Offset = "0x1156AB0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1156AB0", Offset = "0x1156AB0")]
		public string channel_name
		{
			[Token(Token = "0x6001EB1")]
			[Address(RVA = "0x24A42E8", Offset = "0x24A42E8", VA = "0x7BBCCA42E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11370E4", Offset = "0x11370E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EB2")]
			[Address(RVA = "0x24A4298", Offset = "0x24A4298", VA = "0x7BBCCA4298")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11370F4", Offset = "0x11370F4")]
			set
			{
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EB4 RID: 7860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000469")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156B00", Offset = "0x1156B00")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1156B00", Offset = "0x1156B00")]
		public string currency
		{
			[Token(Token = "0x6001EB3")]
			[Address(RVA = "0x24A42F0", Offset = "0x24A42F0", VA = "0x7BBCCA42F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137104", Offset = "0x1137104")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EB4")]
			[Address(RVA = "0x24A42A0", Offset = "0x24A42A0", VA = "0x7BBCCA42A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137114", Offset = "0x1137114")]
			set
			{
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x0000D218 File Offset: 0x0000B418
		// (set) Token: 0x06001EB6 RID: 7862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156B50", Offset = "0x1156B50")]
		public float currency_amount
		{
			[Token(Token = "0x6001EB5")]
			[Address(RVA = "0x24A42F8", Offset = "0x24A42F8", VA = "0x7BBCCA42F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137124", Offset = "0x1137124")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001EB6")]
			[Address(RVA = "0x24A4300", Offset = "0x24A4300", VA = "0x7BBCCA4300")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137134", Offset = "0x1137134")]
			set
			{
			}
		}

		// Token: 0x0400169A RID: 5786
		[Token(Token = "0x400169A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102DF4", Offset = "0x1102DF4")]
		private uint <txn_type>k__BackingField;

		// Token: 0x0400169B RID: 5787
		[Token(Token = "0x400169B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102E04", Offset = "0x1102E04")]
		private uint <rebate_card_id>k__BackingField;

		// Token: 0x0400169C RID: 5788
		[Token(Token = "0x400169C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102E14", Offset = "0x1102E14")]
		private int <point_amount>k__BackingField;

		// Token: 0x0400169D RID: 5789
		[Token(Token = "0x400169D")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102E24", Offset = "0x1102E24")]
		private uint <channel_id>k__BackingField;

		// Token: 0x0400169E RID: 5790
		[Token(Token = "0x400169E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102E34", Offset = "0x1102E34")]
		private string <channel_name>k__BackingField;

		// Token: 0x0400169F RID: 5791
		[Token(Token = "0x400169F")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102E44", Offset = "0x1102E44")]
		private string <currency>k__BackingField;

		// Token: 0x040016A0 RID: 5792
		[Token(Token = "0x40016A0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102E54", Offset = "0x1102E54")]
		private float <currency_amount>k__BackingField;
	}
}
