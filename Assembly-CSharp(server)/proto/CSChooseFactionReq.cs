using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200095D RID: 2397
	[Token(Token = "0x200095D")]
	[ProtoContract]
	public class CSChooseFactionReq
	{
		// Token: 0x0600266B RID: 9835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266B")]
		[Address(RVA = "0x21B0660", Offset = "0x21B0660", VA = "0x7BBC9B0660")]
		public CSChooseFactionReq()
		{
		}

		// Token: 0x04002BDF RID: 11231
		[Token(Token = "0x4002BDF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119474", Offset = "0x1119474")]
		public ELimitedEvent.RampageFaction faction;
	}
}
