using System;
using System.IO;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FB4 RID: 4020
	[Token(Token = "0x2000FB4")]
	internal class C2S_LongTimeNoSee_Req : UDPClientMessageBase
	{
		// Token: 0x06003A90 RID: 14992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A90")]
		[Address(RVA = "0x25E6CC8", Offset = "0x25E6CC8", VA = "0x7BBCDE6CC8", Slot = "6")]
		public override void Serialize(BinaryWriter writer)
		{
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A91")]
		[Address(RVA = "0x25E6CD4", Offset = "0x25E6CD4", VA = "0x7BBCDE6CD4")]
		public C2S_LongTimeNoSee_Req()
		{
		}

		// Token: 0x04004C12 RID: 19474
		[Token(Token = "0x4004C12")]
		[FieldOffset(Offset = "0x18")]
		public string SessionKey;
	}
}
