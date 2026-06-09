using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B2E RID: 2862
	[Token(Token = "0x2000B2E")]
	[ProtoContract]
	public class LightFeatureConfigDesc
	{
		// Token: 0x06002836 RID: 10294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002836")]
		[Address(RVA = "0x21BB9D8", Offset = "0x21BB9D8", VA = "0x7BBC9BB9D8")]
		public LightFeatureConfigDesc()
		{
		}

		// Token: 0x04003653 RID: 13907
		[Token(Token = "0x4003653")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C7A4", Offset = "0x112C7A4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112C7A4", Offset = "0x112C7A4")]
		public string region;

		// Token: 0x04003654 RID: 13908
		[Token(Token = "0x4003654")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C7F4", Offset = "0x112C7F4")]
		public bool enable;
	}
}
