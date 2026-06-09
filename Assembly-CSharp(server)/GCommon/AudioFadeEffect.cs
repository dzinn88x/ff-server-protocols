using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000EB6 RID: 3766
	[Token(Token = "0x2000EB6")]
	internal class AudioFadeEffect
	{
		// Token: 0x06003392 RID: 13202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003392")]
		[Address(RVA = "0x25DDDCC", Offset = "0x25DDDCC", VA = "0x7BBCDDDDCC")]
		public AudioFadeEffect()
		{
		}

		// Token: 0x040047BA RID: 18362
		[Token(Token = "0x40047BA")]
		[FieldOffset(Offset = "0x10")]
		public AudioResource AudioRes;

		// Token: 0x040047BB RID: 18363
		[Token(Token = "0x40047BB")]
		[FieldOffset(Offset = "0x18")]
		public float TargetVolume;

		// Token: 0x040047BC RID: 18364
		[Token(Token = "0x40047BC")]
		[FieldOffset(Offset = "0x1C")]
		public bool IsClosed;

		// Token: 0x040047BD RID: 18365
		[Token(Token = "0x40047BD")]
		[FieldOffset(Offset = "0x20")]
		public float volumeChangeSpeed;
	}
}
