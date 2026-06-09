using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007EA RID: 2026
	[Token(Token = "0x20007EA")]
	[ProtoContract]
	public class CSExtendClanScaleRes
	{
		// Token: 0x060024F9 RID: 9465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F9")]
		[Address(RVA = "0x21B1290", Offset = "0x21B1290", VA = "0x7BBC9B1290")]
		public CSExtendClanScaleRes()
		{
		}

		// Token: 0x0400268A RID: 9866
		[Token(Token = "0x400268A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110018", Offset = "0x1110018")]
		public ulong clan_id;

		// Token: 0x0400268B RID: 9867
		[Token(Token = "0x400268B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111002C", Offset = "0x111002C")]
		public uint capacity;

		// Token: 0x0400268C RID: 9868
		[Token(Token = "0x400268C")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110040", Offset = "0x1110040")]
		public uint extended_times;
	}
}
