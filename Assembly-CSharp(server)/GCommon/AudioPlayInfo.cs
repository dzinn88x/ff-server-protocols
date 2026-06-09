using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000EC0 RID: 3776
	[Token(Token = "0x2000EC0")]
	public class AudioPlayInfo
	{
		// Token: 0x060033E5 RID: 13285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E5")]
		[Address(RVA = "0x25E3A38", Offset = "0x25E3A38", VA = "0x7BBCDE3A38")]
		public AudioPlayInfo()
		{
		}

		// Token: 0x040047EB RID: 18411
		[Token(Token = "0x40047EB")]
		[FieldOffset(Offset = "0x10")]
		public ResourceID ResID;

		// Token: 0x040047EC RID: 18412
		[Token(Token = "0x40047EC")]
		[FieldOffset(Offset = "0x18")]
		public string OwnedObjectName;

		// Token: 0x040047ED RID: 18413
		[Token(Token = "0x40047ED")]
		[FieldOffset(Offset = "0x20")]
		public EAudioDebugType DebugType;

		// Token: 0x040047EE RID: 18414
		[Token(Token = "0x40047EE")]
		[FieldOffset(Offset = "0x24")]
		public EAudioEngineType EngineType;

		// Token: 0x040047EF RID: 18415
		[Token(Token = "0x40047EF")]
		[FieldOffset(Offset = "0x28")]
		public float StartTimeStamp;

		// Token: 0x040047F0 RID: 18416
		[Token(Token = "0x40047F0")]
		[FieldOffset(Offset = "0x2C")]
		public bool IsRemoved;
	}
}
