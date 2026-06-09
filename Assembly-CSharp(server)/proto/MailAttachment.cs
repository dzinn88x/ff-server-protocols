using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005EB RID: 1515
	[Token(Token = "0x20005EB")]
	[ProtoContract]
	public class MailAttachment
	{
		// Token: 0x0600236B RID: 9067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236B")]
		[Address(RVA = "0x21BC1BC", Offset = "0x21BC1BC", VA = "0x7BBC9BC1BC")]
		public MailAttachment()
		{
		}

		// Token: 0x04001E44 RID: 7748
		[Token(Token = "0x4001E44")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106554", Offset = "0x1106554")]
		public AwardData rewards;
	}
}
