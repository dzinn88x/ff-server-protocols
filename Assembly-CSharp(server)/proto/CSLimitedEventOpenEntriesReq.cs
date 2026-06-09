using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200094D RID: 2381
	[Token(Token = "0x200094D")]
	[ProtoContract]
	public class CSLimitedEventOpenEntriesReq
	{
		// Token: 0x0600265B RID: 9819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265B")]
		[Address(RVA = "0x21B66C8", Offset = "0x21B66C8", VA = "0x7BBC9B66C8")]
		public CSLimitedEventOpenEntriesReq()
		{
		}

		// Token: 0x04002BBF RID: 11199
		[Token(Token = "0x4002BBF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119190", Offset = "0x1119190")]
		public ELimitedEvent.EventID event_id;

		// Token: 0x04002BC0 RID: 11200
		[Token(Token = "0x4002BC0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11191A4", Offset = "0x11191A4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11191A4", Offset = "0x11191A4")]
		public string lock_region;
	}
}
