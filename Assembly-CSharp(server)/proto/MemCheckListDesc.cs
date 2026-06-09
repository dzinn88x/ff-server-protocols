using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AEE RID: 2798
	[Token(Token = "0x2000AEE")]
	[ProtoContract]
	public class MemCheckListDesc
	{
		// Token: 0x060027F6 RID: 10230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F6")]
		[Address(RVA = "0x21BCA98", Offset = "0x21BCA98", VA = "0x7BBC9BCA98")]
		public MemCheckListDesc()
		{
		}

		// Token: 0x040034BB RID: 13499
		[Token(Token = "0x40034BB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11291BC", Offset = "0x11291BC")]
		public ulong account_id;

		// Token: 0x040034BC RID: 13500
		[Token(Token = "0x40034BC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11291D0", Offset = "0x11291D0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11291D0", Offset = "0x11291D0")]
		public string mem_addr;
	}
}
