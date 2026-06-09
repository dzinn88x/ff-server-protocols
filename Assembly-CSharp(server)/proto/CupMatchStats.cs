using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000741 RID: 1857
	[Token(Token = "0x2000741")]
	[ProtoContract]
	public class CupMatchStats
	{
		// Token: 0x0600244E RID: 9294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244E")]
		[Address(RVA = "0x21B91DC", Offset = "0x21B91DC", VA = "0x7BBC9B91DC")]
		public CupMatchStats()
		{
		}

		// Token: 0x040024B6 RID: 9398
		[Token(Token = "0x40024B6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CB70", Offset = "0x110CB70")]
		public ulong team_id;

		// Token: 0x040024B7 RID: 9399
		[Token(Token = "0x40024B7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CB84", Offset = "0x110CB84")]
		public ulong opponent_id;

		// Token: 0x040024B8 RID: 9400
		[Token(Token = "0x40024B8")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CB98", Offset = "0x110CB98")]
		public bool win;

		// Token: 0x040024B9 RID: 9401
		[Token(Token = "0x40024B9")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CBAC", Offset = "0x110CBAC")]
		public uint kills;

		// Token: 0x040024BA RID: 9402
		[Token(Token = "0x40024BA")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CBC0", Offset = "0x110CBC0")]
		public uint damage;

		// Token: 0x040024BB RID: 9403
		[Token(Token = "0x40024BB")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CBD4", Offset = "0x110CBD4")]
		public uint moving_distance;

		// Token: 0x040024BC RID: 9404
		[Token(Token = "0x40024BC")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CBE8", Offset = "0x110CBE8")]
		public uint revival_count;

		// Token: 0x040024BD RID: 9405
		[Token(Token = "0x40024BD")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CBFC", Offset = "0x110CBFC")]
		public uint headshot_kills;

		// Token: 0x040024BE RID: 9406
		[Token(Token = "0x40024BE")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CC10", Offset = "0x110CC10")]
		public uint knockdown_count;

		// Token: 0x040024BF RID: 9407
		[Token(Token = "0x40024BF")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CC24", Offset = "0x110CC24")]
		public uint direct_kills;
	}
}
