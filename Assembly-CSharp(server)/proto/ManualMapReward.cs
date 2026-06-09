using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008F1 RID: 2289
	[Token(Token = "0x20008F1")]
	[ProtoContract]
	public class ManualMapReward
	{
		// Token: 0x060025FF RID: 9727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025FF")]
		[Address(RVA = "0x21BC3FC", Offset = "0x21BC3FC", VA = "0x7BBC9BC3FC")]
		public ManualMapReward()
		{
		}

		// Token: 0x04002A9C RID: 10908
		[Token(Token = "0x4002A9C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111750C", Offset = "0x111750C")]
		public uint map_id;

		// Token: 0x04002A9D RID: 10909
		[Token(Token = "0x4002A9D")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117520", Offset = "0x1117520")]
		public EManual.State state;
	}
}
