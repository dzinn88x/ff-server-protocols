using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005E0 RID: 1504
	[Token(Token = "0x20005E0")]
	[ProtoContract]
	public class OpenIDReq
	{
		// Token: 0x06002360 RID: 9056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002360")]
		[Address(RVA = "0x249ECD8", Offset = "0x249ECD8", VA = "0x7BBCC9ECD8")]
		public OpenIDReq()
		{
		}

		// Token: 0x04001DCA RID: 7626
		[Token(Token = "0x4001DCA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105550", Offset = "0x1105550")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105550", Offset = "0x1105550")]
		public string open_id;
	}
}
