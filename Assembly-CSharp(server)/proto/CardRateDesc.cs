using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AC2 RID: 2754
	[Token(Token = "0x2000AC2")]
	[ProtoContract]
	public class CardRateDesc
	{
		// Token: 0x060027CB RID: 10187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CB")]
		[Address(RVA = "0x21B7EA0", Offset = "0x21B7EA0", VA = "0x7BBC9B7EA0")]
		public CardRateDesc()
		{
		}

		// Token: 0x040033C1 RID: 13249
		[Token(Token = "0x40033C1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127434", Offset = "0x1127434")]
		public uint daily_times;

		// Token: 0x040033C2 RID: 13250
		[Token(Token = "0x40033C2")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127448", Offset = "0x1127448")]
		public uint initial_rate;

		// Token: 0x040033C3 RID: 13251
		[Token(Token = "0x40033C3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112745C", Offset = "0x112745C")]
		public uint increase_rate;

		// Token: 0x040033C4 RID: 13252
		[Token(Token = "0x40033C4")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127470", Offset = "0x1127470")]
		public uint daily_time_max;
	}
}
