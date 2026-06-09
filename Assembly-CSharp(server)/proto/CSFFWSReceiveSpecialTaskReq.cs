using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009C0 RID: 2496
	[Token(Token = "0x20009C0")]
	[ProtoContract]
	public class CSFFWSReceiveSpecialTaskReq
	{
		// Token: 0x060026CE RID: 9934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CE")]
		[Address(RVA = "0x21B12A8", Offset = "0x21B12A8", VA = "0x7BBC9B12A8")]
		public CSFFWSReceiveSpecialTaskReq()
		{
		}

		// Token: 0x04002CC2 RID: 11458
		[Token(Token = "0x4002CC2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A9F0", Offset = "0x111A9F0")]
		public uint index_id;

		// Token: 0x04002CC3 RID: 11459
		[Token(Token = "0x4002CC3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AA04", Offset = "0x111AA04")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111AA04", Offset = "0x111AA04")]
		public string language;
	}
}
