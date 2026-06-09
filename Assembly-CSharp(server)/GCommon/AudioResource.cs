using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EB2 RID: 3762
	[Token(Token = "0x2000EB2")]
	public class AudioResource : ObjectPoolCallbackBase
	{
		// Token: 0x06003382 RID: 13186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003382")]
		[Address(RVA = "0x25E3D20", Offset = "0x25E3D20", VA = "0x7BBCDE3D20", Slot = "8")]
		public override void OnCollected()
		{
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003383")]
		[Address(RVA = "0x25E3DB0", Offset = "0x25E3DB0", VA = "0x7BBCDE3DB0")]
		public void UnloadAudioData()
		{
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003384")]
		[Address(RVA = "0x25E3F34", Offset = "0x25E3F34", VA = "0x7BBCDE3F34")]
		public void ReturnToPool()
		{
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003385")]
		[Address(RVA = "0x25E3F98", Offset = "0x25E3F98", VA = "0x7BBCDE3F98")]
		public AudioResource()
		{
		}

		// Token: 0x040047AE RID: 18350
		[Token(Token = "0x40047AE")]
		[FieldOffset(Offset = "0x14")]
		public ResourceID AudioID;

		// Token: 0x040047AF RID: 18351
		[Token(Token = "0x40047AF")]
		[FieldOffset(Offset = "0x18")]
		public AudioSource Audio;

		// Token: 0x040047B0 RID: 18352
		[Token(Token = "0x40047B0")]
		[FieldOffset(Offset = "0x20")]
		public bool IsNeedUnloadAudioData;

		// Token: 0x040047B1 RID: 18353
		[Token(Token = "0x40047B1")]
		[FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		// Token: 0x040047B2 RID: 18354
		[Token(Token = "0x40047B2")]
		[FieldOffset(Offset = "0x28")]
		public ObjectPool<AudioResource> OwnedPool;
	}
}
