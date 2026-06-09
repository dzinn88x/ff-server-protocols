using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006D8 RID: 1752
	[Token(Token = "0x20006D8")]
	[ProtoContract]
	public class AccusationCount
	{
		// Token: 0x060023E6 RID: 9190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E6")]
		[Address(RVA = "0x21AE85C", Offset = "0x21AE85C", VA = "0x7BBC9AE85C")]
		public AccusationCount()
		{
		}

		// Token: 0x04002281 RID: 8833
		[Token(Token = "0x4002281")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109484", Offset = "0x1109484")]
		public ulong account_id;

		// Token: 0x04002282 RID: 8834
		[Token(Token = "0x4002282")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109498", Offset = "0x1109498")]
		public uint accused_count;

		// Token: 0x04002283 RID: 8835
		[Token(Token = "0x4002283")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11094AC", Offset = "0x11094AC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11094AC", Offset = "0x11094AC")]
		public string happen_time;
	}
}
