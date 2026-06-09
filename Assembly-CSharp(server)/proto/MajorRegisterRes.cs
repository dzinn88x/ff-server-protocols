using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008A2 RID: 2210
	[Token(Token = "0x20008A2")]
	[ProtoContract]
	public class MajorRegisterRes
	{
		// Token: 0x060025B0 RID: 9648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B0")]
		[Address(RVA = "0x21BC3EC", Offset = "0x21BC3EC", VA = "0x7BBC9BC3EC")]
		public MajorRegisterRes()
		{
		}

		// Token: 0x0400298E RID: 10638
		[Token(Token = "0x400298E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11158EC", Offset = "0x11158EC")]
		public ulong account_id;
	}
}
