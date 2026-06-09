using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AEF RID: 2799
	[Token(Token = "0x2000AEF")]
	[ProtoContract]
	public class NewPlayerSevenDaysDesc
	{
		// Token: 0x060027F7 RID: 10231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F7")]
		[Address(RVA = "0x249EB8C", Offset = "0x249EB8C", VA = "0x7BBCC9EB8C")]
		public NewPlayerSevenDaysDesc()
		{
		}

		// Token: 0x040034BD RID: 13501
		[Token(Token = "0x40034BD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129220", Offset = "0x1129220")]
		public uint achievement_id;

		// Token: 0x040034BE RID: 13502
		[Token(Token = "0x40034BE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129234", Offset = "0x1129234")]
		public EActivity.PreConditionType pre_cdt_type1;

		// Token: 0x040034BF RID: 13503
		[Token(Token = "0x40034BF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129248", Offset = "0x1129248")]
		public uint[] pre_cdt_value1;

		// Token: 0x040034C0 RID: 13504
		[Token(Token = "0x40034C0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129284", Offset = "0x1129284")]
		public EActivity.PreConditionType pre_cdt_type2;

		// Token: 0x040034C1 RID: 13505
		[Token(Token = "0x40034C1")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129298", Offset = "0x1129298")]
		public uint[] pre_cdt_value2;

		// Token: 0x040034C2 RID: 13506
		[Token(Token = "0x40034C2")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11292D4", Offset = "0x11292D4")]
		public EActivity.PreConditionType pre_cdt_type3;

		// Token: 0x040034C3 RID: 13507
		[Token(Token = "0x40034C3")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11292E8", Offset = "0x11292E8")]
		public uint[] pre_cdt_value3;

		// Token: 0x040034C4 RID: 13508
		[Token(Token = "0x40034C4")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129324", Offset = "0x1129324")]
		public EActivity.PreConditionType pre_cdt_type4;

		// Token: 0x040034C5 RID: 13509
		[Token(Token = "0x40034C5")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129338", Offset = "0x1129338")]
		public uint[] pre_cdt_value4;

		// Token: 0x040034C6 RID: 13510
		[Token(Token = "0x40034C6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129374", Offset = "0x1129374")]
		public EActivity.PreConditionType pre_cdt_type5;

		// Token: 0x040034C7 RID: 13511
		[Token(Token = "0x40034C7")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129388", Offset = "0x1129388")]
		public uint[] pre_cdt_value5;

		// Token: 0x040034C8 RID: 13512
		[Token(Token = "0x40034C8")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11293C4", Offset = "0x11293C4")]
		public EActivity.ConditionType cdt_type;

		// Token: 0x040034C9 RID: 13513
		[Token(Token = "0x40034C9")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11293D8", Offset = "0x11293D8")]
		public uint cdt_value;

		// Token: 0x040034CA RID: 13514
		[Token(Token = "0x40034CA")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11293EC", Offset = "0x11293EC")]
		public List<AwardDesc> awards;

		// Token: 0x040034CB RID: 13515
		[Token(Token = "0x40034CB")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129400", Offset = "0x1129400")]
		public uint pre_cdt_switch;
	}
}
