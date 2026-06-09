using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200093C RID: 2364
	[Token(Token = "0x200093C")]
	[ProtoContract]
	public class CSLinkageActivityTriggerReq
	{
		// Token: 0x0600264A RID: 9802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264A")]
		[Address(RVA = "0x21B67A8", Offset = "0x21B67A8", VA = "0x7BBC9B67A8")]
		public CSLinkageActivityTriggerReq()
		{
		}

		// Token: 0x04002B9F RID: 11167
		[Token(Token = "0x4002B9F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118E34", Offset = "0x1118E34")]
		public uint event_type;
	}
}
