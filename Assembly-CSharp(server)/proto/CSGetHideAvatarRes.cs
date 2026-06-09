using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200080C RID: 2060
	[Token(Token = "0x200080C")]
	[ProtoContract]
	public class CSGetHideAvatarRes
	{
		// Token: 0x0600251B RID: 9499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251B")]
		[Address(RVA = "0x21B41D0", Offset = "0x21B41D0", VA = "0x7BBC9B41D0")]
		public CSGetHideAvatarRes()
		{
		}

		// Token: 0x04002700 RID: 9984
		[Token(Token = "0x4002700")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110B80", Offset = "0x1110B80")]
		public uint[] avatar_id;
	}
}
