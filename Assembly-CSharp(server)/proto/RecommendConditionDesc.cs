using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B3F RID: 2879
	[Token(Token = "0x2000B3F")]
	[ProtoContract]
	public class RecommendConditionDesc
	{
		// Token: 0x06002847 RID: 10311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002847")]
		[Address(RVA = "0x249FCF4", Offset = "0x249FCF4", VA = "0x7BBCC9FCF4")]
		public RecommendConditionDesc()
		{
		}

		// Token: 0x040036A6 RID: 13990
		[Token(Token = "0x40036A6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D21C", Offset = "0x112D21C")]
		public uint type;

		// Token: 0x040036A7 RID: 13991
		[Token(Token = "0x40036A7")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D230", Offset = "0x112D230")]
		public uint default_weight;

		// Token: 0x040036A8 RID: 13992
		[Token(Token = "0x40036A8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D244", Offset = "0x112D244")]
		public uint algo_weight;

		// Token: 0x040036A9 RID: 13993
		[Token(Token = "0x40036A9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D258", Offset = "0x112D258")]
		public List<RecommendAlgo> algos;
	}
}
