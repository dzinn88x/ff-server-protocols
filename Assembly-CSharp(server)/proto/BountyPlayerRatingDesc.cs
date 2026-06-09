using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B12 RID: 2834
	[Token(Token = "0x2000B12")]
	[ProtoContract]
	public class BountyPlayerRatingDesc
	{
		// Token: 0x0600281A RID: 10266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281A")]
		[Address(RVA = "0x21AFE24", Offset = "0x21AFE24", VA = "0x7BBC9AFE24")]
		public BountyPlayerRatingDesc()
		{
		}

		// Token: 0x040035AC RID: 13740
		[Token(Token = "0x40035AC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B174", Offset = "0x112B174")]
		public uint type_id;

		// Token: 0x040035AD RID: 13741
		[Token(Token = "0x40035AD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B188", Offset = "0x112B188")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B188", Offset = "0x112B188")]
		public string failed_title_key;

		// Token: 0x040035AE RID: 13742
		[Token(Token = "0x40035AE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B1D8", Offset = "0x112B1D8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B1D8", Offset = "0x112B1D8")]
		public string failed_comment_key;

		// Token: 0x040035AF RID: 13743
		[Token(Token = "0x40035AF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B228", Offset = "0x112B228")]
		public uint threshold_of_a;

		// Token: 0x040035B0 RID: 13744
		[Token(Token = "0x40035B0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B23C", Offset = "0x112B23C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B23C", Offset = "0x112B23C")]
		public string a_title_key;

		// Token: 0x040035B1 RID: 13745
		[Token(Token = "0x40035B1")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B28C", Offset = "0x112B28C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B28C", Offset = "0x112B28C")]
		public string a_comment_key;

		// Token: 0x040035B2 RID: 13746
		[Token(Token = "0x40035B2")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B2DC", Offset = "0x112B2DC")]
		public uint threshold_of_s;

		// Token: 0x040035B3 RID: 13747
		[Token(Token = "0x40035B3")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B2F0", Offset = "0x112B2F0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B2F0", Offset = "0x112B2F0")]
		public string s_title_key;

		// Token: 0x040035B4 RID: 13748
		[Token(Token = "0x40035B4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B340", Offset = "0x112B340")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B340", Offset = "0x112B340")]
		public string s_comment_key;

		// Token: 0x040035B5 RID: 13749
		[Token(Token = "0x40035B5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B390", Offset = "0x112B390")]
		public uint threshold_of_ss;

		// Token: 0x040035B6 RID: 13750
		[Token(Token = "0x40035B6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B3A4", Offset = "0x112B3A4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B3A4", Offset = "0x112B3A4")]
		public string ss_title_key;

		// Token: 0x040035B7 RID: 13751
		[Token(Token = "0x40035B7")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B3F4", Offset = "0x112B3F4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B3F4", Offset = "0x112B3F4")]
		public string ss_comment_key;

		// Token: 0x040035B8 RID: 13752
		[Token(Token = "0x40035B8")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B444", Offset = "0x112B444")]
		public uint threshold_of_sss;

		// Token: 0x040035B9 RID: 13753
		[Token(Token = "0x40035B9")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B458", Offset = "0x112B458")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B458", Offset = "0x112B458")]
		public string sss_title_key;

		// Token: 0x040035BA RID: 13754
		[Token(Token = "0x40035BA")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B4A8", Offset = "0x112B4A8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B4A8", Offset = "0x112B4A8")]
		public string sss_comment_key;
	}
}
