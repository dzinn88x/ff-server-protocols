using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B40 RID: 2880
	[Token(Token = "0x2000B40")]
	[ProtoContract]
	public class RecommendSwitch
	{
		// Token: 0x06002848 RID: 10312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002848")]
		[Address(RVA = "0x249FD68", Offset = "0x249FD68", VA = "0x7BBCC9FD68")]
		public RecommendSwitch()
		{
		}

		// Token: 0x040036AA RID: 13994
		[Token(Token = "0x40036AA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D26C", Offset = "0x112D26C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112D26C", Offset = "0x112D26C")]
		public string region;

		// Token: 0x040036AB RID: 13995
		[Token(Token = "0x40036AB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D2BC", Offset = "0x112D2BC")]
		public bool is_open_recommend;
	}
}
