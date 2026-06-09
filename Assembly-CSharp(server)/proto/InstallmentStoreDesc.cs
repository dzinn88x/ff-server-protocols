using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AAB RID: 2731
	[Token(Token = "0x2000AAB")]
	[ProtoContract]
	public class InstallmentStoreDesc
	{
		// Token: 0x060027B5 RID: 10165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B5")]
		[Address(RVA = "0x21BB4E0", Offset = "0x21BB4E0", VA = "0x7BBC9BB4E0")]
		public InstallmentStoreDesc()
		{
		}

		// Token: 0x04003344 RID: 13124
		[Token(Token = "0x4003344")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11264D0", Offset = "0x11264D0")]
		public uint sort_id;

		// Token: 0x04003345 RID: 13125
		[Token(Token = "0x4003345")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11264E4", Offset = "0x11264E4")]
		public uint item_id;

		// Token: 0x04003346 RID: 13126
		[Token(Token = "0x4003346")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11264F8", Offset = "0x11264F8")]
		public long added_time;

		// Token: 0x04003347 RID: 13127
		[Token(Token = "0x4003347")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112650C", Offset = "0x112650C")]
		public long expire_time;

		// Token: 0x04003348 RID: 13128
		[Token(Token = "0x4003348")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126520", Offset = "0x1126520")]
		public uint gems_price;

		// Token: 0x04003349 RID: 13129
		[Token(Token = "0x4003349")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126534", Offset = "0x1126534")]
		public uint deposit_price;

		// Token: 0x0400334A RID: 13130
		[Token(Token = "0x400334A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126548", Offset = "0x1126548")]
		public EInventory.InstallmentType installment_type;

		// Token: 0x0400334B RID: 13131
		[Token(Token = "0x400334B")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112655C", Offset = "0x112655C")]
		public uint installment_term;

		// Token: 0x0400334C RID: 13132
		[Token(Token = "0x400334C")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126570", Offset = "0x1126570")]
		public uint promp_day;

		// Token: 0x0400334D RID: 13133
		[Token(Token = "0x400334D")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126584", Offset = "0x1126584")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126584", Offset = "0x1126584")]
		public string language;

		// Token: 0x0400334E RID: 13134
		[Token(Token = "0x400334E")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11265D4", Offset = "0x11265D4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11265D4", Offset = "0x11265D4")]
		public string image_url;
	}
}
