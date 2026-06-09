using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000739 RID: 1849
	[Token(Token = "0x2000739")]
	[ProtoContract]
	public class CSGetAllCupConfigReq
	{
		// Token: 0x06002446 RID: 9286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002446")]
		[Address(RVA = "0x21B1D68", Offset = "0x21B1D68", VA = "0x7BBC9B1D68")]
		public CSGetAllCupConfigReq()
		{
		}

		// Token: 0x0400249A RID: 9370
		[Token(Token = "0x400249A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C8C8", Offset = "0x110C8C8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110C8C8", Offset = "0x110C8C8")]
		public string language;
	}
}
