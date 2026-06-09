using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EB5 RID: 3765
	[Token(Token = "0x2000EB5")]
	public class AudioResWithCallBackDefault : AudioResWithCallBackBase
	{
		// Token: 0x0600338E RID: 13198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600338E")]
		[Address(RVA = "0x25E3B08", Offset = "0x25E3B08", VA = "0x7BBCDE3B08", Slot = "10")]
		protected override void OnOnCollected()
		{
		}

		// Token: 0x0600338F RID: 13199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600338F")]
		[Address(RVA = "0x25E3B18", Offset = "0x25E3B18", VA = "0x7BBCDE3B18")]
		public void UnloadAudioData()
		{
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003390")]
		[Address(RVA = "0x25E3C9C", Offset = "0x25E3C9C", VA = "0x7BBCDE3C9C", Slot = "11")]
		public override void ReturnToPool(bool is_from_stop = false)
		{
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003391")]
		[Address(RVA = "0x25E3D18", Offset = "0x25E3D18", VA = "0x7BBCDE3D18")]
		public AudioResWithCallBackDefault()
		{
		}

		// Token: 0x040047B7 RID: 18359
		[Token(Token = "0x40047B7")]
		[FieldOffset(Offset = "0x30")]
		public AudioSource Audio;

		// Token: 0x040047B8 RID: 18360
		[Token(Token = "0x40047B8")]
		[FieldOffset(Offset = "0x38")]
		public bool IsNeedUnloadAudioData;

		// Token: 0x040047B9 RID: 18361
		[Token(Token = "0x40047B9")]
		[FieldOffset(Offset = "0x40")]
		public ObjectPool<AudioResWithCallBackDefault> OwnedPool;
	}
}
