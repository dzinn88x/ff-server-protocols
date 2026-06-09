using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004BD RID: 1213
	[Token(Token = "0x20004BD")]
	[ProtoContract]
	public class InventoryTopupNtf
	{
		// Token: 0x06001E9F RID: 7839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E9F")]
		[Address(RVA = "0x24A4308", Offset = "0x24A4308", VA = "0x7BBCCA4308")]
		public InventoryTopupNtf()
		{
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x0000D170 File Offset: 0x0000B370
		// (set) Token: 0x06001EA1 RID: 7841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000460")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11569D4", Offset = "0x11569D4")]
		public uint txn_type
		{
			[Token(Token = "0x6001EA0")]
			[Address(RVA = "0x24A436C", Offset = "0x24A436C", VA = "0x7BBCCA436C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136FE4", Offset = "0x1136FE4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001EA1")]
			[Address(RVA = "0x24A4374", Offset = "0x24A4374", VA = "0x7BBCCA4374")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136FF4", Offset = "0x1136FF4")]
			set
			{
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x0000D188 File Offset: 0x0000B388
		// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000461")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11569E8", Offset = "0x11569E8")]
		public uint recharge_points
		{
			[Token(Token = "0x6001EA2")]
			[Address(RVA = "0x24A437C", Offset = "0x24A437C", VA = "0x7BBCCA437C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137004", Offset = "0x1137004")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001EA3")]
			[Address(RVA = "0x24A4384", Offset = "0x24A4384", VA = "0x7BBCCA4384")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137014", Offset = "0x1137014")]
			set
			{
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000462")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11569FC", Offset = "0x11569FC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11569FC", Offset = "0x11569FC")]
		public string currency
		{
			[Token(Token = "0x6001EA4")]
			[Address(RVA = "0x24A438C", Offset = "0x24A438C", VA = "0x7BBCCA438C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137024", Offset = "0x1137024")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EA5")]
			[Address(RVA = "0x24A4364", Offset = "0x24A4364", VA = "0x7BBCCA4364")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137034", Offset = "0x1137034")]
			set
			{
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
		// (set) Token: 0x06001EA7 RID: 7847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000463")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156A4C", Offset = "0x1156A4C")]
		public float currency_amount
		{
			[Token(Token = "0x6001EA6")]
			[Address(RVA = "0x24A4394", Offset = "0x24A4394", VA = "0x7BBCCA4394")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137044", Offset = "0x1137044")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001EA7")]
			[Address(RVA = "0x24A439C", Offset = "0x24A439C", VA = "0x7BBCCA439C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137054", Offset = "0x1137054")]
			set
			{
			}
		}

		// Token: 0x04001696 RID: 5782
		[Token(Token = "0x4001696")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102DB4", Offset = "0x1102DB4")]
		private uint <txn_type>k__BackingField;

		// Token: 0x04001697 RID: 5783
		[Token(Token = "0x4001697")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102DC4", Offset = "0x1102DC4")]
		private uint <recharge_points>k__BackingField;

		// Token: 0x04001698 RID: 5784
		[Token(Token = "0x4001698")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102DD4", Offset = "0x1102DD4")]
		private string <currency>k__BackingField;

		// Token: 0x04001699 RID: 5785
		[Token(Token = "0x4001699")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102DE4", Offset = "0x1102DE4")]
		private float <currency_amount>k__BackingField;
	}
}
