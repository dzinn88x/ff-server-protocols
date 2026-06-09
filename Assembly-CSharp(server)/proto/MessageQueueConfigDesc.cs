using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ABE RID: 2750
	[Token(Token = "0x2000ABE")]
	[ProtoContract]
	public class MessageQueueConfigDesc
	{
		// Token: 0x060027C8 RID: 10184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C8")]
		[Address(RVA = "0x21BCB70", Offset = "0x21BCB70", VA = "0x7BBC9BCB70")]
		public MessageQueueConfigDesc()
		{
		}

		// Token: 0x040033B2 RID: 13234
		[Token(Token = "0x40033B2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127344", Offset = "0x1127344")]
		public bool is_open;

		// Token: 0x040033B3 RID: 13235
		[Token(Token = "0x40033B3")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127358", Offset = "0x1127358")]
		public uint consumer_num_per_channel;

		// Token: 0x040033B4 RID: 13236
		[Token(Token = "0x40033B4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112736C", Offset = "0x112736C")]
		public uint handler_num_per_consumer;

		// Token: 0x040033B5 RID: 13237
		[Token(Token = "0x40033B5")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127380", Offset = "0x1127380")]
		public uint max_in_fight_per_consumer;
	}
}
