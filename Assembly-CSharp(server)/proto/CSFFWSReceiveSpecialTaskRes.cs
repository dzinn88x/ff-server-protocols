using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009C1 RID: 2497
	[Token(Token = "0x20009C1")]
	[ProtoContract]
	public class CSFFWSReceiveSpecialTaskRes
	{
		// Token: 0x060026CF RID: 9935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CF")]
		[Address(RVA = "0x21B1304", Offset = "0x21B1304", VA = "0x7BBC9B1304")]
		public CSFFWSReceiveSpecialTaskRes()
		{
		}

		// Token: 0x04002CC4 RID: 11460
		[Token(Token = "0x4002CC4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AA54", Offset = "0x111AA54")]
		public uint activity_id;
	}
}
