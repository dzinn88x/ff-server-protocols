using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B14 RID: 2836
	[Token(Token = "0x2000B14")]
	[ProtoContract]
	public class RampageRankDesc
	{
		// Token: 0x0600281C RID: 10268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281C")]
		[Address(RVA = "0x249F7D8", Offset = "0x249F7D8", VA = "0x7BBCC9F7D8")]
		public RampageRankDesc()
		{
		}

		// Token: 0x040035CB RID: 13771
		[Token(Token = "0x40035CB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B8CC", Offset = "0x112B8CC")]
		public uint rank;

		// Token: 0x040035CC RID: 13772
		[Token(Token = "0x40035CC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B8E0", Offset = "0x112B8E0")]
		public ulong points;

		// Token: 0x040035CD RID: 13773
		[Token(Token = "0x40035CD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B8F4", Offset = "0x112B8F4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B8F4", Offset = "0x112B8F4")]
		public string rank_desc;
	}
}
