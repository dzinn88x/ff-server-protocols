using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008E9 RID: 2281
	[Token(Token = "0x20008E9")]
	[ProtoContract]
	public class CSGetManualCollectInfoRes
	{
		// Token: 0x060025F7 RID: 9719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F7")]
		[Address(RVA = "0x21B4AB4", Offset = "0x21B4AB4", VA = "0x7BBC9B4AB4")]
		public CSGetManualCollectInfoRes()
		{
		}

		// Token: 0x04002A93 RID: 10899
		[Token(Token = "0x4002A93")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117430", Offset = "0x1117430")]
		public uint[] manual_event_ids;
	}
}
