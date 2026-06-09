using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000EB4 RID: 3764
	[Token(Token = "0x2000EB4")]
	public class AudioResWithCallBackBase : ObjectPoolCallbackBase
	{
		// Token: 0x0600338A RID: 13194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600338A")]
		[Address(RVA = "0x25E3A40", Offset = "0x25E3A40", VA = "0x7BBCDE3A40", Slot = "8")]
		public override void OnCollected()
		{
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600338B")]
		[Address(RVA = "0x25E3AF0", Offset = "0x25E3AF0", VA = "0x7BBCDE3AF0", Slot = "10")]
		protected virtual void OnOnCollected()
		{
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600338C")]
		[Address(RVA = "0x25E3AF4", Offset = "0x25E3AF4", VA = "0x7BBCDE3AF4", Slot = "11")]
		public virtual void ReturnToPool(bool is_from_stop = false)
		{
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600338D")]
		[Address(RVA = "0x25E3B00", Offset = "0x25E3B00", VA = "0x7BBCDE3B00")]
		public AudioResWithCallBackBase()
		{
		}

		// Token: 0x040047B3 RID: 18355
		[Token(Token = "0x40047B3")]
		[FieldOffset(Offset = "0x14")]
		public ResourceID AudioID;

		// Token: 0x040047B4 RID: 18356
		[Token(Token = "0x40047B4")]
		[FieldOffset(Offset = "0x18")]
		public float TargetVolume;

		// Token: 0x040047B5 RID: 18357
		[Token(Token = "0x40047B5")]
		[FieldOffset(Offset = "0x20")]
		public AudioEndInternalCallBack EndCallBack;

		// Token: 0x040047B6 RID: 18358
		[Token(Token = "0x40047B6")]
		[FieldOffset(Offset = "0x28")]
		private bool m_IsFromStop;
	}
}
