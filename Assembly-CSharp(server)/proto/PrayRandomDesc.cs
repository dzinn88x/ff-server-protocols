using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A99 RID: 2713
	[Token(Token = "0x2000A99")]
	[ProtoContract]
	public class PrayRandomDesc
	{
		// Token: 0x060027A3 RID: 10147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A3")]
		[Address(RVA = "0x249F6E4", Offset = "0x249F6E4", VA = "0x7BBCC9F6E4")]
		public PrayRandomDesc()
		{
		}

		// Token: 0x0400328B RID: 12939
		[Token(Token = "0x400328B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124DC4", Offset = "0x1124DC4")]
		public uint chest_id;

		// Token: 0x0400328C RID: 12940
		[Token(Token = "0x400328C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124DD8", Offset = "0x1124DD8")]
		public uint chest_sub_id;

		// Token: 0x0400328D RID: 12941
		[Token(Token = "0x400328D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124DEC", Offset = "0x1124DEC")]
		public uint pray_point;

		// Token: 0x0400328E RID: 12942
		[Token(Token = "0x400328E")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124E00", Offset = "0x1124E00")]
		public uint rate;
	}
}
