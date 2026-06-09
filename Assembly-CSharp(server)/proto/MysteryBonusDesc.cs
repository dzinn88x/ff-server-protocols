using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009E0 RID: 2528
	[Token(Token = "0x20009E0")]
	[ProtoContract]
	public class MysteryBonusDesc
	{
		// Token: 0x060026EA RID: 9962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026EA")]
		[Address(RVA = "0x249E5A4", Offset = "0x249E5A4", VA = "0x7BBCC9E5A4")]
		public MysteryBonusDesc()
		{
		}

		// Token: 0x04002DA6 RID: 11686
		[Token(Token = "0x4002DA6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BA08", Offset = "0x111BA08")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111BA08", Offset = "0x111BA08")]
		public string region;

		// Token: 0x04002DA7 RID: 11687
		[Token(Token = "0x4002DA7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BA58", Offset = "0x111BA58")]
		public uint paid_level;

		// Token: 0x04002DA8 RID: 11688
		[Token(Token = "0x4002DA8")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BA6C", Offset = "0x111BA6C")]
		public uint bonus_max;

		// Token: 0x04002DA9 RID: 11689
		[Token(Token = "0x4002DA9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BA80", Offset = "0x111BA80")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111BA80", Offset = "0x111BA80")]
		public string start_time;

		// Token: 0x04002DAA RID: 11690
		[Token(Token = "0x4002DAA")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111BAD0", Offset = "0x111BAD0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BAD0", Offset = "0x111BAD0")]
		public string end_time;

		// Token: 0x04002DAB RID: 11691
		[Token(Token = "0x4002DAB")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BB20", Offset = "0x111BB20")]
		public uint start_time_stamp;

		// Token: 0x04002DAC RID: 11692
		[Token(Token = "0x4002DAC")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BB34", Offset = "0x111BB34")]
		public uint end_time_stamp;

		// Token: 0x04002DAD RID: 11693
		[Token(Token = "0x4002DAD")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BB48", Offset = "0x111BB48")]
		public uint pool_id;
	}
}
