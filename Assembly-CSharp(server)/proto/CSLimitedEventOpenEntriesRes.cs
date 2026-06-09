using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200094F RID: 2383
	[Token(Token = "0x200094F")]
	[ProtoContract]
	public class CSLimitedEventOpenEntriesRes
	{
		// Token: 0x0600265D RID: 9821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265D")]
		[Address(RVA = "0x21B6724", Offset = "0x21B6724", VA = "0x7BBC9B6724")]
		public CSLimitedEventOpenEntriesRes()
		{
		}

		// Token: 0x04002BC2 RID: 11202
		[Token(Token = "0x4002BC2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119230", Offset = "0x1119230")]
		public List<BigEventEntryDesc> events;
	}
}
