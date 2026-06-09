using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008CA RID: 2250
	[Token(Token = "0x20008CA")]
	[ProtoContract]
	public class CSGetMysteryExpressionRes
	{
		// Token: 0x060025D8 RID: 9688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D8")]
		[Address(RVA = "0x21B4DC4", Offset = "0x21B4DC4", VA = "0x7BBC9B4DC4")]
		public CSGetMysteryExpressionRes()
		{
		}

		// Token: 0x04002A35 RID: 10805
		[Token(Token = "0x4002A35")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116954", Offset = "0x1116954")]
		public MysteryShopExpressionDesc mystery_shop_expression;
	}
}
