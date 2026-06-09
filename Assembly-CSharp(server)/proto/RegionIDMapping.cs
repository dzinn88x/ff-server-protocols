using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000665 RID: 1637
	[Token(Token = "0x2000665")]
	[ProtoContract]
	public class RegionIDMapping
	{
		// Token: 0x060023B8 RID: 9144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B8")]
		[Address(RVA = "0x249FE28", Offset = "0x249FE28", VA = "0x7BBCC9FE28")]
		public RegionIDMapping()
		{
		}

		// Token: 0x04002055 RID: 8277
		[Token(Token = "0x4002055")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11086B0", Offset = "0x11086B0")]
		public uint id;

		// Token: 0x04002056 RID: 8278
		[Token(Token = "0x4002056")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11086C4", Offset = "0x11086C4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11086C4", Offset = "0x11086C4")]
		public string region;
	}
}
