using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000989 RID: 2441
	[Token(Token = "0x2000989")]
	[ProtoContract]
	public class CSOpenGoliathAFKGroupActivityRes
	{
		// Token: 0x06002697 RID: 9879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002697")]
		[Address(RVA = "0x21B6D00", Offset = "0x21B6D00", VA = "0x7BBC9B6D00")]
		public CSOpenGoliathAFKGroupActivityRes()
		{
		}

		// Token: 0x04002C39 RID: 11321
		[Token(Token = "0x4002C39")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119CD0", Offset = "0x1119CD0")]
		public uint activity_id;
	}
}
