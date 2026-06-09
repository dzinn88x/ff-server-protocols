using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B3C RID: 2876
	[Token(Token = "0x2000B3C")]
	[ProtoContract]
	public class RateAppSwitchDesc
	{
		// Token: 0x06002844 RID: 10308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002844")]
		[Address(RVA = "0x249FBA8", Offset = "0x249FBA8", VA = "0x7BBCC9FBA8")]
		public RateAppSwitchDesc()
		{
		}

		// Token: 0x0400369A RID: 13978
		[Token(Token = "0x400369A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D03C", Offset = "0x112D03C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112D03C", Offset = "0x112D03C")]
		public string region;

		// Token: 0x0400369B RID: 13979
		[Token(Token = "0x400369B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D08C", Offset = "0x112D08C")]
		public bool ios_open;

		// Token: 0x0400369C RID: 13980
		[Token(Token = "0x400369C")]
		[FieldOffset(Offset = "0x19")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D0A0", Offset = "0x112D0A0")]
		public bool gp_open;

		// Token: 0x0400369D RID: 13981
		[Token(Token = "0x400369D")]
		[FieldOffset(Offset = "0x1A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D0B4", Offset = "0x112D0B4")]
		public bool huawei_open;

		// Token: 0x0400369E RID: 13982
		[Token(Token = "0x400369E")]
		[FieldOffset(Offset = "0x1B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D0C8", Offset = "0x112D0C8")]
		public bool xiaomi_open;
	}
}
