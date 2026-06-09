using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004C3 RID: 1219
	[Token(Token = "0x20004C3")]
	[ProtoContract]
	public class RampagePointsUpdateNtf
	{
		// Token: 0x06001EBD RID: 7869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBD")]
		[Address(RVA = "0x24A5A4C", Offset = "0x24A5A4C", VA = "0x7BBCCA5A4C")]
		public RampagePointsUpdateNtf()
		{
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x0000D248 File Offset: 0x0000B448
		// (set) Token: 0x06001EBF RID: 7871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156BC8", Offset = "0x1156BC8")]
		public ulong account_id
		{
			[Token(Token = "0x6001EBE")]
			[Address(RVA = "0x24A5A54", Offset = "0x24A5A54", VA = "0x7BBCCA5A54")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137184", Offset = "0x1137184")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001EBF")]
			[Address(RVA = "0x24A5A5C", Offset = "0x24A5A5C", VA = "0x7BBCCA5A5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137194", Offset = "0x1137194")]
			set
			{
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x0000D260 File Offset: 0x0000B460
		// (set) Token: 0x06001EC1 RID: 7873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156BDC", Offset = "0x1156BDC")]
		public ulong rampage_points
		{
			[Token(Token = "0x6001EC0")]
			[Address(RVA = "0x24A5A64", Offset = "0x24A5A64", VA = "0x7BBCCA5A64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11371A4", Offset = "0x11371A4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001EC1")]
			[Address(RVA = "0x24A5A6C", Offset = "0x24A5A6C", VA = "0x7BBCCA5A6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11371B4", Offset = "0x11371B4")]
			set
			{
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x0000D278 File Offset: 0x0000B478
		// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156BF0", Offset = "0x1156BF0")]
		public uint rampage_rank
		{
			[Token(Token = "0x6001EC2")]
			[Address(RVA = "0x24A5A74", Offset = "0x24A5A74", VA = "0x7BBCCA5A74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11371C4", Offset = "0x11371C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001EC3")]
			[Address(RVA = "0x24A5A7C", Offset = "0x24A5A7C", VA = "0x7BBCCA5A7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11371D4", Offset = "0x11371D4")]
			set
			{
			}
		}

		// Token: 0x040016AC RID: 5804
		[Token(Token = "0x40016AC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102E84", Offset = "0x1102E84")]
		private ulong <account_id>k__BackingField;

		// Token: 0x040016AD RID: 5805
		[Token(Token = "0x40016AD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102E94", Offset = "0x1102E94")]
		private ulong <rampage_points>k__BackingField;

		// Token: 0x040016AE RID: 5806
		[Token(Token = "0x40016AE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102EA4", Offset = "0x1102EA4")]
		private uint <rampage_rank>k__BackingField;
	}
}
