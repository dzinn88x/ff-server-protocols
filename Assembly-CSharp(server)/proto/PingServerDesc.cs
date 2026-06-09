using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AD8 RID: 2776
	[Token(Token = "0x2000AD8")]
	[ProtoContract]
	public class PingServerDesc
	{
		// Token: 0x060027E0 RID: 10208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E0")]
		[Address(RVA = "0x249F32C", Offset = "0x249F32C", VA = "0x7BBCC9F32C")]
		public PingServerDesc()
		{
		}

		// Token: 0x04003423 RID: 13347
		[Token(Token = "0x4003423")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127D30", Offset = "0x1127D30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1127D30", Offset = "0x1127D30")]
		public string region;

		// Token: 0x04003424 RID: 13348
		[Token(Token = "0x4003424")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1127D80", Offset = "0x1127D80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127D80", Offset = "0x1127D80")]
		public string ip;

		// Token: 0x04003425 RID: 13349
		[Token(Token = "0x4003425")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1127DD0", Offset = "0x1127DD0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127DD0", Offset = "0x1127DD0")]
		public string start_time;

		// Token: 0x04003426 RID: 13350
		[Token(Token = "0x4003426")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127E20", Offset = "0x1127E20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1127E20", Offset = "0x1127E20")]
		public string end_time;

		// Token: 0x04003427 RID: 13351
		[Token(Token = "0x4003427")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127E70", Offset = "0x1127E70")]
		public float ping_random;

		// Token: 0x04003428 RID: 13352
		[Token(Token = "0x4003428")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127E84", Offset = "0x1127E84")]
		public bool is_traceroute;
	}
}
