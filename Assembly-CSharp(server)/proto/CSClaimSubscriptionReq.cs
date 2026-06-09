using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000941 RID: 2369
	[Token(Token = "0x2000941")]
	[ProtoContract]
	public class CSClaimSubscriptionReq
	{
		// Token: 0x0600264F RID: 9807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264F")]
		[Address(RVA = "0x21B092C", Offset = "0x21B092C", VA = "0x7BBC9B092C")]
		public CSClaimSubscriptionReq()
		{
		}

		// Token: 0x04002BA6 RID: 11174
		[Token(Token = "0x4002BA6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118EFC", Offset = "0x1118EFC")]
		public uint store_id;
	}
}
