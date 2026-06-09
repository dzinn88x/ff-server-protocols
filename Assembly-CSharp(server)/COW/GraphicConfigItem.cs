using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001104 RID: 4356
	[Token(Token = "0x2001104")]
	public class GraphicConfigItem
	{
		// Token: 0x06004412 RID: 17426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004412")]
		[Address(RVA = "0x1D8EB10", Offset = "0x1D8EB10", VA = "0x7BBC58EB10")]
		public GraphicConfigItem()
		{
		}

		// Token: 0x04005412 RID: 21522
		[Token(Token = "0x4005412")]
		[FieldOffset(Offset = "0x10")]
		public bool fog;

		// Token: 0x04005413 RID: 21523
		[Token(Token = "0x4005413")]
		[FieldOffset(Offset = "0x14")]
		public float lodBias;

		// Token: 0x04005414 RID: 21524
		[Token(Token = "0x4005414")]
		[FieldOffset(Offset = "0x18")]
		public int shaderLOD;

		// Token: 0x04005415 RID: 21525
		[Token(Token = "0x4005415")]
		[FieldOffset(Offset = "0x1C")]
		public int qualitySetting;

		// Token: 0x04005416 RID: 21526
		[Token(Token = "0x4005416")]
		[FieldOffset(Offset = "0x20")]
		public bool terrainShadow;

		// Token: 0x04005417 RID: 21527
		[Token(Token = "0x4005417")]
		[FieldOffset(Offset = "0x21")]
		public bool hdLocalPlayer;

		// Token: 0x04005418 RID: 21528
		[Token(Token = "0x4005418")]
		[FieldOffset(Offset = "0x22")]
		public bool hdTeammate;

		// Token: 0x04005419 RID: 21529
		[Token(Token = "0x4005419")]
		[FieldOffset(Offset = "0x23")]
		public bool hd3PInWaitingRoom;

		// Token: 0x0400541A RID: 21530
		[Token(Token = "0x400541A")]
		[FieldOffset(Offset = "0x24")]
		public int postEffectMask;

		// Token: 0x0400541B RID: 21531
		[Token(Token = "0x400541B")]
		[FieldOffset(Offset = "0x28")]
		public int appendixStreamingRange;
	}
}
