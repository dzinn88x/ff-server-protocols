using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000713 RID: 1811
	[Token(Token = "0x2000713")]
	[ProtoContract]
	public class CSSetShowRankRes
	{
		// Token: 0x06002420 RID: 9248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002420")]
		[Address(RVA = "0x21B767C", Offset = "0x21B767C", VA = "0x7BBC9B767C")]
		public CSSetShowRankRes()
		{
		}

		// Token: 0x0400242B RID: 9259
		[Token(Token = "0x400242B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BE3C", Offset = "0x110BE3C")]
		public bool show_rank;
	}
}
