using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009B6 RID: 2486
	[Token(Token = "0x20009B6")]
	[ProtoContract]
	public class CSBatchGetProfileReq
	{
		// Token: 0x060026C4 RID: 9924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C4")]
		[Address(RVA = "0x21B0450", Offset = "0x21B0450", VA = "0x7BBC9B0450")]
		public CSBatchGetProfileReq()
		{
		}

		// Token: 0x04002CAF RID: 11439
		[Token(Token = "0x4002CAF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A7AC", Offset = "0x111A7AC")]
		public ulong[] account_ids;
	}
}
