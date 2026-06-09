using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009C3 RID: 2499
	[Token(Token = "0x20009C3")]
	[ProtoContract]
	public class CSGetFFWSCurProcessRes
	{
		// Token: 0x060026D1 RID: 9937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D1")]
		[Address(RVA = "0x21B3550", Offset = "0x21B3550", VA = "0x7BBC9B3550")]
		public CSGetFFWSCurProcessRes()
		{
		}

		// Token: 0x04002CC6 RID: 11462
		[Token(Token = "0x4002CC6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AA7C", Offset = "0x111AA7C")]
		public ulong cur_process;
	}
}
