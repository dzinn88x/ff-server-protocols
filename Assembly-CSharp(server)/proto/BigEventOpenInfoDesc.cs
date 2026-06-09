using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B0C RID: 2828
	[Token(Token = "0x2000B0C")]
	[ProtoContract]
	public class BigEventOpenInfoDesc
	{
		// Token: 0x06002814 RID: 10260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002814")]
		[Address(RVA = "0x21AF8E0", Offset = "0x21AF8E0", VA = "0x7BBC9AF8E0")]
		public BigEventOpenInfoDesc()
		{
		}

		// Token: 0x04003568 RID: 13672
		[Token(Token = "0x4003568")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A828", Offset = "0x112A828")]
		public ELimitedEvent.EventID event_id;

		// Token: 0x04003569 RID: 13673
		[Token(Token = "0x4003569")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A83C", Offset = "0x112A83C")]
		public ELimitedEvent.EventState event_state;

		// Token: 0x0400356A RID: 13674
		[Token(Token = "0x400356A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112A850", Offset = "0x112A850")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A850", Offset = "0x112A850")]
		public string start_time;

		// Token: 0x0400356B RID: 13675
		[Token(Token = "0x400356B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A8A0", Offset = "0x112A8A0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112A8A0", Offset = "0x112A8A0")]
		public string end_time;

		// Token: 0x0400356C RID: 13676
		[Token(Token = "0x400356C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A8F0", Offset = "0x112A8F0")]
		public uint start_timestamp;

		// Token: 0x0400356D RID: 13677
		[Token(Token = "0x400356D")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A904", Offset = "0x112A904")]
		public uint end_timestamp;
	}
}
