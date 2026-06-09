using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ACF RID: 2767
	[Token(Token = "0x2000ACF")]
	[ProtoContract]
	public class PVECardGeneralDesc
	{
		// Token: 0x060027D7 RID: 10199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D7")]
		[Address(RVA = "0x249EE24", Offset = "0x249EE24", VA = "0x7BBCC9EE24")]
		public PVECardGeneralDesc()
		{
		}

		// Token: 0x040033FF RID: 13311
		[Token(Token = "0x40033FF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127934", Offset = "0x1127934")]
		public uint var_name;

		// Token: 0x04003400 RID: 13312
		[Token(Token = "0x4003400")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127948", Offset = "0x1127948")]
		public uint var_value;
	}
}
