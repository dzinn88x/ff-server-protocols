using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200068D RID: 1677
	[Token(Token = "0x200068D")]
	[ProtoContract]
	public class AccountAntiAddictionInfo
	{
		// Token: 0x060023CB RID: 9163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CB")]
		[Address(RVA = "0x21AE390", Offset = "0x21AE390", VA = "0x7BBC9AE390")]
		public AccountAntiAddictionInfo()
		{
		}

		// Token: 0x04002101 RID: 8449
		[Token(Token = "0x4002101")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108C00", Offset = "0x1108C00")]
		public EAntiAddiction.TotalTimeBanMode ban_mode;

		// Token: 0x04002102 RID: 8450
		[Token(Token = "0x4002102")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108C14", Offset = "0x1108C14")]
		public uint unban_time;
	}
}
