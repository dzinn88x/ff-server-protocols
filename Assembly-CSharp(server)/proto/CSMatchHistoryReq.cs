using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006F3 RID: 1779
	[Token(Token = "0x20006F3")]
	[ProtoContract]
	public class CSMatchHistoryReq
	{
		// Token: 0x06002401 RID: 9217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002401")]
		[Address(RVA = "0x21B68F8", Offset = "0x21B68F8", VA = "0x7BBC9B68F8")]
		public CSMatchHistoryReq()
		{
		}

		// Token: 0x040022BB RID: 8891
		[Token(Token = "0x40022BB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109E5C", Offset = "0x1109E5C")]
		public ulong account_id;
	}
}
