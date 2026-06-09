using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AFE RID: 2814
	[Token(Token = "0x2000AFE")]
	[ProtoContract]
	public class GracePeriodDesc
	{
		// Token: 0x06002806 RID: 10246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002806")]
		[Address(RVA = "0x21BB100", Offset = "0x21BB100", VA = "0x7BBC9BB100")]
		public GracePeriodDesc()
		{
		}

		// Token: 0x04003513 RID: 13587
		[Token(Token = "0x4003513")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129CFC", Offset = "0x1129CFC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1129CFC", Offset = "0x1129CFC")]
		public string region;

		// Token: 0x04003514 RID: 13588
		[Token(Token = "0x4003514")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129D4C", Offset = "0x1129D4C")]
		public uint max_abuse;
	}
}
