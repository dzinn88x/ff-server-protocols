using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000998 RID: 2456
	[Token(Token = "0x2000998")]
	[ProtoContract]
	public class CSSupercarChangeCarRes
	{
		// Token: 0x060026A6 RID: 9894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A6")]
		[Address(RVA = "0x21B7728", Offset = "0x21B7728", VA = "0x7BBC9B7728")]
		public CSSupercarChangeCarRes()
		{
		}

		// Token: 0x04002C5F RID: 11359
		[Token(Token = "0x4002C5F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A040", Offset = "0x111A040")]
		public uint drive_sum;

		// Token: 0x04002C60 RID: 11360
		[Token(Token = "0x4002C60")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A054", Offset = "0x111A054")]
		public long speed_change_time;
	}
}
