using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200093D RID: 2365
	[Token(Token = "0x200093D")]
	[ProtoContract]
	public class CSGetSubcribeStoreReq
	{
		// Token: 0x0600264B RID: 9803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264B")]
		[Address(RVA = "0x21B5D04", Offset = "0x21B5D04", VA = "0x7BBC9B5D04")]
		public CSGetSubcribeStoreReq()
		{
		}

		// Token: 0x04002BA0 RID: 11168
		[Token(Token = "0x4002BA0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118E48", Offset = "0x1118E48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1118E48", Offset = "0x1118E48")]
		public string language;
	}
}
