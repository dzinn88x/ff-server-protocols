using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200099E RID: 2462
	[Token(Token = "0x200099E")]
	[ProtoContract]
	public class CSBooyahChessMoveReq
	{
		// Token: 0x060026AC RID: 9900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AC")]
		[Address(RVA = "0x21B04D4", Offset = "0x21B04D4", VA = "0x7BBC9B04D4")]
		public CSBooyahChessMoveReq()
		{
		}

		// Token: 0x04002C78 RID: 11384
		[Token(Token = "0x4002C78")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A234", Offset = "0x111A234")]
		public uint target_index;
	}
}
